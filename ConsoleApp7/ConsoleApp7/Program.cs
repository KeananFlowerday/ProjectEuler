using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long max = 200000;
            List<long> lstPrimes = new List<long>();
            bool[] is_prime = MakeSieve(max);
            for (int i = 2; i < max; i++)
                if (is_prime[i]) lstPrimes.Add(i);
            Console.WriteLine("The 10001st prime is {0}",lstPrimes.ElementAt(10000).ToString());
            sw.Stop();
            Console.WriteLine("Time : {0} ms", sw.ElapsedMilliseconds);
            Console.Read();
        }

        private static bool[] MakeSieve(long max)
        {
            // Make an array indicating whether numbers are prime.
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++) is_prime[i] = true;

            // Cross out multiples.
            for (int i = 2; i <= max; i++)
            {
                // See if i is prime.
                if (is_prime[i])
                {
                    // Knock out multiples of i.
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }
    }
}
