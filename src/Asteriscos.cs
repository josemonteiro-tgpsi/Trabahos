using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num;

            do
            {
                Console.Write("Numero: ");
                num = Convert.ToInt16(Console.ReadLine());
            } while (num < 1 || num > 40);
            
            
    
            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
        }
    }
}
