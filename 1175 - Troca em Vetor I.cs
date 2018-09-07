using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] n = new int[20];
            int a;
            for (int i = 0; i < 20; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                a = n[i];
                n[i] = n[19 - i];
                n[19 - i] = a;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, n[i]);
            }

            Console.ReadKey();
        }
    }
}
