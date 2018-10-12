using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp109
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor = 0, posicao = 0;
            int casos = int.Parse(Console.ReadLine());
            String[] pessoas = Console.ReadLine().Split();
            int[] listaPessoas = new int[casos];
            for (int n = 0; n < casos; n++)
            {
                listaPessoas[n] = int.Parse(pessoas[n]);

                if (n == 0) menor = listaPessoas[0];
            
                if (menor > listaPessoas[n])
                {
                    menor = listaPessoas[n];
                    posicao = n;
                }
            }

           
            Console.WriteLine(posicao + 1);

            Console.Read();
        }
    }
}
