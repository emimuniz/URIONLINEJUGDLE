using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            X = 0;
            Y = 1;
            while (X != Y)
            {
                string[] linha = Console.ReadLine().Split(' ');
                X = int.Parse(linha[0]);
                Y = int.Parse(linha[1]);

                if (X > Y)
                {
                    Console.WriteLine("Decrescente");

                }
                if (Y > X)
                {
                    Console.WriteLine("Crescente");

                }


            }

            Console.ReadKey();
        }
    }
}
