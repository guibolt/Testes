using System;

namespace Estud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao IMC \n");

            Console.WriteLine("Informe o seu nome");
            string nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Informe o seu peso");
            decimal peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o seu altura");
            decimal altura= Convert.ToInt32(Console.ReadLine());
        }

        
    

    }
}
