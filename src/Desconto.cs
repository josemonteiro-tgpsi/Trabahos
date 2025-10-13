using System;

namespace Controller
{
    class Programa
    {
        static void Main()
        {
            double Anual;
            double desconto;
            double salario;


            Console.Write("Salario Anual: ");
            Anual = Convert.ToSingle(Console.ReadLine());

            if (Anual <= 7703)
            {
                desconto = Anual * 0.13;
                salario = Anual - desconto;
                Console.WriteLine($"Salario: {salario}");
            }
            else if (Anual > 7703 && Anual < 11623)
            {
               desconto = Anual * 0.16;
                salario = Anual - desconto;
                Console.WriteLine($"Salario: {salario}");
            }
            else if (Anual < 11623 && Anual < 16472)
            {
                desconto = Anual * 0.22;
                salario = Anual - desconto;
                Console.WriteLine($"Salario: {salario}");
            } 
            else if (Anual > 16472 && Anual < 21321)
            {
                desconto = Anual * 0.25;
                salario = Anual - desconto;
                Console.WriteLine($"Salario: {salario}");
            }
        }
    }
}
