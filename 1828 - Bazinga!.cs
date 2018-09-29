using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp103
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Digite o numero de casos: ");
            int casos = int.Parse(Console.ReadLine());
            while (contador < casos)
            {

                contador++;
                Console.WriteLine("Digite as escolhas: ");
                string[] escolhas = Console.ReadLine().Split(' ');
                string primeiraEscolha = escolhas[0];
                string segundaEscolha = escolhas[1];

                if (primeiraEscolha == "tesoura")
                {
                    if (segundaEscolha == "papel")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!",contador);
                    }
                    else if (segundaEscolha == "lagarto")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!",contador);
                    }
                    else if (segundaEscolha == "tesoura")
                    {
                        Console.WriteLine("Caso #{0}: De novo!",contador);
                    }
                    else
                    {
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", contador);
                    }
                }

                else if (primeiraEscolha == "papel")
                {
                    if (segundaEscolha == "pedra")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!", contador);
                    }
                    else if (segundaEscolha == "Spock")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!", contador);
                    }
                    else if (segundaEscolha == "papel")
                    {
                        Console.WriteLine("Caso #{0}: De novo!", contador);
                    }
                    else
                    {
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", contador);
                    }
                }

                else if (primeiraEscolha == "pedra")
                {
                    if (segundaEscolha == "lagarto")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!", contador);
                    }
                    else if (segundaEscolha == "tesoura")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!", contador);
                    }
                    else if (segundaEscolha == "pedra")
                    {
                        Console.WriteLine("Caso #{0}: De novo!", contador);
                    }
                    else
                    {
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", contador);
                    }
                }

                else if (primeiraEscolha == "lagarto")
                {
                    if (segundaEscolha == "Spock")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!", contador);
                    }
                    else if (segundaEscolha == "papel")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!", contador);
                    }
                    else if (segundaEscolha == "lagarto")
                    {
                        Console.WriteLine("Caso #{0}: De novo!", contador);
                    }
                    else
                    {
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", contador);
                    }
                }

                else if (primeiraEscolha == "Spock")
                {
                    if (segundaEscolha == "tesoura")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!", contador);
                    }
                    else if (segundaEscolha == "pedra")
                    {
                        Console.WriteLine("Caso #{0}: Bazinga!", contador);
                    }
                    else if (segundaEscolha == "Spock")
                    {
                        Console.WriteLine("Caso #{0}: De novo!", contador);
                    }
                    else
                    {
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", contador);
                    }
                }

            }

            Console.Read();
        }
    }
}
