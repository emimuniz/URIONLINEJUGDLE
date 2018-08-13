using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1, n = 1, s = 0;
            while (m != 0 && n != 0)
            {
                string[] linha = Console.ReadLine().Split(' ');
                m = int.Parse(linha[0]);
                n = int.Parse(linha[1]);
                if (m > 0 && n > 0)
                {
                    if (m >= n)
                    {
                        while (n <= m)
                        {
                            Console.Write(n);
                            Console.Write(" ");
                            s += n;
                            n++;

                        }

                        Console.WriteLine("Sum={0}", s);
                        s = 0;
                    }
                    else if (n > m)
                    {
                        while (m <= n)
                        {
                            Console.Write(m);
                            Console.Write(" ");
                            s += m;
                            m++;

                        }

                        Console.WriteLine("Sum={0}", s);
                        s = 0;
                    }

                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
