using System;

namespace program
{
    class Program
    {
        static void Main()
        {
            string str;
            int vogais = 0;
            Console.Write("> ");
            str = Console.ReadLine();
            
            for (int i = 0; i <= str.Length - 1; i++)
            {
                str = str.ToUpper();
                if (str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                    vogais = vogais + 1;
            }
            Console.WriteLine($"A string inserida contém {vogais} vogais.");
        }
    }
}
