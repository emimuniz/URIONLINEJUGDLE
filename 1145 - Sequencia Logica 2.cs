using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int cont = 0;
            int cont1 = 0;
            string[] linha = Console.ReadLine().Split(' ');
            x = int.Parse(linha[0]);
            y = int.Parse(linha[1]);
            if (x > 1 && x < 20 && y > x && y < 100000)
            {
                while (cont < y)
                {
                    cont++;
                    cont1++;
                    if (cont1 != x)
                    {
                        Console.Write(cont + " ");
                    }
                    else
                    {

                        Console.Write(cont + "\n");
                        cont1 = 0;

                    }

                }
            }

            Console.ReadKey();
        }
    }
}
