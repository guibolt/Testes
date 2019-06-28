using System;
using System.Globalization;
namespace TestesStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro v = new Carro();
            Carro v2 = new Carro();

            try
            {
                Console.WriteLine("Digite a marca do carro");
                v.Marca = Console.ReadLine();
                Console.WriteLine("Agora digite o nome do carro");
                v.Nome = Console.ReadLine();
                Console.WriteLine("Digite o pais de origem do carro");
                v.Paisde = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de portas");
                v.Portas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a Capacidade do Tanque");
                v.Tanque = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite se o Carro é flex ,  para Sim ou  para Não");
                string resposta = Console.ReadLine();
                if (resposta == "Sim" || resposta == "sim")
                {
                    v.Flex = true;
                }
                else
                    v.Flex = false;

                Console.WriteLine("Quantos km você rodou ?");
                v.KM = double.Parse(Console.ReadLine());

                v.DataDeFrabricacao = DateTime.Now;

            }
            catch (Exception)
            {
                Console.WriteLine("Erro tente novamento");
                
            }

            Console.WriteLine($"Marca: {v.Marca} Nome: {v.Nome}\nPais de Origem: {v.Paisde} Quantidade de portas\n{v.Portas}\nCapacidade do Tanque {v.Tanque} Flex ?: {v.Flex} KM Rodada: {v.KM}\nData de Fabricação: {v.DataDeFrabricacao}");
            
            Console.WriteLine($"Capacidade por litro: {v.CalcularLitro(v.KM,v.Tanque).ToString("F2",CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Autonomia do veiculo: {v.CalcularAutonomia(v.CalcularLitro(v.KM, v.Tanque),v.Tanque)}");
        }
    }
}
