using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int sum = 0;
            while (y<4000000)
            {
               
                if (y%2 ==0)
                {
                    sum += y;
                    Console.WriteLine(sum.ToString());
                }
                int temp = x + y;
                x = y;
                y = temp;
            }
        
            Console.Read();
        }
    }
}
