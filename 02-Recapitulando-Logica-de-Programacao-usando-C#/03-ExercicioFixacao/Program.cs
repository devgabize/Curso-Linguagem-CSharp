using System;
using System.Globalization;

namespace _03_ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartoos tem na sua casa? ");
            int numQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] infos = Console.ReadLine().Split(' ');
            string sobrenome = infos[0];
            int idade = int.Parse(infos[1]);
            float altura = float.Parse(infos[2], CultureInfo.InvariantCulture);

            System.Console.WriteLine("\n" + nomeCompleto);
            System.Console.WriteLine(numQuartos);
            System.Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(sobrenome);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
