using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Numero: ");
                int num = Convert.ToInt16(Console.ReadLine());
                if (num >= 1 && num <= 40) break;
                else continue;
            }
        }
    }
}
