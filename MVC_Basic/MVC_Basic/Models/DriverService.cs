using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Basic.Models
{
    public class DriverService : IDriver
    {
        readonly IEnumerable<Driver> driver;

        public DriverService()
        {
            driver = new List<Driver>
            { 
                new Driver{Driver_id = 1, DriverName="Arpit",DriverAddress="Australia",DriverAge=22},
                new Driver{Driver_id = 2, DriverName="Azeem",DriverAddress="Budapest",DriverAge=24},
                new Driver{Driver_id = 3, DriverName="Vishesh",DriverAddress="Dubai",DriverAge=21},
                new Driver{Driver_id = 4, DriverName="Abhishek",DriverAddress="Britain",DriverAge=22},
                new Driver{Driver_id = 5, DriverName="Vijay",DriverAddress="India",DriverAge=26}   
            };
        }
        public IEnumerable<Driver> GetDriver()
        {
            return driver;
        }
        public void Save(Driver driver)
        {
           
        }
    }
}