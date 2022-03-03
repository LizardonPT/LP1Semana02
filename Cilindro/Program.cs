using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduz a altura: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nIntroduz o raio: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double pi = 3.1415926;
            double area = 2*pi*r*(r+a);
            double volume = pi*Math.Pow(r, 2)*a;
            
            Console.WriteLine($"\nA área da superficie é de {area}");
            Console.WriteLine($"O volume é de {volume}");
        }
    }
}
