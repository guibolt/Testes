using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Contas C = new Contas();

            Console.WriteLine("Qual é o nome do titular da conta?");
            C.titular = Console.ReadLine();

            Console.WriteLine("Entre com o numero da conta");
            C.agencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Haverá deposito inicial ? s para sim e n para nao");
            C.respotas = Convert.ToChar(Console.ReadLine());
            if (C.respotas =='s')
            {
                Console.WriteLine("Qual é o valor ?");
                C.valor = Convert.ToDouble(Console.ReadLine());
                C.PrimeiroSaque(C.valor);
            }
            else
                Console.WriteLine("ok");

            Console.WriteLine($"Dados da conta:\n Titular: {C.titular}\nConta: {C.agencia}\nSaldo: R${C.saldo}");

            Console.WriteLine("Entre com um valor para depósito");
            C.valor = Convert.ToDouble(Console.ReadLine());
            C.Depositar(C.valor);

            Console.WriteLine($"Dados da Conta Atualizados:{C.titular}\nConta: {C.agencia}\nSaldo: R${C.saldo}");

            Console.WriteLine("Entre com um valor para saque");
            C.valor = Convert.ToDouble(Console.ReadLine());
            C.Sacar(C.valor);

            Console.WriteLine($"Dados da Conta Atualizados:{C.titular}\nConta: {C.agencia}\nSaldo: R${C.saldo}");




            public override string ToString()
        {
            return "Olá ";
        }


    }
    }
}
