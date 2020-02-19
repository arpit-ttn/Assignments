using System;

namespace Dotnet_Exercise
{
   
    class D
    {
        public static float x = 5.65F; // static variable

        int _y ; // instance variable
        public D(int y)
        {
            this._y = y;
        }
        public float Multiplication()
        {
            return D.x * this._y;
        }

    }
    class Demo:Access_Modifiers //we have use inheritance here
    {
        string str5 = "Private String";

        public void acc() //Method of access modifiers
        {
            Console.WriteLine("public member a : {0}",str1);
            Console.WriteLine("protected member a : {0}",str2);
            Console.WriteLine("internal member a : {0}",str3);
            Console.WriteLine("internal protected member a : {0}",str4);
            Console.WriteLine("private member a : {0}",str5);

        }
        public static void Main(string[] args) //main method of all classes
        {
            D a1 = new D(10);  //a1 is the instance of class
            D a2 = new D(20);

            float A = a1.Multiplication();
            float B = a2.Multiplication();

            Console.WriteLine("Question-1 To Show Difference Between Static and Instance members");
            Console.WriteLine("\n Value of x = {0}",D.x);
      
            Console.WriteLine("Answer Of A is = {0}",A);
            Console.WriteLine("Answer Of B is = {0}",B);

            Console.WriteLine("\n Question-2 To Find the Leap Year");
            Leap_year lp = new Leap_year();
            lp.leap();

            Console.WriteLine("\n Question-3 To check Consonant and Vowel");
            Consonant_and_Vowel cv = new Consonant_and_Vowel();
            cv.cons_vow();

            Consonant_and_Vowel cv1 = new Consonant_and_Vowel();
            cv1.cons_vow1();


            Console.WriteLine("\n Question-4 Boxing and Unboxing");
            Box_Unbox bu = new Box_Unbox();
            bu.Boxing();


            Console.WriteLine("\n Question-6 To define the scope of access modifiers");
            Demo d = new Demo();
            d.acc();

            Console.WriteLine("\n Question-7 To Reverse the Full Name");
            Reverse_FullName rn = new Reverse_FullName();
            rn.reverse_name();

            Console.WriteLine("\n Question-8 Multiplication table from 1 to 5");
            Multiplication_table mt = new Multiplication_table();
            mt.table();




        }
    }
}

