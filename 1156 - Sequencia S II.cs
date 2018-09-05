using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 1, b = 1, s = 1;
            while (b < 39)
            {
                b += 2;
                a *= 2;
                s += b / a;

            }

            Console.WriteLine("{0:f2}", s);
            Console.ReadKey();

        }
    }
}
