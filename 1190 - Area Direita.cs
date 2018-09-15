using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp102
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 11;
            double soma = 0, media = 0;
            char o = char.Parse(Console.ReadLine().ToUpper());
            double[,] m = new double[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    m[i, j] = double.Parse(Console.ReadLine());
                    if (j >= quantidade && i >= 1 && i <= 10)
                    {
                        soma += m[i, j];
                    }
                }
                if (i >= 1 && i < 5)
                {
                    quantidade--;

                }

                else if (i >= 6 && i <= 10)
                {
                    quantidade++;
                }
            }
            if (o == 'S')
            {
                Console.WriteLine("{0:f1}", soma);
            }

            else if (o == 'M')
            {
                media = soma / 30;
                Console.WriteLine("{0:f1}", media);
            }
        }
    }
}
