using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            Console.WriteLine("Numero de Casos: ");
            int casos = int.Parse(Console.ReadLine());
            while (contador <= casos)
            {
                contador++;
                String[] pessoas = Console.ReadLine().Split(' ');
                string nome = pessoas[0];
                int forca = int.Parse(pessoas[1]);

                if (nome == "Thor") Console.WriteLine("Y");              
                else Console.WriteLine("N");

            }

            Console.Read();
        }
    }
}

