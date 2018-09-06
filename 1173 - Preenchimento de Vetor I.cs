using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            n[0] = int.Parse(Console.ReadLine());
            if (n[0] >= 50)
            {
                n[0] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, n[0]);
                n[0] *= 2;


            }

            Console.ReadKey();
        }
    }
}
