using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3p4For
{
    class Program
    {      

        static void Main(string[] args)
        {
            Console.WriteLine("Leia um valor inteiro X(1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.\n");
            Console.Write("Digite um Limite a ser contado, o Limite deve ser maior do que zero e menor ou igual a 1000.");
            Console.Write("Limite: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Os numeros ímpares de 0 a " + x + "são:");

            for (int cont = 0; cont <= x; cont++)
            {
                if(cont % 2 != 0)
                {
                    Console.WriteLine(cont);
                }
            }
            Console.ReadKey();
                
        }
    }
}
