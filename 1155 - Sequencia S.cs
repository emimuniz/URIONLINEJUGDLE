using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            float S = 1, resultado = 0, b = 1, a = 1;
            while (b < 100)
            {
                b++;
                resultado = a / b;
                S += resultado;
            }

            Console.WriteLine("{0:f2}", S);
            Console.ReadKey();
        }
    }
}
