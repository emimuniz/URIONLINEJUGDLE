using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp107
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int n = int.Parse(Console.ReadLine());
            while (contador <= n)
            {
                if (contador != n)
                {
                    Console.Write("Ho ");
                }
                else
                {
                    Console.Write("Ho!\n");
                }
                contador++;
            }

            Console.ReadKey();
        }
    }
}
