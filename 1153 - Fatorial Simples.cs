using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int contador = n - 1;
            int resultado = 0;
            if (n > 0 && n < 13)
            {
                while (contador > 0)
                {

                    resultado = n * contador;
                    contador--;
                    if (contador != 0)
                    {
                        n = resultado;
                    }

                }

            }
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
