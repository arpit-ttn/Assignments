using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet_Exercise
{
    class Leap_year
    {
        
        public void leap() { 
            Console.WriteLine("Enter the year");
            int year=int .Parse(Console.ReadLine());
            if(year%4==0) // first this condition will be checked
            {
                if (year % 100 == 0)
                {
                   if (year % 400 == 0)
                    {
                        Console.WriteLine("Leap Year");
                    }
                   else
                    {
                        Console.WriteLine("Not a leap year"); 
                    }
                }
                else
                {
                    Console.WriteLine("Leap year");
                }

            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
        }

    }
}
