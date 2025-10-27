using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num;
            Console.Write("[Int] > ");
            num = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int res = num * i;
                Console.WriteLine($"{num} x {i} = {res}");
            }
        }
    }
}
