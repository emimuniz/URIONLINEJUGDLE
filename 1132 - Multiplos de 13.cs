using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, soma;
            soma = 0;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            while (X <= Y)
            {
                if (X % 13 != 0)
                {
                    soma += X;

                }

                X++;
            }
            while (X >= Y)
            {
                if (X % 13 != 0)
                {
                    soma += X;
                }

                X--;
            }


            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
