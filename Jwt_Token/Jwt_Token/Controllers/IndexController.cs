using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jwt_Token.Data;
using Jwt_Token.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt_Token.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly IToken _token;
        public IndexController(IToken token)
        {
            _token = token;
        }

        [HttpPost]
        public IActionResult Token(LoginDetails details)
        {
            try
            {
                return Ok(_token.Token_Generate(details));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                string result = "Normal Get";
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IActionResult GetCommon()
        {

            try
            {
                return Ok("This method can be invoked without any authorization.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")] 
        public IActionResult GetADmin()
        {
            try
            {

                return Ok("Hello, admin.");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        [Authorize(Roles = "user")] 
        public IActionResult GetUser()
        {

            try
            {
                return Ok("Hello, User ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





    }
}