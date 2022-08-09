using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.View
{
    internal class Listas
    {
        public static void ExecutarExerciciosUdemy()
        {
            int opcao;
            char sair;

            sair = 'n';
            do
            {
                Console.WriteLine("\n###### EXERCÍCIOS UDEMY ######\n");
                Console.WriteLine("1 - Calcular valor do metro quadrado");
                Console.WriteLine("2 - Calcular area de retangulo");
                Console.WriteLine("3 - Calcular idade média");
                Console.WriteLine("0 - Cancelar");

                Console.Write("\nSelecione um dos exercicios acima: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        View.ExerciciosUdemy.calcularMetroQuadrado();
                        break;
                    case 2:
                        View.ExerciciosUdemy.calcularAreaRetangulo();
                        break;
                    case 3:
                        View.ExerciciosUdemy.calcularIdadeMedia();
                        break;
                    case 0:
                        Console.WriteLine("Cancelando...");
                        break;
                    default:
                        Console.WriteLine("Insira uma opção válida");
                        break;
                }

                Console.Write("Sair? s/n: ");
                sair = char.Parse(Console.ReadLine());

            } while (sair == 'n');
        }

        public static void ExecutarExerciciosBeecrowd()
        {
            int opcao;
            char sair;

            sair = 'n';
            do
            {
                Console.WriteLine("\n###### EXERCÍCIOS BEECROWD ######\n");
                Console.WriteLine("1 - Exercicio 1001");
                Console.WriteLine("2 - Exercicio 1009");
                Console.WriteLine("3 - Exercicio 1011");
                Console.WriteLine("4 - Exercicio 1012");
                Console.WriteLine("5 - Exercicio 1013");
                Console.WriteLine("0 - Cancelar");

                Console.Write("\nSelecione um dos exercicios acima: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        View.ExerciciosBeecrowd.Exercicio1001();
                        break;
                    case 2:
                        View.ExerciciosBeecrowd.Exercicio1009();
                        break;
                    case 3:
                        View.ExerciciosBeecrowd.Exercicio1011();
                        break;
                    case 4:
                        View.ExerciciosBeecrowd.Exercicio1012();
                        break;
                    case 5:
                        View.ExerciciosBeecrowd.Exercicio1013();
                        break;
                    case 0:
                        Console.WriteLine("Cancelando...");
                        break;
                    default:
                        Console.WriteLine("Insira uma opção válida");
                        break;
                }

                Console.Write("Sair? s/n: ");
                sair = char.Parse(Console.ReadLine());

            } while (sair == 'n');
        }
    }
}