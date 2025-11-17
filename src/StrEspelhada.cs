using System;

namespace program
{
    class Program
    {
        static void Main()
        {
            Console.Write("> ");
            string str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

        }
    }
}
