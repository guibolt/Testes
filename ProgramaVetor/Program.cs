using System;

namespace ProgramaVetor
{
    class Program
    {
        static void Main(string[] args)
        {

         
                Console.Clear();
                int N;
                double[] vet;
                Console.WriteLine("Digite o número de Vetores");
                N = Convert.ToInt32(Console.ReadLine());

                vet = new double[N];

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Digite o proximo número");
                    vet[i] = Convert.ToDouble(Console.ReadLine());
                }
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(vet[i]);
                }
                Console.WriteLine("Digite uma s para continuar e n para sair ! ");
                
         


        }
    }
}
