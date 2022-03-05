using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nPergunta-me algo:\n");
                string question = Console.ReadLine();

                if (question == "EXIT")
                {
                    break;
                }
                
                else if (question != "EXIT")
                {
                    if (question == "Como te chamas")
                    {
                        Console.WriteLine("\nO meu nome é ChatBot.");
                    }

                    else if (question == "O que fazes")
                    {
                        Console.WriteLine("\nRespondo a perguntas.");
                    }

                    else if (question == "Que horas são")
                    {
                        Console.WriteLine("\nVê no canto inferior direito do ecrã");
                    }

                    else if (question == "Qual o melhor jogador de futebol")
                    {
                        Console.WriteLine("\nCristiano Ronaldo");
                    }
                    
                    else
                    {
                        Console.WriteLine("\nNão sei do que falas");
                    }
                }
                
            }
            
            

        }
    }
}
