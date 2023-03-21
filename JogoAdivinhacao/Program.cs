using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int NumeroAleatorio = new Random().Next(1, 20);
            int pontuacao = 1000;

            Console.WriteLine("- Bem-vindo(a) ao Jogo da Adivinhação -\n");

            Console.WriteLine("Adivinhe um número de 1 a 20.\n");
            Console.WriteLine("Níveis de dificuldade: \n(1) Fácil \n(2) Médio \n(3) Difícil");
            Console.WriteLine("Escolha um nível de dificuldade: ");
            int opcaoNivel = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (opcaoNivel == 1)
            {
                while (contador != 16)
                {
                    Console.WriteLine($"Tentativa de {contador} a 15!");
                    Console.WriteLine("------------------------------");
                    Console.Write("Qual seu chute? ");
                    int numeroChute = Convert.ToInt32(Console.ReadLine());

                    if (numeroChute <= 0)
                    {
                        Console.WriteLine("Número negativo ou zero não são válidos! Tente novamente.");
                        contador--;
                        pontuacao++;
                    }
                    if (numeroChute == NumeroAleatorio)
                    {
                        Console.WriteLine($"Parabéns, você acertou! Sua pontuação final foi: {pontuacao}\n");
                        Console.ReadKey();
                        Environment.Exit(NumeroAleatorio);
                    }
                    else if(numeroChute < NumeroAleatorio)
                    {
                        pontuacao--;
                        Console.WriteLine("Seu número foi menor!");
                        Console.WriteLine($"Você errou! Você Fez {pontuacao} pontos\n\n");
                    }
                    else if(numeroChute > NumeroAleatorio)
                    {
                        pontuacao--;
                        Console.WriteLine("Seu número foi maior!");
                        Console.WriteLine($"Você errou! Você Fez {pontuacao} pontos\n\n");
                    }

                    contador++;

                    if (contador == 16)
                    {
                        Console.WriteLine("As suas chances acabaram! Fim de Jogo.");
                    }
                }
            }

            if (opcaoNivel == 2)
            {
                while (contador != 11)
                {
                    Console.WriteLine($"Tentativa de {contador} a 10!");
                    Console.WriteLine("------------------------------");
                    Console.Write("Qual seu chute? ");
                    int numeroChute = Convert.ToInt32(Console.ReadLine());

                    if (numeroChute <= 0)
                    {
                        Console.WriteLine("Número negativo ou zero não são válidos! Tente novamente.");
                        contador--;
                        pontuacao++;
                    }
                    if (numeroChute == NumeroAleatorio)
                    {
                        Console.WriteLine($"Parabéns, você acertou! Sua pontuação final foi: {pontuacao}\n");
                        Console.ReadKey();
                        Environment.Exit(NumeroAleatorio);
                    }
                    else if (numeroChute < NumeroAleatorio)
                    {
                        pontuacao--;
                        Console.WriteLine("Seu número foi menor!");
                        Console.WriteLine($"Você errou! Você Fez {pontuacao} pontos\n\n");
                    }
                    else if (numeroChute > NumeroAleatorio)
                    {
                        pontuacao--;
                        Console.WriteLine("Seu número foi maior!");
                        Console.WriteLine($"Você errou! Você Fez {pontuacao} pontos\n\n");
                    }

                    contador++;

                    if (contador == 11)
                    {
                        Console.WriteLine("As suas chances acabaram! Fim de Jogo.");
                    }
                }
            }

            if (opcaoNivel == 3)
            {
                while (contador != 6)
                {
                    Console.WriteLine($"Tentativa de {contador} a 5!");
                    Console.WriteLine("------------------------------");
                    Console.Write("Qual seu chute? ");
                    int numeroChute = Convert.ToInt32(Console.ReadLine());

                    if (numeroChute <= 0)
                    {
                        Console.WriteLine("Número negativo ou zero não são válidos! Tente novamente.");
                        contador--;
                        pontuacao++;
                    }
                    if (numeroChute == NumeroAleatorio)
                    {
                        Console.WriteLine($"Parabéns, você acertou! Sua pontuação final foi: {pontuacao}\n");
                        Console.ReadKey();
                        Environment.Exit(NumeroAleatorio);
                    }
                    else if (numeroChute < NumeroAleatorio)
                    {
                        pontuacao--;
                        Console.WriteLine("Seu número foi menor!");
                        Console.WriteLine($"Você errou! Você Fez {pontuacao} pontos\n\n");
                    }
                    else if (numeroChute > NumeroAleatorio)
                    {
                        pontuacao--;
                        Console.WriteLine("Seu número foi maior!");
                        Console.WriteLine($"Você errou! Você Fez {pontuacao} pontos\n\n");
                    }

                    contador++;

                    if (contador == 6)
                    {
                        Console.WriteLine("As suas chances acabaram! Fim de Jogo.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
