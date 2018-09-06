using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            int casos, n = 0, contador = 0, s = 0, contador1 = 0;
            casos = int.Parse(Console.ReadLine());
            if (casos >= 1 && casos <= 20)
            {
                while (contador < casos)
                {
                    contador++;
                    n = int.Parse(Console.ReadLine());
                    while (contador1 < n - 1)
                    {
                        contador1++;
                        if (n % contador1 == 0)
                        {
                            s += contador1;
                        }
                    }

                    if (s == n)
                    {
                        Console.WriteLine("{0} eh perfeito", n);
                    }
                    else if (s != n)
                    {
                        Console.WriteLine("{0} nao eh perfeito", n);
                    }

                    s = 0;
                    contador1 = 0;

                }
            }
            Console.ReadKey();
        }
    }
}
