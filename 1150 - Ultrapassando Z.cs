using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            while (x >= z)
            {
                z = int.Parse(Console.ReadLine());
            }
            int soma = x, a = x, contador = 1;
            while (soma < z)
            {
                a++;
                soma += a;
                contador++;
            }

            Console.WriteLine(contador);
            Console.ReadKey();
        }
    }
}
