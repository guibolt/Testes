using System;

namespace EstoqueClass
{
    
  
        class Program
        {
            static void Main(string[] args)
            {
            Produtos p = new Produtos();

               


                Console.WriteLine("Digite o nome do produto:");
                p.nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto:");
                p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite a quantidade do produto:");
                p.quant = int.Parse(Console.ReadLine());


                Console.WriteLine();
                Console.WriteLine("Dados do produto" + p);


                Console.WriteLine("Digite quantas unidades quer adicionar");

                int qte = int.Parse(Console.ReadLine());

                p.AdicionarProdutos(qte);

                Console.WriteLine("Dados Atualizados: " + p);

                Console.WriteLine("Digite quantas unidades quer remover");

                qte = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qte);

                Console.WriteLine("Dados Atualizados: " + p);

            }
        }
    }
