using System;

namespace Teste
{

    class Program
    {

        static void Main(string[] args)
        {
            string nomeUsuario, paisUsuario;
            int idadeUsuario;
            //Aqui pede o Nome ! 
            Console.WriteLine("digite seu nome ");
            nomeUsuario = Console.ReadLine();
            //Aqui pede o Pais ! 
            Console.WriteLine("digite seu pais ");
            paisUsuario = Console.ReadLine();
            //Aqui pede a Idade ! 
            Console.WriteLine("digite sua idade ");
             idadeUsuario = int.Parse (Console.ReadLine());
            Console.ReadLine();


            Console.WriteLine(RetornaString(string nomeUsuario, int idadeUsuario , string paisUsuario ));
        }

        public string RetornaString(string nomeUsuario, int idadeUsuario = 20, string paisUsuario = "Brasil")
        {
            if (nomeUsuario != null && paisUsuario != null && idadeUsuario >= 18)
            {

                return string.Format("Meu nome é {0}, tenho {1} anos e moro no {2}",
                       nomeUsuario, idadeUsuario, paisUsuario);


                else
                    return "O usuario deve ser de maior";

            }
            else
                return "O nome do usuario ou pais de origem nao podem ser nulos";

        }
    }
}
