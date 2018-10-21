using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiraCompra = 1001, segundaCompra = 1002, terceiraCompra = 1003;
            int quartaCompra = 1004, quintaCompra = 1005, contador = 0;
            double soma = 0;

            Console.WriteLine("Digite o numero de casos: ");
            int casos = int.Parse(Console.ReadLine());
            while (contador < casos)
            {
                contador++;
                String[] compra = Console.ReadLine().Split(' ');
                int codigo = int.Parse(compra[0]);
                int quant = int.Parse(compra[1]);
                if (codigo == primeiraCompra) soma += (1.50 * quant);
                else if (codigo == segundaCompra) soma += (2.50 * quant);
                else if (codigo == terceiraCompra)soma += (3.50 * quant);
                else if (codigo == quartaCompra)soma += (4.50 * quant);
                else if (codigo == quintaCompra)soma += (5.50 * quant);
                
            }

            Console.WriteLine("{0:f2}",soma);
            Console.ReadKey();
        }
    }
}
