using System;

namespace ProgramaVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint M, N;
            int[,] vet;

            Console.WriteLine("Quantas linhas ?");
            M = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Quantas Colunas ? ");
            N = Convert.ToUInt32(Console.ReadLine());

            vet = new int[M, N];

            for (int i=0; i<M; i++)
            {
                Console.WriteLine("Digite o proximo número");
                string[] s = Console.ReadLine().Split(' ');

                for (int j=0; j<N; j++)
                {
                    vet[i, j] = Convert.ToInt32(s[j]);
                }                

            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(vet[i, j] + " ");
                }
                Console.WriteLine();
            }


            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine("Digite o proximo número");
            //    vet[N, M] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i =0; i<N; i++)
            //{
            //    Console.WriteLine(vet[M, N]);
            //}

        }
    }
}
