using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int Lado;

            do
            {
                Console.Write("L -> ");
                Lado = Convert.ToInt16(Console.ReadLine());

            } while (Lado < 1 || Lado > 50);

            for (int m = 0; m < Lado; m++)
            {
                for (int b = 0; b < Lado; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
