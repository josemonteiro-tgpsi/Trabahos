using System;

namespace program
{
    class Program   
    {
        static void Main()
        {
            string shoot;
            int tentativas = 4;
            Random r = new Random();
            int c = 0;
            bool C_pos;
            bool C_num;

            int n1 = r.Next(1, 9);
            int n2 = r.Next(1, 9);
            int n3 = r.Next(1, 9);
            int n4 = r.Next(1, 9);

            int t1, t2, t3, t4;

            Console.WriteLine($"[*] Bem vindo ao Master Minds");
            Console.WriteLine("[+] Tens quatro tentativas");

            while (tentativas >= 1)
            {
                Console.WriteLine($"Tentativa {tentativas}");

                Console.Write("Numero 1: ");
                t1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Numero 2: ");
                t2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Numero 3: ");
                t3 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Numero 4: ");
                t4 = Convert.ToInt16(Console.ReadLine());
                
                
                if (t1 == n1 && t2 == n2 && t3 == n3 && t4 == n4)
                   Console.WriteLine("Acertaste o código!");
                
                if (t1 == n1)
                    C_pos = true;
                    C_num = true;
                
                if (t2 == n2)
                    C_pos = true;
                    C_num = true;
                    
                if (t3 == n3)
                    C_pos = true;
                    C_num = true;
                
                if (t4 == n4)
                    C_pos = true;
                    C_num = true;
                    
                tentativas--;
            }
        }
    }
}
