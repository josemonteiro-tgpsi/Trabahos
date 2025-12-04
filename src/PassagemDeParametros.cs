    using System;

    namespace program
    {
        class Program   
        {

            static void quadrado(int lado) {
                for (int i = 0; i < lado; i++) {
                    for (int j = 0; j <= lado; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }    

            static void Main()
            {
                int l = Convert.ToInt16(Console.ReadLine());
                quadrado(l);
            }
        }
    }
