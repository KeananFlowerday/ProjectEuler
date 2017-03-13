using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    total += i;
                    Console.WriteLine(total);
                }
                else if (i % 5 == 0)
                {
                    total = total + i;
                    Console.WriteLine(total);
                }
            }
            Console.Read();
        }
    }
}
