using System;
using System.Globalization;

namespace Exercicio6
{
    class Exerc6
    {
        static void Main(string[] args)
        {
            string[] vals = Console.ReadLine().Split(' ');
            double A = double.Parse(vals[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vals[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vals[2], CultureInfo.InvariantCulture);

            double areaTriangRetang = (A * C) / 2.0;
            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2.0;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + areaTriangRetang.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
