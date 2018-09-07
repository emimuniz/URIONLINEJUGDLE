using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    class Program
    {
        static void Main(string[] args)
        {
            float soma = 0, media = 0;
            int c = int.Parse(Console.ReadLine());
            char calcula = char.Parse(Console.ReadLine().ToUpper());
            float[,] m = new float[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    m[i, j] = float.Parse(Console.ReadLine());
                    if (j == c)
                    {
                        if (calcula == 'S')
                        {
                            soma += m[i, j];
                        }
                        else if (calcula == 'M')
                        {
                            soma += m[i, j];
                            media = soma / 12;
                        }
                    }
                }
            }
            if (calcula == 'S')
            {
                Console.WriteLine("{0:f1}", soma);
            }

            if (calcula == 'M')
            {
                Console.WriteLine("{0:f1}", media);
            }
        }
    }
}
