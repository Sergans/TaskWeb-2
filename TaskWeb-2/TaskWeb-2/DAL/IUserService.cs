using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using TaskWeb_2.Models;

namespace TaskWeb_2.DAL
{
   public interface IUserService:IRepository<UserModel>
   {
        TokenResponse Authenticate(string user, string password);
        string RefreshToken(string token);
   }
    internal sealed class UserService : IUserService
    {
        BaseSQL user = new BaseSQL();
        public const string SecretCode = "gans this sergei";
        public TokenResponse Authenticate(string user, string password)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            TokenResponse tokenResponse = new TokenResponse();
            int i = 0;
            foreach (var pair in AllGet())
            {
                i++;
                if (string.CompareOrdinal(pair.Login, user) == 0 && string.CompareOrdinal(pair.Password, password) == 0)
                {
                    tokenResponse.Token = GenerateJwtToken(i, 1);
                    RefreshToken refreshToken = GenerateRefreshToken(i);
                    pair.RefToken = refreshToken;
                    tokenResponse.RefreshToken = refreshToken.Token;
                    return tokenResponse;
                }
            }
            return null;
        }
        string GenerateJwtToken(int id, int minutes)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes(SecretCode);
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
            {
                    new Claim(ClaimTypes.Name, id.ToString())
            }),
                Expires = DateTime.UtcNow.AddMinutes(minutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public string RefreshToken(string token)
        {
            int i = 0;
            foreach (var pair in AllGet())
            {
                i++;
                if (string.CompareOrdinal(pair.RefToken.Token, token) == 0
                    && pair.RefToken.IsExpired is false)
                {
                    pair.RefToken = GenerateRefreshToken(i);
                    return pair.RefToken.Token;
                }
            }
            return string.Empty;
        }
        public RefreshToken GenerateRefreshToken(int id)
        {
            RefreshToken refreshToken = new RefreshToken();
            refreshToken.Expires = DateTime.Now.AddMinutes(360);
            refreshToken.Token = GenerateJwtToken(id, 360);
            return refreshToken;
        }

        public void Create(UserModel item)
        {
            user.User.Add(item);
            user.SaveChanges();
        }

        public List<UserModel> AllGet()
        {
            return (user.User.ToList());
        }

        public void Delete(int iduser)
        {
            foreach (var person in user.User.ToList())
            {
                if (person.Id == iduser)
                {
                    user.Remove(person);
                    user.SaveChanges();
                }

            }
        }

        public void UpData(int item, string fname, string lname)
        {
            throw new NotImplementedException();
        }
    }
}
