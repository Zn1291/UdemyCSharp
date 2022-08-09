using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.View
{
    internal class ExerciciosUdemy
    {
        public static void calcularMetroQuadrado()
        {
            Console.Write("Insira a largura: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Insira o comprimento: ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do m²: ");
            double valorMetroQuadrado = double.Parse(Console.ReadLine());

            double area = largura * comprimento;
            double preco = area * valorMetroQuadrado;

            Console.WriteLine(area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }

        public static void calcularAreaRetangulo()
        {
            double baseArea, altura, area, perimetro, diagonal;

            Console.Write("Insira o valor da base: ");
            baseArea = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor da altura: ");
            altura = double.Parse(Console.ReadLine());

            area = baseArea * altura;
            perimetro = baseArea * 2 + altura * 2;
            diagonal = Math.Sqrt(Math.Pow(altura, 2.0) + Math.Pow(baseArea, 2.0));

            Console.WriteLine("AREA: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }

        public static void calcularIdadeMedia()
        {
            string nome1, nome2;
            int idade1, idade2;
            double mediaIdade;

            Console.Write("Insira o nome da primeira pessoa: ");
            nome1 = Console.ReadLine();

            Console.Write("Insira a idade dessa pessoa: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o nome da segunda pessoa: ");
            nome2 = Console.ReadLine();

            Console.Write("Insira a idade da segunda pessoa: ");
            idade2 = int.Parse(Console.ReadLine());

            mediaIdade = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " +
                mediaIdade.ToString("F1", CultureInfo.InvariantCulture) + " anos.");
        }
    }
}