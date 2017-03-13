using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
 /* 
 Let's go through some basic rules:

Everything is divisible by 1.
If something is divisible by 16, then it's divisible by 2, 4, and 8.
If something is divisible by 9, then it's divisible by 3.
If something is divisible by both 16 and 9, then it's divisible by 6, 12, and 18.
If something is divisible by both 16 and 5, then it's divisible by 10 and 20.
If something is divisible by both 16 and 7, then it's divisible by 14.
If something is divisible by both 9 and 5, then it's divisible by 15.
That leaves: 5, 7, 9, 11, 13, 16, 17, 19.Multiply those together and you get the Answer */

            int i = 20;
            while (i % 2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 ||
         i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0 ||
         i % 10 != 0 || i % 11 != 0 || i % 12 != 0 || i % 13 != 0 ||
         i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
         i % 18 != 0 || i % 19 != 0 || i % 20 != 0)
            {
              
               i+=20;
            }
            Console.Write(i);
            Console.Read();
        }
    }
}

