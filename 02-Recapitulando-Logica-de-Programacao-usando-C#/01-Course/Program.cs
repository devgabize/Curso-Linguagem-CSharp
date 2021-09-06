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

            /*int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            System.Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            System.Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            System.Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");*/

            /*string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            //string s = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            System.Console.WriteLine("\nVocê digitou: ");
            System.Console.WriteLine(frase);
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);*/

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            System.Console.WriteLine("\nVocê digitou: ");
            System.Console.WriteLine(n1);
            System.Console.WriteLine(ch);
            System.Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(nome);
            System.Console.WriteLine(sexo);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
