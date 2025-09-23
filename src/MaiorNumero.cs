using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            int n1, n2, n3;

            Console.Write("N1: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("N2: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("N3: ");
            n3 = Convert.ToInt16(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"[+] O maior número é o {n1}");
            } else if (n2 > n1 && n1 > n3)
            {
                Console.WriteLine($"[+] O maior número é o {n2}");
            } else if (n3 > n2 && n3 > n1)
            {
                Console.WriteLine($"[+] O maior número é o {n3}");
            }
        }
    }
}
