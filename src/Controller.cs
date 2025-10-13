using System;

namespace Controller
{
    class Programa
    {
        static void Main()
        {
            int pos;

            while (true)
            {
                Console.Write("> ");
                pos = Convert.ToInt16(Console.ReadLine());

                switch (pos)
                {
                    case 1:
                    case 2:
                    case 3: Console.WriteLine("Champions League"); break;

                    case 4:
                    case 5:
                    case 6:
                    case 7: Console.WriteLine("Liga Europa"); break;

                    case 8:
                    case 9:
                    case 10: Console.WriteLine("Liga Conferência"); break;

                    default: Console.WriteLine("N/A"); break;

                }
            }
        }
    }
}
