using Jwt_Token.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt_Token.Data
{
    public interface IToken
    {
        string Token_Generate(LoginDetails loginDetails);
    }
}
