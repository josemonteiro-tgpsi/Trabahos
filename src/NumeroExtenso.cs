using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            int num;
            Console.Write("Insere um número (0-9): ");
            num = Convert.ToInt16(Console.ReadLine());
        
            if (num < 0 || num > 9)
            {
                Console.WriteLine("O número tem que ser entre 0 e 9!");
            } else
            {
                switch(num)
                {
                    case 0:
                        Console.WriteLine("Zero.");
                        break;
                    case 1:
                        Console.WriteLine("Um.");
                        break;
                    case 2:
                        Console.WriteLine("Dois.");
                        break;
                    case 3:
                        Console.WriteLine("Três.");
                        break;
                    case 4:
                        Console.WriteLine("Quatro.");
                        break;
                    case 5:
                        Console.WriteLine("Cinco.");
                        break;
                    case 6:
                        Console.WriteLine("Seis.");
                        break;
                    case 7:
                        Console.WriteLine("Sete.");
                        break;
                    case 8:
                        Console.WriteLine("Oito.");
                        break;
                    case 9:
                        Console.WriteLine("Nove.");
                        break;
                }
            }
        }
    }
}
