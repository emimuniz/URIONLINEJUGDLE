using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {
            int casos, contador = 0, x = 0, y = 0;
            int contador1 = 0, contador2 = 0, s = 0;
            casos = int.Parse(Console.ReadLine());
            while (contador < casos)
            {
                contador++;
                string[] linha = Console.ReadLine().Split(' ');
                x = int.Parse(linha[0]);
                y = int.Parse(linha[1]);
                contador2 = x;
                while (contador1 < y || contador1 > y)
                {

                    if (contador2 % 2 != 0)
                    {
                        s += contador2;
                        contador1++;

                    }
                    contador2++;

                }

                Console.WriteLine(s);
                contador1 = 0;
                s = 0;

            }

            Console.ReadKey();
        }
    }
}
