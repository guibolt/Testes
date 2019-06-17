using System;
using System.Globalization;
namespace SimplesCalc
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int codpeca = 0, quantpeca = 0, codpeca2 = 0, quantpeca2 = 0;
            double valor = 0.0, valor2 = 0.0, valorpag = 0.0;

            string[] vet = Console.ReadLine().Split(' ');
            codpeca = int.Parse(vet[0]);
            quantpeca = int.Parse(vet[1]);
            valor = double.Parse(vet[2], (CultureInfo.InvariantCulture));

            string[] vet2 = Console.ReadLine().Split(' ');
            codpeca2 = int.Parse(vet2[0]);
            quantpeca2 = int.Parse(vet2[1]);
            valor2 = double.Parse(vet2[2], (CultureInfo.InvariantCulture));

            valorpag = quantpeca * valor + quantpeca2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorpag.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

