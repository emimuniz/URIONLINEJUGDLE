using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont;
            float x = 0, y = 0;
            n = int.Parse(Console.ReadLine());
            cont = 1;
            while (cont <= n)
            {

                string[] linha = Console.ReadLine().Split(' ');
                x = float.Parse(linha[0]);
                y = float.Parse(linha[1]);
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    float div = x / y;
                    Console.WriteLine("{0:f1}", div);
                }

                cont++;
            }

            Console.ReadKey();
        }
    }
}
