using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp108
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, soma = 0;
            while (contador <= 3)
            {


                String[] grito = Console.ReadLine().Split(' ');
                string primeiroGrito = grito[0];
                if (primeiroGrito == "caw")
                {
                    contador++;
                    string outroGrito = grito[1];
                    Console.WriteLine(soma);
                    soma = 0;

                }

                else if (primeiroGrito == "--*") soma += 1;
                else if (primeiroGrito == "*--") soma += 4;
                else if (primeiroGrito == "-*-") soma += 2;
                else if (primeiroGrito == "---") soma += 0;
                else if (primeiroGrito == "-**") soma += 3;
                else if (primeiroGrito == "*-*") soma += 5;
                else if (primeiroGrito == "**-") soma += 6;
                else if (primeiroGrito == "***") soma += 7;

               
            }

            Console.Read();

        }

    }
}
