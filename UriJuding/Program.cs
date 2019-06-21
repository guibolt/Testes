using System;
using System.Globalization;
namespace GeralTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC, p, p2, area, area2;

            // Capturando os dados do usuario
            Console.WriteLine("Entre  com as medisas do triângulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (xA + xB + xC) / 2;

            area = Math.Sqrt(p *(p - xA) *(p - xB) *(p - xC));

            p2 = (yA + yB + yC) / 2;

            area2 = Math.Sqrt(p2 * (p2 - yA) * (p2 - yB ) * (p2 - yC));

            Console.WriteLine($"Area de X {area.ToString("F4",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y {area2.ToString("F4",CultureInfo.InvariantCulture)}");
            
            if (area > area2)
            {
                Console.WriteLine("Maior Area: X");
            }
            else
                Console.WriteLine("Maior Area: Y");

        }



    }
}