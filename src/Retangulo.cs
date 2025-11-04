using System;
using System.Numerics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int H, C;

            Console.Write("Altura: ");
            H = Convert.ToInt16(Console.ReadLine());
            Console.Write("Comprimento: ");
            C = Convert.ToInt16(Console.ReadLine());
            
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
