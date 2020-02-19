using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet_Exercise
{
    class Reverse_FullName
    {
        public void reverse_name()
        {
            Console.WriteLine("Enter the fullname");
            String s = Console.ReadLine();
            
            char[] c = s.ToCharArray();
            char[] answer = new char[c.Length];
            for(int i=0, j=s.Length-1;i<s.Length;i++,j--)
            {
                answer[i] = c[j];
            }
            String rs = new String(answer);
            Console.WriteLine("The string is:" + s);
            Console.WriteLine("The Reverse_string is:" + rs);
        }
    }
}
