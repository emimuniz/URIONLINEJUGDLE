using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            int idades = 1;
            float acumulador = 0, quantidade = 0;
            while (idades > 0)
            {
                idades = int.Parse(Console.ReadLine());
                if (idades < 0)
                {
                    break;
                }
                acumulador += idades;
                quantidade++;
            }
            Console.WriteLine("{0:f2}", acumulador / quantidade);
            Console.ReadKey();
        }
    }
}
