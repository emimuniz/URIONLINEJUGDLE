using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            int posto = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (posto != 4)
            {
                posto = int.Parse(Console.ReadLine());
                if (posto > 5 || posto < 0)
                {
                    posto = int.Parse(Console.ReadLine());
                }
                if (posto == 1)
                {
                    alcool++;
                }
                else if (posto == 2)
                {
                    gasolina++;
                }
                else if (posto == 3)
                {
                    diesel++;
                }
            }


            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: {0}", alcool);
            Console.WriteLine("Gasolina: {0}", gasolina);
            Console.WriteLine("Diesel: {0}", diesel);
            Console.ReadKey()
        }
    }
}
