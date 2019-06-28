using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Entitites
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }

        public Client()
        {

        }
        public Client(string name, string email,DateTime birth)
        {
            Name = name;
            Email = email;
            birthDate = birth;
        }


    }

    
}
