using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp98
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 12, contador = quantidade;
            float soma = 0, media = 0;
            char o = char.Parse(Console.ReadLine());
            float[,] m = new float[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    m[i, j] = float.Parse(Console.ReadLine());
                    if (i > 0 && j == contador)
                    {
                        if (contador <= 11)
                        {
                            soma += m[i, j];
                            contador++;

                        }
                    }
                }

                quantidade--;
                contador = quantidade;
            }

            if (o == 'S')
            {
                Console.WriteLine("{0:f1}", soma);
            }
            else if (o == 'M')
            {
                media = soma / 66;
                Console.WriteLine("{0:f1}", media);
            }
            Console.ReadKey();
        }
    }
}
