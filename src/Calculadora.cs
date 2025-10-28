using System;

namespace Controller
{
    class Programa
    {
        static void Main()
        {
            int n1, n2;
            double res, resP;
            string operador;

            Console.Write("Numero 1: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Operador: ");
            operador = Console.ReadLine();

            Console.Write("Numero 2: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            if (operador == "+")
            {
                res = n1 + n2;
                Console.WriteLine($"O resultado é {res}");
            }
            else if (operador == "-")
            {
                res = n1 - n2;
                Console.WriteLine($"O resultado é {res}");
            }
            else if (operador == "*")
            {
                res = n1 * n2;
                Console.WriteLine($"O resultado é {res}");
            }
            else if (operador == "/") {
                res = n1 + n2;
                Console.WriteLine($"O resultado é {res}");
            } else if (operador == "p")
            {
                resP = Math.Pow(n1, n2);
                Console.WriteLine($"O resultado é {resP}");
            }
        }
    }
}
