using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, numescolhido, maior, contando;
            cont = 1;
            maior = 0;
            contando = 0;
            while (cont <= 100)
            {
                cont++;
                Console.Write("");
                numescolhido = int.Parse(Console.ReadLine());
                if (numescolhido > maior)
                {
                    maior = numescolhido;
                    contando = cont - 1;
                }

            }

            Console.WriteLine(maior);
            Console.WriteLine(contando);
            Console.ReadKey();
        }
    }
}
