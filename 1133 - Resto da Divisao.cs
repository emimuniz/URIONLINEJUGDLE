using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x < y)
            {
                for (int c = x + 1; c < y; c++)
                {
                    if (c % 5 == 2 || c % 5 == 3)
                    {
                        Console.WriteLine(c);
                    }

                }
            }


            else if (x > y)
            {
                for (int c = y + 1; c < x; c++)
                {
                    if (c % 5 == 2 || c % 5 == 3)
                    {
                        Console.WriteLine(c);

                    }
                }

            }

            Console.ReadKey();
        }
    }
}
