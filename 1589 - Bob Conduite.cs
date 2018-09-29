using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp106
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, r1 = 0, r2 = 0;
            int casos = int.Parse(Console.ReadLine());
            while (contador < casos)
            {
                contador++;
                string[] linha = Console.ReadLine().Split(' ');
                r1 = int.Parse(linha[0]);
                r2 = int.Parse(linha[1]);
                Console.WriteLine(r1 + r2);
            }
            Console.ReadKey();
        }
    }
}
