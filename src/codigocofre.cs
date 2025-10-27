using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int n1, n2, n3;
            int t1, t2, t3;

            n1 = random.Next(0, 9);
            n2 = random.Next(0, 9);
            n3 = random.Next(0, 9);

            Console.Write("1# ");
            t1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("2# ");
            t2 = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("3# ");
            t3 = Convert.ToInt16(Console.ReadLine());

        }
    }
}
