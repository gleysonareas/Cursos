using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_luta
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUser;
            int vidaJogador = 20;
            int vidaMonstro = 20;
            int special = 1;
            int ataque = 20;
            int opcaoAtk;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Entre com seu nome:");
            nomeUser = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao JOGO: " + nomeUser);
            Console.WriteLine();
            Console.WriteLine(@"Você tem 20 de HP, e vai enfrentar ABSALÃO O SOLDADO DA MORTE.
Batalhe com seu oponente até que a vida dele chegue zero
para salvar este mundo, (Seu oponente possui 20 de HP também) caso contrário este mundo perecerá.

Sua responsabilidade é grande, e para se realizar grande feito você terá ao seu dispor a BAZUCA SAGRADA
que lhe dá a chance de um ataque direto e único ao oponente sem chances de defesa, o que arranca do seu 
oponente 5 de HP. 

E um par de pistolas do ínicio ao fim do jogo com 20 balas de PRATA no Cartucho para SOBREVIVER.");
            Console.WriteLine();
            Console.WriteLine("Vamos começar?");
            Console.WriteLine();

            while (vidaJogador > 0 && vidaMonstro > 0)
            {
                Console.WriteLine(@"Escolha sua arma: 
Digite 1 para selecionar a Bazuca 
ou 
Digite 2 para selecionar as Pistolas");
                opcaoAtk = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcaoAtk == 1)
                {
                    opcaoAtk = special;
                    if (special == 1)
                    {
                        vidaMonstro = vidaMonstro - 5;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Você causou danos graves a ABSALÃO: " + "-" + vidaMonstro + "HP");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(nomeUser + " você possui: " + vidaJogador + "HP");
                        special = special - 1;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("E possui: " + special + "MP");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Você não possui energia o suficiente para utlizar essa arma: "+special+"MP");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                    }
                }
                else
                {
                    opcaoAtk = ataque;
                    if (euvenci() == true)
                    {
                        ataque = ataque - 1;
                        vidaMonstro = vidaMonstro - 2;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Continue assim e você vai destruir ABSALÃO, ele ainda possui: " + "-" + vidaMonstro + "HP");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(nomeUser + " você possui: " + vidaJogador + "HP");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Possui " + ataque + " Muniçoes, se a munição acabar desse a porrada nele kkkk");
                        Console.WriteLine("E tem: " + special + "MP");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                    }
                    else
                    {
                        vidaJogador = vidaJogador - 2;
                        Console.WriteLine();
                        Console.WriteLine("Cometa erros assim e sua morte é certa: ");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Você ainda possui: " + "-" + vidaJogador + "HP");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("E tem: " + special + "MP");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("E ABSALÃO possui: " + vidaMonstro + "HP");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                    }
                }
            }
            if (vidaJogador == 0)
            {
                Console.WriteLine("Lamento você perdeu e seu mundo perecerá e a culpa é sua. HAHAHA!!!!");
            }
            else
            {
                Console.WriteLine(@"Tua é a coroa do mundo pois VOCÊ NOS SALVOS.
Parabens!!!!!!!!!!!!!!!");
            }
            Console.WriteLine("Aperte a tecla ENTER para saír");
            Console.ReadLine();
            
        }
        static bool euvenci()
        {

            int dado = new Random().Next(0, 12);

            if (dado < 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
