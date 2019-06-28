using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Contas 
    {
        public string titular { get; set; }
        public int agencia { get;  set; }
        public double saldo { get;  set; }
        public char respotas { get; set; }
       public double valor;
        int tx = 5;
        public Contas(string titular, int agencia, double saldo, char deposito)
        {
            
        }
      public Contas() {
           
        }

        public double PrimeiroSaque(double money)
        {
            return saldo += money;
        }

        public double Depositar(double money)
        {
            return saldo += money;
        }

        public double Sacar(double money)
        {
            return saldo -= money+5;
        }

       
      

    }



}
