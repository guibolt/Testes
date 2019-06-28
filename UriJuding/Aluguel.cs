using System;
using System.Collections.Generic;
using System.Text;

namespace UriJuding
{
   public class Aluguel
    {
        public string nome { get; set; }
        public string email { get; set; }
        public int quartos { get; set; }

        public Aluguel(string Nome, string Email)
        {
            nome = Nome;
            email = Email;

            Console.WriteLine($"Nome:  {nome}");
            Console.WriteLine($"email: {email}");
            
        }



    }
}
