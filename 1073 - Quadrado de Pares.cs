using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado_de_Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, cont, par;
            Console.Write("Digite um numero: ");
            n = double.Parse(Console.ReadLine());
            cont = 0;
            while(cont <= n)
            {
                cont++;
                if (cont % 2 == 0)
                {
                    par = Math.Pow(cont, 2);
                    Console.WriteLine(cont+"^2 = "+par);
                    cont++;
                }

            }
            Console.ReadKey();
        }
    }
}
