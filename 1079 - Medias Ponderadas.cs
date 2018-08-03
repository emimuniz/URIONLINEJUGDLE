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
            float p1, p2, p3;
            n = int.Parse(Console.ReadLine());
            cont = 0;
            while (cont < n)
            {
                cont++;
                string[] linha = Console.ReadLine().Split(' ');
                p1 = float.Parse(linha[0]);
                p2 = float.Parse(linha[1]);
                p3 = float.Parse(linha[2]);
                float media = (p1 * 2 + p2 * 3 + p3 * 5) / 10;
                Console.WriteLine("{0:f1}", media);

            }

            Console.ReadKey();
        }

    }
}
