using System;
using System.Globalization;
using UriJuding;
namespace GeralTeste

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Deseja Alugar quantos Quartos?");
            int N = Convert.ToInt32(Console.ReadLine());

            Aluguel[] vet = new Aluguel[10];
            int cc = 1;
            for (int i = 0; i < N; i++)
            {

                Console.WriteLine("Aluguel #" + cc);

                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite seu email");
                string email = Console.ReadLine();

                Console.WriteLine("Qual quarto quer alugar ?");
                int quarto = Convert.ToInt32(Console.ReadLine());


                vet[quarto] = new Aluguel(nome, email);

                cc++;
 



            }

            for (int i = 0; i <N ; i++)
            {
                Console.WriteLine($"Nome: {vet[i].nome}");
            }


        }
    }

}



