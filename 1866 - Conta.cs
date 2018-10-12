using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp114
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, soma = 0;
            int contadorD = 0;
            Console.WriteLine("Digite o numero de casos: ");
            int casos = int.Parse(Console.ReadLine());

            while (contadorD < casos)
            {
                contadorD++;
                Console.WriteLine("Digite a quantidade de termos: ");
                int quantidade = int.Parse(Console.ReadLine());



                while (contador <= quantidade)
                {
                    contador++;
                    if (contador == 1) soma += 1;
                    if (contador % 2 != 0) soma -= 1;
                    else if (contador % 2 == 0) soma += 1;

                }

                Console.WriteLine(soma);
                soma = 0;
                contador = 0;
            }

            Console.Read();
        }
    }
}
