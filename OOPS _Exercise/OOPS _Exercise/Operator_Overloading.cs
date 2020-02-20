using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__Exercise
{
    class Operator_Overloading
    {

        public int number = 0; 
        public Operator_Overloading() { }


        // parameterized constructor 
        public Operator_Overloading(int n)
        {
            number = n;
        }

        // Overloading of Binary "*" operator 
        public static Operator_Overloading operator *(Operator_Overloading c1,
                                             Operator_Overloading c2)
        {
            Operator_Overloading c3 = new Operator_Overloading(0);
            c3.number = c2.number /  c1.number;
            return c3;
        }

        // function to display result 
        public void display()
        {
            Console.WriteLine("{0}", number);
        }
    }

}
