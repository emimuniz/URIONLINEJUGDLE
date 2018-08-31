using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int cont = 0;
            while (x != 0)
            {
                cont = 0;
                x = int.Parse(Console.ReadLine());
                while (cont < x)
                {
                    cont++;
                    if (cont != x)
                    {
                        Console.Write(cont + " ");
                    }
                    else
                    {
                        Console.Write(cont);
                    }

                }
                if (cont != 0)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
