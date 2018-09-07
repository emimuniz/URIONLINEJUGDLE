using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pares = new int[15];
            int[] impares = new int[15];
            int numero, contpares = 0, contimpares = 0;
            for (int i = 0; i < 15; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    pares[contpares] = numero;
                    contpares++;
                }
                else
                {
                    impares[contimpares] = numero;
                    contimpares++;
                }

                if (contpares == 5)
                {
                    for (contpares = 0; contpares < 5; contpares++)
                    {
                        Console.WriteLine("par[{0}] = {1}", contpares, pares[contpares]);
                    }

                    contpares = 0;
                }

                if (contimpares == 5)
                {
                    for (contimpares = 0; contimpares < 5; contimpares++)
                    {
                        Console.WriteLine("impar[{0}] = {1}", contimpares, impares[contimpares]);
                    }
                    contimpares = 0;
                }

                int quantidadepares = contpares;
                int quantidadeimpares = contimpares;
                if (i == 14)
                {
                    for (contimpares = 0; contimpares < quantidadeimpares; contimpares++)
                    {
                        Console.WriteLine("impar[{0}] = {1}", contimpares, impares[contimpares]);
                    }

                    for (contpares = 0; contpares < quantidadepares; contpares++)
                    {
                        Console.WriteLine("par[{0}] = {1}", contpares, pares[contpares]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
