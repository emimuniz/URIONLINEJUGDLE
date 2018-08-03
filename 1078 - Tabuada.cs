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
            int localizarLinha = 0, localizarColuna = 1, contagem = 1;
            float soma = 0, media = 0;
            char o = char.Parse(Console.ReadLine().ToUpper());
            float[,] m = new float[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    m[i, j] = float.Parse(Console.ReadLine());
                    if (j == localizarColuna && i == localizarLinha)
                    {
                        if (o == 'S')
                        {
                            soma += m[i, j];
                        }
                        else if (o == 'M')
                        {
                            soma += m[i, j];
                            media = soma / 66;
                        }
                        localizarColuna++;
                    }
                }
                contagem++;
                localizarColuna = contagem;
                localizarLinha++;
            }
            if (o == 'S')
            {
                Console.WriteLine("{0:f1}", soma);
            }
            else if (o == 'M')
            {
                Console.WriteLine("{0:f1}", media);
            }

            Console.ReadKey();
        }

    }
}
