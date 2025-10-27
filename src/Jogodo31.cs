using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int points = 0;
            int inc;
            int machinePoints = 0;

            Random random = new Random();

            while (points <= 31 || machinePoints <= 31)
            {
                Console.Write("jogada-# ");
                inc = Convert.ToInt16(Console.ReadLine());

                if (inc > 3 || inc < 1) Console.WriteLine("- o numero tem que ser entre 1 e 3!");
                else points = points + inc;

                if (points > 31)
                {
                    Console.WriteLine("- PERDESTE. passaste dos 31 pontos");
                    break;
                } else if (points == 31) {
                    Console.WriteLine("+ ganhaste o jogo! | Pontos: 31");
                    break;
                }

                Console.WriteLine("+ computador a jogar ...");
                machinePoints = machinePoints + random.Next(1, 3);
                Console.WriteLine($"+ pontos da máquina: {machinePoints}\n");
                Thread.Sleep(2000);
            }
        }
    }
}
