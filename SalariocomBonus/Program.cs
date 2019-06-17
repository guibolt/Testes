using System;
using System.Globalization;

namespace SalariocomBonus
{
    class Program
    {
        static void Main(string[] args)
        {
         

            string nome = Console.ReadLine();
            double salario = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            double vendas = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            double salariototal;




            salariototal = vendas * 15.0 / 100 + salario;

            
            
            Console.WriteLine("TOTAL = R$ " + salariototal.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
