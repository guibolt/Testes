using System;

namespace TesteVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n;
             // Coletando os dados do usuario;
            Console.WriteLine("Escreva os numeros");

            n = Convert.ToInt32(Console.ReadLine());
            // declarar os vetores;
            int[] unidadepeca = new int[n];
            double[] valorpeca = new double[n];
          


            // fazendo a leitura e usando o auxilar S

            for (int i =0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

               unidadepeca[i] = Convert.
               valorpeca [i]= Convert.ToInt32(s[0]);
               

            }




            
        }
    }
}
