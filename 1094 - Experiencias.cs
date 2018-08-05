using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, quantia, cont, coelho, rato, sapo;
            char tipo;
            sapo = 0;
            coelho = 0;
            rato = 0;
            cont = 0;
            valor = int.Parse(Console.ReadLine());
            while (cont < valor)
            {
                cont++;
                string[] linha = Console.ReadLine().Split(' ');
                quantia = int.Parse(linha[0]);
                tipo = char.Parse(linha[1]);
                if (quantia >= 1 && quantia <= 15)
                {
                    if (tipo == 'S')
                    {
                        sapo += quantia;
                    }

                    if (tipo == 'R')
                    {
                        rato += quantia;
                    }

                    if (tipo == 'C')
                    {
                        coelho += quantia;
                    }

                }
            }
            float total = coelho + rato + sapo;
            float perc1 = coelho * 100 / total;
            float perc2 = rato * 100 / total;
            float perc3 = sapo * 100 / total;
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: {0:F2} %", perc1);
            Console.WriteLine("Percentual de ratos: {0:F2} %", perc2);
            Console.WriteLine("Percentual de sapos: {0:F2} %", perc3);
            Console.ReadLine();
        }
    }
}
