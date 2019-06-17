using System;
using System.Globalization;

namespace UriJuding
{
    class Program
    {
        static void Main(string[] args)
        {

            double R = 0, pi = 3.14159, volume = 0;

           R = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume = (4 / 3.0) * pi * Math.Pow(R,3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3",CultureInfo.InvariantCulture));



        }       
    }
}
