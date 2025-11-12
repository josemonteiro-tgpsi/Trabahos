using System;
using System.Numerics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int height;
            int esp;

            Console.Write("> ");
            height = Convert.ToInt16(Console.ReadLine());

            esp = height - 1;

            for (int i = 1; i <= height; i++) {
                for (int j = 0; j <= esp; j++)
                {
                    Console.Write(" ");
                }

                for (int y = 1; y <= (2 * i - 1); y++) {
                    Console.Write(i);
                }

                esp--;
                Console.WriteLine();
            }
        }
    }
}
