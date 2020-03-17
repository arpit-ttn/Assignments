using Jwt_Token.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Jwt_Token.Data
{
    public class Token_jwt : IToken
    {

        public IConfiguration _config;

        public Token_jwt(IConfiguration config)
        {
            _config = config;
        }

        private LoginDetails GetUser(string username, string password, string role)
        {
            var _context = new Models.TokenContext();
            return _context.LoginDetails.FirstOrDefault(u => u.Username == username && u.Userpassword == password && u.Roles == role);
        }
        public string Token_Generate(LoginDetails loginDetails)
        {

            var user = GetUser(loginDetails.Username, loginDetails.Userpassword, loginDetails.Roles); 
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Role,loginDetails.Roles) // role = Admin                   
                };
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddSeconds(60),
                signingCredentials: credentials);

                return (new JwtSecurityTokenHandler().WriteToken(token));


            }
            else
            {
                return ("404 Error!!!!");
            }


        }

        
    }
}
