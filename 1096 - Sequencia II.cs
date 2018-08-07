using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, J, cont = 0;
            I = 1;
            J = 7;
            while (I <= 9)
            {

                while (cont < 3)
                {
                    cont++;
                    Console.WriteLine("I=" + I + " J=" + J);
                    J--;

                }
                cont = 0;
                J = 7;
                I += 2;

            }

            Console.Read();
        }
    }
}
