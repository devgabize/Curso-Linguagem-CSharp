using System;
using System.Globalization;

namespace Exercicio5
{
    class Exerc5
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');

            int codPeca1 = int.Parse(peca1[0]);
            int qtdPeca1 = int.Parse(peca1[1]);
            float valorUnitPeca1 = float.Parse(peca1[2], CultureInfo.InvariantCulture);

            int codPeca2 = int.Parse(peca2[0]);
            int qtdPeca2 = int.Parse(peca2[1]);
            float valorUnitPeca2 = float.Parse(peca2[2], CultureInfo.InvariantCulture);

            float total = (qtdPeca1 * valorUnitPeca1) + (qtdPeca2 * valorUnitPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture) + "\n");
        }
    }
}
