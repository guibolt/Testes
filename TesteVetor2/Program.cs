using System;
using System.Globalization;
namespace URI_JUDGE
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            double invest;

            Console.WriteLine("Seja bem vindo ao rendimento da poupança");


            Console.WriteLine("Informe o seu invesmento!");
            invest = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora informe a quantiade de meses");

            int  contador= 0;

            while (contador< mes)
            {
                invest = invest * 0.3715;

                contador++;

            }






            //   0,3715




        }
    }
}