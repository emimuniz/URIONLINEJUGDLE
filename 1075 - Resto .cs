using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont;
            Console.Write("");
            n = int.Parse(Console.ReadLine());
            cont = 1;
            while (cont < 10000)
            {
                cont++;
                if (cont % n == 2)
                {
                    Console.WriteLine(cont);
                    cont++;
                }

            }
        }
    }
}
