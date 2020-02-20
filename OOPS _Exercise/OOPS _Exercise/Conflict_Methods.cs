using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__Exercise
{
        interface Interface1
        {
        public void a1();
        }
        interface Interface2
        {
        public void a1();
        }
    class Conflict_Methods : Interface1, Interface2
    {
        void Interface1.a1()
        {
            Console.WriteLine("\nIn case if the inherited interfaces have conflicting method names then this method will be called with the First interface name ");
        }
        void Interface2.a1()
        {
            Console.WriteLine("\nIn case if the inherited interfaces have conflicting method names then this method will be called with the second interface name");
        }



    }
}
