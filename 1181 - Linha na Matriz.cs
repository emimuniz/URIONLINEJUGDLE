using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp92
{
    class Program
    {
        static void Main(string[] args)
        {
            float soma = 0, media = 0;
            float[,] m = new float[12, 12];
            int l = int.Parse(Console.ReadLine());
            while (l < 0 || l > 11)
            {
                l = int.Parse(Console.ReadLine());
            }
            char calculo = char.Parse(Console.ReadLine().ToUpper());
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    m[i, j] = float.Parse(Console.ReadLine());
                    if (l == i)
                    {
                        if (calculo == 'S')
                        {
                            soma += m[i, j];
                        }

                        else if (calculo == 'M')
                        {
                            soma += m[i, j];
                            media = soma / 12;
                        }

                    }
                }
            }
            if (calculo == 'S')
            {
                Console.WriteLine("{0:f1}", soma);
            }
            else if (calculo == 'M')
            {
                Console.WriteLine("{0:f1}", media);
            }
        }
    }
}
