using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp86
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] a = new float[100];
            for (int i = 0; i < 100; i++)
            {
                a[i] = float.Parse(Console.ReadLine());
                if (a[i] <= 10)
                {
                    Console.WriteLine("A[{0}] = {1:f1}", i, a[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
