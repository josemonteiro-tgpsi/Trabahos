using System;

namespace Exercicio5
{
    class Program
    {
        static void Main()
        {
            double Peso;
            double altura;
            string sexo;
            double PesoIdeal;

            Console.Write("Peso -> ");
            Peso = Convert.ToSingle(Console.ReadLine());

            Console.Write("Altura -> ");
            altura = Convert.ToSingle(Console.ReadLine());

            Console.Write("Sexo (F/M) -> ");
            sexo = Console.ReadLine();

            if (sexo == "F")
            {
                PesoIdeal = (62.7 * altura) - 44.7;
                Console.WriteLine($"O peso ideal é {PesoIdeal}");
            } else if (sexo == "M")
            {
                PesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"O peso ideal é {PesoIdeal}");
            }

        }
    }
}
