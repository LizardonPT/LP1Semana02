using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza o número de linhas: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= (n-i); space++)
                {
                    Console.Write(" ");
                }
                for (int a = 1; a <= i; a++)
                {
                    Console.Write("*");
                }
                for (int a = (i-1); a >= 1; a--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
