using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Basic.Models
{
    interface IDriver
    {
        IEnumerable<Driver> GetDriver();
        void Save(Driver driver);

    }
}
