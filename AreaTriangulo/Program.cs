using System;
using System.Globalization;
namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
        
            double area, area2;


            // Capturando os dados do usuario
            Console.WriteLine("Entre  com as medisas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            area = x.CalcularArea();
            area2 = y.CalcularArea();

            Console.WriteLine($"Area de X {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y {area2.ToString("F4", CultureInfo.InvariantCulture)}");

            if (area > area2)
            {
                Console.WriteLine("Maior Area: X");
            }
            else
                Console.WriteLine("Maior Area: Y");

        }
    }
}
