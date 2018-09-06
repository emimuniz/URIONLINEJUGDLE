using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] lista;
            lista = new int[10];

            while (i < 10)
            {
                lista[i] = int.Parse(Console.ReadLine());
                if (lista[i] <= 0)
                {
                    lista[i] = 1;
                }
                Console.WriteLine("X[{0}] = {1}", i, lista[i]);
                i++;
            }

            Console.ReadKey();
        }
    }
}
