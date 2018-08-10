using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int casos, contador = 0, x = 0, y = 0;
            int s = 0;
            casos = int.Parse(Console.ReadLine());
            while (contador < casos)
            {
                contador++;
                string[] linha = Console.ReadLine().Split(' ');
                x = int.Parse(linha[0]);
                y = int.Parse(linha[1]);
                while (y < x || y > x)
                {
                    if (y > x)
                    {
                        x++;
                        if (x % 2 == 1)
                        {
                            if (x != y)
                            {
                                s += x;
                            }
                        }
                    }
                    else if (x > y)
                    {
                        y++;
                        if (y % 2 == 1)
                        {
                            if (y != x)
                            {
                                s += y;
                            }
                        }
                    }
                }

                Console.WriteLine(s);
                s = 0;
            }

            Console.ReadKey();
        }
    }
}
