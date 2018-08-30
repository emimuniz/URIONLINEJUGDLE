using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cont = 0;
            int contador = 0;
            while (cont < n)
            {
                cont++;
                contador++;
                Console.WriteLine("{0} {1} {2} PUM", contador, contador + 1, contador + 2);
                contador += 3;
            }

            Console.ReadKey();
        }
    }
}
