using Blazor_Advance.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Advance.Data.Interface
{
    interface ISignUp
    {
        public bool Insert(UserDetails userDetails);
    }
}
