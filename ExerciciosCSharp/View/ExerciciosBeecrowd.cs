using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosCSharp.View
{
    internal class ExerciciosBeecrowd
    {
        public static void Exercicio1001()
        {
            int A, B, X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("X = " + X);
        }

        public static void Exercicio1009()
        {
            string nome;
            double salarioFixo, vendasMes, totalRendimentos;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendasMes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalRendimentos = vendasMes * 15 / 100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + totalRendimentos.ToString ("F2", CultureInfo.InvariantCulture));
        }

        public static void Exercicio1011()
        {
            int raio = int.Parse(Console.ReadLine());

            double volume = (4 / 3.0) * 3.14159 * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString ("F3", CultureInfo.InvariantCulture));
        }

        public static void Exercicio1012()
        {
            double A, B, C, triangulo, raioCirculo, trapezio, quadrado, retangulo;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            triangulo = (A * C) / 2.0;
            raioCirculo = 3.14159 * C * C;
            trapezio = ((A + B) * C) / 2.0;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + raioCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }

        public static void Exercicio1013()
        {
            int a, b, s, maiorAb;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());

            maiorAb = (a + b + (a * b * s) * (a - b)) / 2;

            Console.WriteLine(maiorAb + " eh o maior");
        }
    }
}