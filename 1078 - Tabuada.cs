using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont;
            cont = 0;
            Console.Write("");
            n = int.Parse(Console.ReadLine());
            if (n > 2 && 1000 > n)
            {
                while (cont < 10)
                {
                    cont++;
                    Console.WriteLine(cont + " x " + n + " = " + cont * n);
                }
            }

            Console.ReadKey();

        }
    }
}
