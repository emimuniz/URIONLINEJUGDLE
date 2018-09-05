using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, contador = 0, contador1 = 0, s = 0;
            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());
                contador1 = n;
                if (n > 0 || n < 0)
                {
                    while (contador < 5)
                    {
                        if (contador1 % 2 == 0)
                        {
                            s += contador1;
                            contador++;
                        }

                        contador1++;
                    }

                    Console.WriteLine(s);
                    contador = 0;
                    s = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
