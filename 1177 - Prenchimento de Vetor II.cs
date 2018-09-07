using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            t = int.Parse(Console.ReadLine());
            if (2 >= t && t <= 50)
            {
                t = int.Parse(Console.ReadLine());
            }

            int[] n = new int[1000];
            int x = 0;
            for (int i = 0; i < 1000; i++)
            {

                Console.WriteLine("N[{0}] = {1}", i, x);
                x++;
                if (x == t) x = 0;

            }

            Console.ReadKey();
        }
    }
}
