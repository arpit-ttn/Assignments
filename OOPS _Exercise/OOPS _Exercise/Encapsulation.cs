using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__Exercise
{
    class Encapsulation
    {
        //member variables
        private int x;
        private int y;

        public Encapsulation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Multiplication()
        {
            return x * y;
        }
    }
    public class Abstraction_Base_class
    {
        public void A1()
        {
            Console.WriteLine("Base class");
        }
    }
    public class Abstraction_Derived_class : Abstraction_Base_class
    {
        public new void A1()
        {
            Console.WriteLine("Derived class");
        }
    }

  
}
