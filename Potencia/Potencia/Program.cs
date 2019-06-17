using System;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
              
            
            Console.WriteLine("Informe o primeiro número:");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            int exp = Convert.ToInt32(Console.ReadLine());
            int pot = 1;


            




            for (int i = 0; 10 < exp; i++) ;
            {
                pot = bas * exp;
            }
            Console.WriteLine(pot);


        }
    }
}
