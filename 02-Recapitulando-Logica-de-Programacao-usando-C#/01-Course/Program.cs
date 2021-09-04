using System;
using System.Globalization;

namespace _01_Course{
    class Program{
        static void Main(string[] args){

            /*int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);
            System.Console.WriteLine(n3);
            System.Console.WriteLine(n4);*/

            /*char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            System.Console.Write("Bom dia!");
            System.Console.WriteLine("Boa tarde!");
            System.Console.WriteLine("Boa noite!");
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine(genero);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(saldo);
            System.Console.WriteLine(nome);
            System.Console.WriteLine(saldo.ToString("F2"));
            System.Console.WriteLine(saldo.ToString("F4"));
            System.Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));*/

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            System.Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            System.Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            System.Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");
        }
    }
}
