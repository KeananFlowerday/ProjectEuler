using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 100;
            double a = sumofsquares(size);
            double b = squareofsums(size);
            Console.WriteLine("{0} - {1} = {2}",a,b,b-a);
            Console.Read();
        }

        static double sumofsquares(int s)
        {
            int ans = 0;
            for (int i = 1; i <= s; i++)
            {
                ans += (int)Math.Pow(i,2);
            }

            return ans;
        }

        static double squareofsums(int s)
        {
            int ans = 0;
            for (int i = 1; i <= s; i++)
            {
                ans += i;
            }
           ans =(int) Math.Pow(ans, 2);
            return ans;
        }
    }
}
