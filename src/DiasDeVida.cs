using System;

namespace IMC
{
    class Program
    {
        static void Main()
        {
            const int anoDias = 365;
            int idade, totalEmDias;


            Console.Write("Tens quantos anos?: ");
            idade = Convert.ToInt16(Console.ReadLine());

            totalEmDias = 365 * idade;

            Console.WriteLine($"Tens {totalEmDias} dias de vida.");

        }
    }
}
