    using System;

    namespace program
    {
        class Program   
        {

            static bool check_par_impar(int N) {
                if (N % 2 == 0) return true;
                else return false;
            }    

            static void Main()
            {
                Console.Write("> ");
                int l = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(check_par_impar(l));
            }
        }
    }
