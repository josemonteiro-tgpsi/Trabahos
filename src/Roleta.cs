using System;
using System.Threading.Tasks.Sources;


namespace Programa
{
    class Program
    {
        static void Main()
        {
            const int numeroC = rand.Next(0, 999);
            int numeroE;
            Console.Write("Tenta adivinhar o numero (0-999): ");
            numeroE = Convert.ToInt16(Console.ReadLine());

            if (numeroE < 0 || numeroE > 999)
            {
                Console.WriteLine("[!] Erro: O número não pode ser maior que 999 ou menor que 0.");
            } else if (numeroE == numeroC) {
                Console.WriteLine("[+] Acertaste o número!");
            } else { 
                Console.WriteLine("[-] Não acertaste o número.");
            }
        }
    }
}
