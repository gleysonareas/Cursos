using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equação_de_primeiro_grau
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valX = 0;
            decimal valA = 0;
            decimal valB = 0;

            Console.WriteLine("Digite o valor de A");
            valA = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            valB = decimal.Parse(Console.ReadLine());

            valX = (valB*(-1) / valA);
            Console.WriteLine("O valor de X é: " + valX);
            Console.ReadLine();
        }
    }
}
