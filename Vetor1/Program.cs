using System;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Coletando dados do usuario!
            int N;
            N = Convert.ToInt32(Console.ReadLine());

            // declarando os vetores!

            string [] nomes = new string[N];

            int[] idades = new int[N];

            double[] alturas = new double[N];

            // fazendo a leitura da linha e gerando o vetor auxiliar s

            for (int i = 0; i <N; i++) {



                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = Convert.ToInt32(s[1]);
                alturas[i] = Convert.ToDouble(s[2]);

            }

            // Calculo da altura média;
            double soma = 0.0;

            for (int i = 0; i<N; i++){

                soma += alturas[i];
            }

            double media = soma / N;

            Console.WriteLine("Altura Média:" + media);
            // % pessoas com menos de 16 
            int cont = 0;
            for (int i=0; i<N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;

                }
               
            }

            double porcetagem = (double)cont / N * 100.0;

            Console.WriteLine("% de pessoas com menos de 16 anos" + porcetagem);

        }
    }
}
