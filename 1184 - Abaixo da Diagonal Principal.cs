using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp96
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            float soma = 0, media = 0;
            char o = char.Parse(Console.ReadLine().ToUpper());
            float[,] m = new float[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    m[i, j] = float.Parse(Console.ReadLine());
                    if (i > contador)
                    {
                        soma += m[i, j];
                        contador++;
                    }
                }
                contador = 0;
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
        }
    }
}
