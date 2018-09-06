using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Program
    {
        static void Main(string[] args)
        {
            int casos, n = 0, contador = 0, contador1 = 0, s = 0;
            casos = int.Parse(Console.ReadLine());
            if (casos >= 1 && casos <= 100)
            {
                while (contador < casos)
                {
                    s = 0;
                    contador1 = 0;
                    contador++;
                    n = int.Parse(Console.ReadLine());
                    while (contador1 < n)
                    {
                        contador1++;
                        if (n % contador1 == 0)
                        {
                            s += contador1;
                        }
                    }
                    if (s == n + 1)
                    {
                        Console.WriteLine("{0} eh primo", n);
                    }
                    else if (s != n + 1)
                    {
                        Console.WriteLine("{0} nao eh primo", n);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
