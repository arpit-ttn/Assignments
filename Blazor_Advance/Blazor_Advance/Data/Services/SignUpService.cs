using Blazor_Advance.Data.Interface;
using Blazor_Advance.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Advance.Data.Services
{
    public class SignUpService :ISignUp
    {
        public bool Insert(UserDetails userDetails)
        {
            try
            {
                using (var context = new StudentContext())
                {

                    context.UserDetails.Add(userDetails);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
    
}
