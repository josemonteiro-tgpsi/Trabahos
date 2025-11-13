using System;
using System.Numerics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        static void drawBody(int a)
        {
            for (int i = 0; i < a; i++) { 
                


            }
        }

        static void drawBase()
        {
            for (int i = 0; i < 3; i++) {
                for (int y = 0; y <= 3; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        static void Main()
        {
            int h;
            Console.Write("Altura: ");
            h = Convert.ToInt16(Console.ReadLine());
            
        
            
        
        }
    }
}
