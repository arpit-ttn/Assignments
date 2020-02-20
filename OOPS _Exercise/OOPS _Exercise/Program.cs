using System;

namespace OOPS__Exercise
{
    public abstract class Student  //Abstract class can have implemnetations for some of its members
    {
        public void Name()         //Abstract class members can have access modifiers and it is private by default
        {
            Console.WriteLine("Abstract class method will be called");
        }
    }

    public interface IStudent //Interface can't have implementations for its members 
    {
         void Name()  //Interface members are public by default and they can't have access modifiers 
        {
            Console.WriteLine(""); // this definiton will never be called
        }
    }
    class Program : Student  // We have inherited the abstract class into the program class
    {
        static void Main(string[] args)
        {
            //Question-1
            Console.WriteLine("Q-1 What is the difference between abstract class and interface ?");
            Student s = new Program();
            s.Name();
            Console.WriteLine("\nAbstract class can have implemnetations for some of its members " +
                "while\nInterface can't have implementations for its members " +
                "\nAbstract class members can have access modifiers and it is private by default " +
                "while\nInterface members are public by default and they can't have access modifiers ");

            //Question 2
            Console.WriteLine("\nQ-2 What is method overloading and methodoverriding ?");
            Base_class b = new Derived_class();
            b.subject();
            Console.WriteLine("Method Overriding is a specific implementation of a method that is already provided by one of its parent classes." +
                "We use override keyword to overide a method");

            overlaoding o = new overlaoding();
            String s1 = o.Add("A","D");
            String s2 = o.Add("R", "S");
            Console.WriteLine("String 1 is : {0}", s1);
            Console.WriteLine("String 2 is : {0}", s2);
            Console.WriteLine("Method overloading is a feature that allows a class to have more than one method having the same name even if their argument lists are different.");

            //Question-3
            Console.WriteLine("\nQ-3 What would happen in case if the inherited interfaces have conflicting method names ?");
            Interface1 cm = new Conflict_Methods();
            cm.a1();
            Interface2 cm2 = new Conflict_Methods();
            cm2.a1();

            //Question-4
            Console.WriteLine("\nQ-4 What are the different ways a method can be overloaded ?");
            Console.WriteLine("\n1:Different parameters data types" +
                "\n2:Different number of parameters");
            Different_ways dw = new Different_ways();
            String plus1 = dw.Add("A", "D");
            int plus2 = dw.Add(10,20,30);
            float plus3 = dw.Add(15, 30F);
            float plus4 = dw.Add(10F, 12F, 14F);

            Console.WriteLine("Combined String is : {0}", plus1);
            Console.WriteLine("Sum of integer values is : {0}", plus2);
            Console.WriteLine("Sum of integer and float value is : {0}", plus3);
            Console.WriteLine("Sum of float values is : {0}", plus4);

            //Question-5
            Console.WriteLine("\nQ-5 What is virtual method in c# ?");
            Virtual_Method v = new Virtual_derived();
            v.subject1();
            //Question-6
            Console.WriteLine("\nQ-6 How to preventing Derived class from overriding virtual members ?");
            Virtual_Method v2 = new Virtual_derived();
            v2.subject2();


            //Question-7
            Console.WriteLine("\nQ-7 Write a program to for parameterised constructor and call the same from derived class ?");
            
            Constructor_Check c1 = new Constructor_Check();
            Constructor_Check c = new Constructor_Check(10, 20);


            //Question-8
            Console.WriteLine("\nQ-8 Write a program to explain encapsulation and abstraction ?");
            Encapsulation e = new Encapsulation(10,20);
            int multiply=e.Multiplication();
            Console.WriteLine("Multiplication value is: {0}",multiply);

            Abstraction_Derived_class derived = new Abstraction_Derived_class();
            derived.A1();
            Console.WriteLine("Encapsulation is binding up of data in different access modifiers under one name." +
                "\nAbstraction is a data hinding technique and showing only essential information to the user.");

            //Question-9
            Console.WriteLine("\nQ-9 What is Operator Overloading ?");
            Operator_Overloading n1 = new Operator_Overloading(10);
            Operator_Overloading n2 = new Operator_Overloading(20);
            Operator_Overloading n3 = new Operator_Overloading();
            n3 = n1 * n2;
            n1.display(); 
            n2.display(); 
            n3.display();
            Console.WriteLine("\nOperator overloading gives the ability to use the same operator to do various operations.");

        }
    }
}
