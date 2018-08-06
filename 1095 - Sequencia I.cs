using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, cont;
            i = 1;
            j = 60;
            cont = 1;
            while (cont <= 13)
            {
                cont++;
                Console.WriteLine("I=" + i + " J=" + j);
                i = i + 3;
                j = j - 5;

            }

            Console.ReadKey();
        }
    }
}
