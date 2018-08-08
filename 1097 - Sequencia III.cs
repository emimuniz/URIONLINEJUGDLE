using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {

            float I, J, cont1;
            I = 1;
            J = 7;
            cont1 = 0;
            while (I <= 9)
            {

                while (cont1 < 3)
                {

                    Console.WriteLine("I=" + I + " J=" + J);
                    J--;
                    cont1++;
                }
                cont1 = 0;
                I += 2;
                J += 5;
            }


            Console.Read();
        }
    }
}
