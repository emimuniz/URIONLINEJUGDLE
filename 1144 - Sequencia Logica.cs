﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;
            n = int.Parse(Console.ReadLine());
            if (n > 1 && n < 1000)
            {
                while (cont < n)
                {
                    cont++;
                    Console.WriteLine("{0} {1} {2}", cont, cont * cont, (cont * cont) * cont);
                    Console.WriteLine("{0} {1} {2}", cont, cont * cont + 1, (cont * cont) * cont + 1);
                }
            }

            Console.Read();
        }
    }
}
