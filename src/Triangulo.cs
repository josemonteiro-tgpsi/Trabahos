using System;

namespace Exercicio3
{
    class Program
    {
        static void Main()
        {
            int l1, l2, l3;

            Console.Write("Lado 1: ");
            l1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Lado 2: ");
            l2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Lado 3: ");
            l3 = Convert.ToInt16(Console.ReadLine());

            if (l1 == l2 & l1 == l3)
            {
                Console.WriteLine("O triângulo é equilátero.");
            } else if (l1 == l2 || l2 == l3)
            {
                Console.WriteLine("O  triângulo é isósceles");
            } else if (l1 != l2 && l2 != l3)
            {
                Console.WriteLine("O triângulo é escaleno.");
            }
        }
    }
}
