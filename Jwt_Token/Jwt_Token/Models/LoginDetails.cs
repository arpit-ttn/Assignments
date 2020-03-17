using System;
using System.Collections.Generic;

namespace Jwt_Token.Models
{
    public partial class LoginDetails
    {
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string Roles { get; set; }
    }
}
