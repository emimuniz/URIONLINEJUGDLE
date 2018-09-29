using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp105
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string textoAno = Console.ReadLine();

                if (textoAno == null)
                {
                    break;
                }

                int ano = int.Parse(textoAno);
                if (ano == 0)
                {
                    Console.WriteLine("vai ter copa!");
                }
                else
                {
                    Console.WriteLine("vai ter duas!");
                }
            }
        }
    }
}
