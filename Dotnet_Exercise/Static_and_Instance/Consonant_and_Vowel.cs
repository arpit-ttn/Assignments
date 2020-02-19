using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet_Exercise
{
    public class Consonant_and_Vowel
    {
        Char c;
        public void cons_vow()
        {

            String s;
            Console.WriteLine("Enter the Character");
            s = Console.ReadLine();
            c = s[0];

            switch (c)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;



                case 'A':
                    Console.WriteLine("Vowel");
                    break;
                case 'E':
                    Console.WriteLine("Vowel");
                    break;
                case 'I':
                    Console.WriteLine("Vowel");
                    break;
                case 'O':
                    Console.WriteLine("Vowel");
                    break;
                case 'U':
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Character is Consonant");
                    break;

            }
          

        }
        
        //Same Question with if-else.

            public void cons_vow1()
            {
            Console.WriteLine("Same Question with If-else statement");
                int uc;
                int lc;
            String s;
            Console.WriteLine("Enter the Character");
            s = Console.ReadLine();
            c = s[0];

            if ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u'))
                    lc = 1;
                else
                    lc = 0;
                if ((c == 'A') || (c == 'E') || (c == 'I') || (c == 'O') || (c == 'U'))
                    uc = 1;
                else
                    uc = 0;
                if (lc == 1 || uc == 1)
                    Console.WriteLine("Vowel");
                else
                    Console.WriteLine("Consonant");
            Console.ReadLine();

            }
        
           

        }
    }

