using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Numero: ");
            int num = Convert.ToInt16(Console.ReadLine());

            if (num < 1 || num > 40) Console.WriteLine("- erro: O numero tem que ser entre 1 e 40.");
            else
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
