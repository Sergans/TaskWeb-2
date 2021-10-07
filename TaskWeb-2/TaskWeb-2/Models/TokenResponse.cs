using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWeb_2.Models
{
    public class TokenResponse
    {   
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
