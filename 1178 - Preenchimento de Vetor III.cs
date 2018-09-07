using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] n = new decimal[100];
            n[0] = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, Math.Round(n[0], 4));
                n[0] /= 2;
            }

            Console.ReadKey();
        }
    }
}
