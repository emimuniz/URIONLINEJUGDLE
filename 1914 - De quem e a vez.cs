using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp115
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, resultado = 0;
            Console.WriteLine("Digite o numero de casos: ");
            int casos = int.Parse(Console.ReadLine());
            while (contador < casos)
            {
                contador++;
                Console.WriteLine("Digite o nome do Partipantes, e a escolha do participante");
                String[] participantes = Console.ReadLine().Split(' ');
                string nome = participantes[0];
                string escolha = participantes[1];
                string nome2 = participantes[2];
                string escolha2 = participantes[3];


                String[] escolhaNumero = Console.ReadLine().Split(' ');
                int numero1 = int.Parse(escolhaNumero[0]);
                int numero2 = int.Parse(escolhaNumero[1]);

                resultado = numero1 + numero2;

                if (resultado % 2 != 0)
                {
                    if (escolha == "IMPAR") Console.WriteLine(nome);
                    else Console.WriteLine(nome2);
                }
                else
                {
                    if (escolha == "PAR") Console.WriteLine(nome);
                    else Console.WriteLine(nome2);
                }

            }

        }
    }
}
