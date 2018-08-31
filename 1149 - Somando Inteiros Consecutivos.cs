using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int contlinhas = 1;
            int a = int.Parse(linha[0]);
            int n = int.Parse(linha[contlinhas]);
            while (n <= 0)
            {
                contlinhas++;
                n = int.Parse(linha[contlinhas]);
            }
            int acumulador = a;
            for (int i = 1; i < n; i++)
            {
                acumulador += a + 1;
                a = a + 1;
            }

            Console.WriteLine(acumulador);
            Console.ReadKey();
        }
    }
}
