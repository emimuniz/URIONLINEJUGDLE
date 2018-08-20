using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2;
            nota1 = float.Parse(Console.ReadLine());
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("nota invalida");
                nota1 = float.Parse(Console.ReadLine());
            }

            nota2 = float.Parse(Console.ReadLine());

            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                nota2 = float.Parse(Console.ReadLine());
            }

            float media = (nota1 + nota2) / 2;
            Console.WriteLine("media = {0:f2}", media);


            Console.ReadKey();

        }
    }
}
