using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classificação_e_multiplicação_de_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num00;
            int num01;
            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Número Par");
            }
            else
            {
                Console.WriteLine("Numero Impar");
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite um número");
            num00 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite mais um número");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da MULTIPLICAÇÃO é: " + (num00 * num01));
            Console.WriteLine("O resultado da DIVISÃO é: " + (num00 / num01));
            Console.WriteLine("O resultado da SOMA é: " + (num00 + num01));
            Console.WriteLine("O resultado da SUBTRAÇÃO é: " + (num00 - num01));
            Console.ReadLine();
            Console.Clear();
        }
    }
}
