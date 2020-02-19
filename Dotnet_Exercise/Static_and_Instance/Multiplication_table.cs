using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet_Exercise
{
    class Multiplication_table
    {
        public void table()  
        {
            Console.WriteLine(" Display the multiplication table vertically from 1 to 5");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + i * j);
                }
                Console.WriteLine("\n");
            }
            
        }
    }
}
