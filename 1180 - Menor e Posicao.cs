using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp91
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            string[] linha = Console.ReadLine().Split(' ');
            int menor = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = int.Parse(linha[i]);
                if (x[0] < menor)
                {
                    menor = x[0];
                }
                if (x[i] < menor)
                {
                    menor = x[i];
                }
            }

            for (int i = 0; i < x.Length; i++)
            {

                if (x[i] == menor)
                {
                    Console.WriteLine("Menor valor: " + menor);
                    Console.WriteLine("Posicao: " + i);
                }
            }

            Console.ReadKey();
        }
    }
}
