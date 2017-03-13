using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            const long numm = 600851475143;
            long newnumm = numm;
            long largestFact = 0;
            sw.Start();
            int counter = 2;
            while (counter * counter <= newnumm)
            {
                if (newnumm % counter == 0)
                {
                    newnumm = newnumm / counter;
                    largestFact = counter;
                }
                else
                {
                    counter++;
                }
            }
            if (newnumm > largestFact)
            { // the remainder is a prime number
                largestFact = newnumm;
            }
            sw.Stop();
            Console.WriteLine("Time Elapsed: " + sw.ElapsedMilliseconds.ToString() +"ms");
            Console.Write("Largest Factor: "+largestFact.ToString());
            Console.Read();
        }
    }
}
