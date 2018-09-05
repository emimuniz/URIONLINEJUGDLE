using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1;

            n = int.Parse(Console.ReadLine());

            Console.Write(a + " ");
            Console.Write(b);

            for (int i = 1; i <= (n - 2); i++)
            {

                int c;

                c = a + b;

                Console.Write(" " + c);

                a = b;
                b = c;
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
