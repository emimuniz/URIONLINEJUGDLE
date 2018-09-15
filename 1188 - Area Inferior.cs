using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0, media = 0;
            int linha = 5, quantidade = 6, contador = linha;
            char o = char.Parse(Console.ReadLine().ToUpper());
            double[,] m = new double[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    m[i, j] = double.Parse(Console.ReadLine());
                    if (i > 6 && j == contador && contador <= quantidade)
                    {
                        soma += m[i, j];
                        contador++;
                    }
                }
                if (i > 6)
                {
                    quantidade++;
                    linha--;
                    contador = linha;
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

            Console.ReadKey();
        }
    }
}
