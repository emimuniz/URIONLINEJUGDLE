using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 2;
            y = 1;
            while (x != 0 && y != 0)
            {
                string[] linha = Console.ReadLine().Split(' ');
                x = int.Parse(linha[0]);
                y = int.Parse(linha[1]);
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }

            }

            Console.ReadKey();
        }
    }
}
