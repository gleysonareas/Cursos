using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleição
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numEleitor = 0;
            decimal votojoao = 0;
            decimal votopedro = 0;
            decimal votomaria = 0;
            int voto = 0; 

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Qual o número de eleitores? ");
            numEleitor = int.Parse(Console.ReadLine());
            Console.Clear();
            while (numEleitor > 0)
            {
                Console.WriteLine(@"Digite 
1 para votar em João: 
2 para votar em Pedro: 
3 para votar em Maria:");
                voto = int.Parse(Console.ReadLine());
                switch (voto)
                {
                    case 1:
                        votojoao = votojoao + 1;
                        Console.WriteLine("Você votou em: João");
                        Console.WriteLine("Aperte ENTER para finalizar o seu voto.");
                        Console.ReadLine();
                        break;
                    case 2:
                        votopedro = votopedro + 1;
                        Console.WriteLine("Você votou em: Pedro");
                        Console.WriteLine("Aperte ENTER para finalizar o seu voto.");
                        Console.ReadLine();
                        break;
                    case 3:
                        votomaria = votomaria + 1;
                        Console.WriteLine("Você votou em: Maria");
                        Console.WriteLine("Aperte ENTER para finalizar o seu voto.");
                        Console.ReadLine();
                        break;
                }
                numEleitor = numEleitor - 1;
                Console.Clear();
            }

            numEleitor = votojoao + votomaria + votopedro;

            Console.WriteLine("Este é o total de votos de cada CANDIDATO: ");
            Console.WriteLine("João: " + ((votojoao / numEleitor) * 100));
            Console.WriteLine("Pedro: " + ((votopedro / numEleitor) * 100));
            Console.WriteLine("Maria: " + ((votomaria / numEleitor) * 100));
            Console.WriteLine();

            if ((votojoao > votopedro) && (votojoao > votomaria))
            {
                Console.WriteLine("João foi eleito");
            }
            else if ((votopedro > votojoao) && (votopedro > votomaria))
            {
                Console.WriteLine("Pedro foi eleito");
            }
            else if ((votomaria > votojoao) && (votomaria > votopedro))
            {
                Console.WriteLine("Maria foi eleita");
            }
            else
            {
                Console.WriteLine("Todos empataram e ninguém venceu");
            }
                Console.ReadLine();
        }
    }
}
