using System;
using System.Globalization;

namespace Exercicio2
{
    class Exerc2
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double A = 3.14159 * Math.Pow(R, 2);

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture) + "\n");
            
        }
    }
}
