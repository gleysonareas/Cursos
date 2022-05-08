using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classificação_de_idade_por_categoria
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Como você se chama?");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());

            if (idade < 5)
            {
                Console.WriteLine("Idade Invalida");
            }
            else if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("Infantil B");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Juvenil B");
            }
            else
            {
                Console.WriteLine("Adultos");
            }
            Console.ReadLine();
        }
    }
}
