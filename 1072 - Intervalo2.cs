using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contador, numin, nout, nin;
            Console.Write("");
            n = int.Parse(Console.ReadLine());
            contador = 1;
            nout = 0;
            nin = 0;
            while (contador <= n)
            {
                contador++;
                Console.Write("");
                numin = int.Parse(Console.ReadLine());
                if (numin >= 10 && numin <= 20)
                {
                    nin++;
                }
                else
                {
                    nout++;
                }

            }

            Console.WriteLine(nin + " in");
            Console.WriteLine(nout + " out");
            Console.ReadKey();
        }
    }
}
