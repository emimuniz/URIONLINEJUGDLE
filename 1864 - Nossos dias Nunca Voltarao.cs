using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp113
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase = "LIFE IS NOT A PROBLEM TO BE SOLVED";

            Console.WriteLine("Digite um valor: ");
            int numero = int.Parse(Console.ReadLine());
            while (numero < 1 || numero > 34)
            {
                Console.WriteLine("Digite novamente: ");
                numero = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numero; i++)
            {
                Char separando = frase[i];
                Console.Write(separando);

            }

            Console.WriteLine();

        }
    }
}
