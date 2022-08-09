using ExerciciosCSharp.View;
using System;

namespace ExerciciosCSharp.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            char sair;

            sair = 'n';
            do
            {
                Console.WriteLine("\n1 - Lista de Exercicios Udemy");
                Console.WriteLine("2 - Lista de Exercícios Beecrowd");
                Console.WriteLine("0 - Cancelar");

                Console.Write("\nSelecione uma das listas acima: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Listas.ExecutarExerciciosUdemy();
                        break;
                    case 2:
                        Listas.ExecutarExerciciosBeecrowd();
                        break;
                    case 0:
                        Console.WriteLine("Cancelando...");
                        break;
                    default:
                        Console.WriteLine("Insira uma opção válida");
                        break;
                }

                Console.Write("Encerrar programa? s/n: ");
                sair = char.Parse(Console.ReadLine());

            } while (sair == 'n');

            Console.WriteLine("\nFim do programa");
        }
    }
}