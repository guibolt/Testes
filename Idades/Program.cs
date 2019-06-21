
using System;
using System.Globalization;
namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariom;
            Pessoas p, p1;

            p = new Pessoas();
            p1 = new Pessoas();

            Console.WriteLine("digite seu nome");
            p.nome = Console.ReadLine();
            Console.WriteLine("Digite sua salario");
            p.salario = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu nome");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite sua salario");
            p1.salario= Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

            salariom = p.CalcularSalario(p.salario, p1.salario);

            Console.WriteLine($"Salario Médio = R${salariom.ToString("F2",CultureInfo.InvariantCulture)}");



        }
    }
}
