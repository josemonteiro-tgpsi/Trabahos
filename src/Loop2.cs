using System;
using System.Threading.Tasks.Sources;


namespace Programa
{
    class Program
    {
        static void Main()
        {
            int num;
            do
            {
                Console.Write("num: ");
                num = Convert.ToInt16(Console.ReadLine());
            } while (num != 0);   
        }
    }
}
