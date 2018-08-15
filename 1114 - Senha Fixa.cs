using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;
            while (true)
            {
                Console.Write("");
                senha = int.Parse(Console.ReadLine());
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }

            Console.ReadKey();
        }
    }
}
