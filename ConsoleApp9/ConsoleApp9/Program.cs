using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

                    a2 + b2 = c2
                For example, 32 + 42 = 9 + 16 = 25 = 52.

                There exists exactly one Pythagorean triplet for which a +b + c = 1000.
                Find the product abc.                         
                Answer:
                                31 875 000                                                                                                */
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int length = 500;
            int ans = 0;
            int aa = 0, bb = 0, cc = 0;
            for (int c = 0; c < length; c++)
            {
                for (int b = 0; b < c; b++)
                {
                    for (int a = 0; a < b; a++)
                    {
                        if(isTriplet(c,b,a))
                        {
                            if (a+b+c == 1000)
                            {
                                ans = a * b * c ;
                                aa = a;
                                bb = b;
                                cc = c;
                                break;
                            }
                        }
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("Answer : {0} x {1} x {2} = {3}",aa,bb,cc,ans);
            Console.WriteLine("Time : {0} ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        static bool isTriplet(int c, int b, int a)
        {
            int aa = a * a;
            int bb = b * b;
            int cc = c * c;

            if(aa+bb == cc)
            {
                return true;
            }
            else
            { 
            return false;
            }
        }
    }
}
