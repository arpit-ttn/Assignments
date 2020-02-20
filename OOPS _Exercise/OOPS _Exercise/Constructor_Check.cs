using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__Exercise
{
    class Base_B
    {
        static Base_B()
        {
            Console.WriteLine("Static Constructor of Base class Base_B");
        }

        public Base_B()
        {
            Console.WriteLine("Default constructor of Base class Base_B");
        }
        public Base_B(int a, int b)
        {
            Console.WriteLine("Parametrised Constructor of Base class Base_B");
        }
    }
    class Constructor_Check : Base_B
    {
        static Constructor_Check()
        {
            Console.WriteLine("Static Constructor of derived class Constructor_check");
        }

        public Constructor_Check()
        {
            Console.WriteLine("Default constructor of derived class Constructor_check");
        }
        public Constructor_Check(int a, int b) :base(a,b)
        {
            Console.WriteLine("Parametrised Constructor  of derived class Constructor_check");
        }
    }
}
