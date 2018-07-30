using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont, numescolhidos;
            Console.Write("");
            n = int.Parse(Console.ReadLine());
            cont = 1;
            while (cont <= n)
            {
                cont++;
                Console.Write("");
                numescolhidos = int.Parse(Console.ReadLine());
                if (numescolhidos < 0 && numescolhidos % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (numescolhidos < 0 && numescolhidos % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (numescolhidos == 0)
                {
                    Console.WriteLine("NULL");
                }

                else if (numescolhidos > 0 && numescolhidos % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (numescolhidos > 0 && numescolhidos % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
            }


            Console.Read();
        }
    }
}
