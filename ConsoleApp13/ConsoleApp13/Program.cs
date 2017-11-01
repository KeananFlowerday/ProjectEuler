using System;
using System.IO;
using System.Numerics;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Solve();
            Console.Read();
        }

        public void Solve()
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Input2.txt";
            DateTime startTime = DateTime.Now;

            BigInteger sum = readInput(filename);
            string ans = sum.ToString().Remove(10);
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;
            Console.WriteLine("The sum is {0}", sum );
            Console.WriteLine("First 10 Digits are : {0}", ans);
            Console.WriteLine("Solution took {0} ms", duration.TotalMilliseconds);
        }

        private BigInteger readInput(string filename)
        {
            
            

            StreamReader r = new StreamReader(filename);
            BigInteger result = new BigInteger();
            string line;
           

            while ((line = r.ReadLine()) != null)
            {
                result += BigInteger.Parse(line);
            }

            r.Close();

            return result;
        }
    }
}
