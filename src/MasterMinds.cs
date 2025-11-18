using System;

namespace program
{
    class Program
    {

        void CheckPos(string s)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (shoot[i] == n1)
                {

                }
            }
        }

        static void Main()
        {
            string shoot;
            Random r = new Random();

            int n1 = r.Next(1, 9);
            int n2 = r.Next(1, 9);
            int n3 = r.Next(1, 9);
            int n4 = r.Next(1, 9);

            Console.WriteLine($"[*] Bem vindo ao Master Minds");
            Console.Write(": ");
            shoot = Console.ReadLine();
            
        }
    }
}
