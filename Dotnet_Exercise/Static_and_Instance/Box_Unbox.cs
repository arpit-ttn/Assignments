using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet_Exercise
{
    class Box_Unbox
    {
        public void Boxing()
        {
            int i = 32;       //boxing
            object o = i;
            Console.WriteLine("Box value: {0}",o);

            object O = 32;     //unboxing
            int j = Convert.ToInt32(o);
            Console.WriteLine("Unbox value: {0}",O);
        }
    }
}
