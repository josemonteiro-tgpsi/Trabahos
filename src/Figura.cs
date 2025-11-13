using System;
using System.Numerics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int numero;
            Console.Write("Numero: ");
            numero = Convert.ToInt16(Console.ReadLine());
            
            for (int y = 0; y < numero; y++) {
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("-");
                }

                for (int i = 0; i < numero; i++)
                {
                    Console.Write("V");
                }
                Console.WriteLine();
            } 
        }
    }
}
