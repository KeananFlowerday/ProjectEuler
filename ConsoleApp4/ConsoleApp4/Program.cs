using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int max = int.MinValue;
            int maxi= int.MinValue, maxj= int.MinValue;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j >0; j--)
                {
                    if (isPalindrome((i*j).ToString()))
                    {
                        if (i*j>max)
                        {
                            max = i * j;
                            maxi = i;
                            maxj = j;
                        }
                            
                       
                    }
                   
                }
            }

            sw.Stop();
            Console.WriteLine("Time Elapsed: {0} ms", sw.ElapsedMilliseconds);
            Console.WriteLine("{0} x {1} = {2} is the Largest Palindrome. ", maxi, maxj, max);

            Console.Read();
        }


        static bool isPalindrome(string s)
        {
            string pal = "";
            char[] ss = s.ToCharArray();
            Array.Reverse(ss);
            foreach (char c in ss)
            {
                pal += c;
            }
            if (pal.Equals(s))
            {
                return true;
            }
            else return false;
        }
    }
}
