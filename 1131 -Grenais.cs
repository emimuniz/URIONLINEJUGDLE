using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {

        static void Main(string[] args)
        {
            int inter, gremio, part;
            inter = 0;
            part = 1;
            int cont = 0;
            int intersoma = 0;
            int gremiosoma = 0;
            int empate = 0;
            while (part == 1)
            {
                string[] linha = Console.ReadLine().Split(' ');
                inter = int.Parse(linha[0]);
                gremio = int.Parse(linha[1]);
                if (inter > gremio)
                {
                    intersoma++;
                }
                else if (inter < gremio)
                {
                    gremiosoma++;
                }
                else if (inter == gremio)
                {
                    empate++;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                part = int.Parse(Console.ReadLine());
                cont++;

            }
            while (part == 2)
            {
                Console.WriteLine(cont + " grenais");
                Console.WriteLine("Inter:" + intersoma);
                Console.WriteLine("Gremio:" + gremiosoma);
                Console.WriteLine("Empates:" + empate);
                if (intersoma > gremiosoma)
                {
                    Console.WriteLine("Inter venceu mais");
                }
                else if (gremiosoma > intersoma)
                {
                    Console.WriteLine("Gremio venceu mais");
                }
                else
                {
                    Console.WriteLine("Nao houve vencedor");
                }
                break;

            }


            Console.ReadKey();


        }
    }
}
