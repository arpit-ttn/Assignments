using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__Exercise
{
        public class Virtual_Method
    {
            public virtual void subject1()
            {
                Console.WriteLine("Virtual Method");
            }
        public virtual void subject2()
        {
            Console.WriteLine("Virtual Method");
        }
    }
        public class Virtual_derived : Virtual_Method
        {
            public override void subject1()
            {
                Console.WriteLine("A virtual method is a method that can be redefined in derived classes." +
                    "\nA virtual method has an implementation in a base class as well as derived the class. " +
                    "\nA virtual method is created in the base class that can be overriden in the derived class." +
                    "\nWe create a virtual method in the base class using the virtual keyword and that method is overriden in the derived class using the override keyword.");
            }
        public sealed override void subject2()
        {
            Console.WriteLine("To preventing Derived class from overriding virtual members we use sealed keyword.");
        }
        //class virtual_derived2:Virtual_derived
              // now if we want to overirde the method we cannot do it further
    }
    }

