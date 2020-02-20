using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__Exercise
{


    public class Base_class
    {
        public virtual void subject()
        {
            Console.WriteLine("Subject Method");
        }
    }
    public class Derived_class : Base_class
        {
            public override void subject()
            {
                Console.WriteLine("Override Subject Method");
            }
    }
    public class overlaoding
    {
        public String Add(string a, string b)
        {
            String s1 = a + b;
            return s1;
           
        }
        public String Add(string a, string b,string c)
        {
            String s2 = a + b +c;
            return s2;

        }
    }
}



