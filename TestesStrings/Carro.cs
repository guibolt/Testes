using System;
using System.Collections.Generic;
using System.Text;

namespace TestesStrings
{
   public class Carro
    {
        public string Marca;
        public string Nome;
        public string Paisde;
        public int Portas;
        public double Tanque;
        public bool Flex;
        public DateTime DataDeFrabricacao;
        public double KM;

        public Carro(string marca, string nome, string pais, int portas, double tanque,bool flex,double km ,DateTime datafrabicação)
        {
            Marca = marca;
            Nome = nome;
            Paisde = pais;
            Portas = portas;
            Tanque = tanque;
            Flex = flex;
            KM = km;
            DataDeFrabricacao = datafrabicação;
            Aumentar();
        }
        public Carro() { }

        public double CalcularLitro( double km, double tanq)
        {
            return km / tanq;
        }

       public double CalcularAutonomia(double litro,double tanque)
        {
            return litro * tanque; 
        }

        public void Aumentar()
        {
           Marca = Marca.ToUpper();
           Nome = Nome.ToUpper();
           Paisde = Paisde.ToUpper();

        }
    }
}
