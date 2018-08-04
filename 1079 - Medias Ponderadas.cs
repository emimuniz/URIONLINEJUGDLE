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
            int linha = 0, coluna = 1, contador = 1;
            float soma = 0;
            char o = char.Parse(Console.ReadLine());
            float [,] m = new float[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    m[i, j] = float.Parse(Console.ReadLine());
                    if(linha == i && coluna == j)
                    {
                        soma += m[i, j];
                    }
                    coluna++;
                }

                contador++;
                linha++;
                coluna = contador;
            }
            
            Console.WriteLine("{0:f1}", soma);
            Console.ReadKey(); 
        }
    }
}
