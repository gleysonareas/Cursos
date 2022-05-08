using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressão_de_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int menor= 0;
            int medio= 0;
            int maior = 0;

            Console.WriteLine("Digite um número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite mais um número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            num3 = int.Parse(Console.ReadLine());

            //Num1
            if (num1 >= num2 && num1 >= num3)
            {
                maior = num1;
            }
            else if ((num1 >= num2 && num1 <= num3) || (num1 >= num3 && num1 <= num2))
            {
                medio = num1;
            }
            else if (num1 <= num2 && num1 <= num3)
            {
                menor = num1;
            }

            //Num2
            if (num2 >= num1 && num2 >= num3)
            {
                maior = num2;
            }
            else if ((num2 >= num1 && num2 <= num3) || (num2 >= num3 && num2 <= num1))
            {
                medio = num2;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                menor = num2;
            }

            //Num3
            if (num3 >= num2 && num3 >= num1)
            {
                maior = num3;
            }
            else if ((num3 >= num2 && num3 <= num1) || (num3 >= num1 && num3 <= num2))
            {
                medio = num3;
            }
            else if (num3 <= num2 && num3 <= num1)
            {
                menor = num3;
            }
            Console.WriteLine("A ordem correta dos números digitados é a seguinte:");
            Console.WriteLine(menor + "," + medio + "," + maior);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
