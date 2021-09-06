using System;
using System.Globalization;

namespace Exercicio4
{
    class Exerc4
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int hora = int.Parse(Console.ReadLine());
            float valHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salario = (float)hora * valHora;

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture) + "\n");
        }
    }
}
