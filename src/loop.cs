using System;

namespace Programa
{
    class Program
    {
        static void Main()
        {
            int num;
            Console.Write("Inserir um n positivo: ");
            num = Convert.ToInt16(Console.ReadLine());
            if (num > 0)
            {
                for (int i = num; i >= 0; i--)
                {
                    Console.WriteLine($"Numero: {i}");
                }
            } else
            {
                for (int i = num; i <= 0; i++)
                {
                    Console.WriteLine($"Numero: {i}");
                }
            }
        }
    }
}
