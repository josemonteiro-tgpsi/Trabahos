using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num;

            Console.Write("> ");
            num = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                } Console.WriteLine();
            }
        }
    }
}
