    using System;

    namespace program
    {
        class Program   
        {

            static bool check_par_impar(int N) {
                if (N % 2 == 0) return true;
                else return false;
            }   
            
            static void quadrado(int lado) {
                for (int i = 0; i < lado; i++) {
                    for (int j = 0; j <= lado; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            } 

            static void Main()
            {
                Console.Write("> ");
                int l = Convert.ToInt16(Console.ReadLine());
                quadrado(l);
                Console.WriteLine(check_par_impar(l));
            }
        }
    }
