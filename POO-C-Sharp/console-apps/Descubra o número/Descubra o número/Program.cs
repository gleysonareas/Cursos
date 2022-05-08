using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descubra_o_número
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = new Random().Next(0, 10);//2;
            int num = 0;
            int i = 5;

            while (num != secret && i > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Digite um número DE 1 A 10");
                Console.WriteLine();
                num = int.Parse(Console.ReadLine());
                if (num == secret)
                {
                    Console.WriteLine();
                    Console.WriteLine("Você Acertou o número secreto: " + secret);
                }
                else
                {
                    i = i - 1;
                    Console.WriteLine();
                    Console.WriteLine("Esse não é o número secreto tente novamente VOCÊ AINDA TEM: " + i + " CHANCES");
                    Console.WriteLine();
                    if (num > secret)
                    {
                        Console.WriteLine("O número secreto é menor que: " + num);
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é maior que: " + num);
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("FIM DO PROGRAMA - DIGITE QUALQUER TECLA PARA FINALIZAR");
            Console.ReadLine();
        }
    }
}
