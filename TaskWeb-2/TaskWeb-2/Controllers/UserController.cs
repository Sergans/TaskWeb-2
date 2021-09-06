using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.DAL;
using TaskWeb_2.Models;
using Microsoft.AspNetCore.Authorization;

namespace TaskWeb_2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromQuery] string user, string password)
        {
            TokenResponse token = _userService.Authenticate(user, password);

            if (token is null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
            SetTokenCookie(token.RefreshToken);
            return Ok(token);

        }
        [Authorize]
        [HttpPost("refresh-token")]
        public IActionResult Refresh()
        {
            string oldRefreshToken = Request.Cookies["refreshToken"];
            string newRefreshToken = _userService.RefreshToken(oldRefreshToken);
            if (string.IsNullOrWhiteSpace(newRefreshToken))
            {
                return Unauthorized(new { message = "Invalid token" });
            }
            SetTokenCookie(newRefreshToken);
            return Ok(newRefreshToken);
        }
        private void SetTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };
            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }
        [HttpGet("get/user")]
        [Authorize]
        public IActionResult Get()
        {
           return Ok(_userService.AllGet());
        }
        [HttpPost("create/user")]
        public IActionResult Create([FromQuery]string login,[FromQuery]string password,[FromQuery]string fname,[FromQuery] string lname)
        {
            var user = new UserModel { Login = login, Password = password, FirstName = fname, LastName = lname };
            _userService.Create(user);
            return Ok();
        }
        [HttpDelete("delete/user")]
        public IActionResult Delete(int iduser)
        {
            _userService.Delete(iduser);
            return Ok();
        }

    }
}
