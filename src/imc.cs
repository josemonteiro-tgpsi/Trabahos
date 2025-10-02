using System;

namespace IMC
{
    class Program
    {
        static void Main()
        {
            double peso, altura, imc;
            string s_n;

            Console.Write("Peso: ");
            peso = Convert.ToSingle(Console.ReadLine());
            Console.Write("Altura: ");
            altura = Convert.ToSingle(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine($"O teu IMC é {imc}");

            Console.Write("Queres verificar se estás acima do peso? (S/N) -> ");
            s_n = Console.ReadLine();
            if (s_n == "S" || s_n == "s")
            {
                if (imc < 18.5)
                {
                    Console.WriteLine("[-] Estás abaixo do peso normal.");
                } else if (imc > 18.5 && imc < 25)
                {
                    Console.WriteLine("[+] Estás no peso normal.");
                } else if (imc > 25 && imc < 30)
                {
                    Console.WriteLine("[-] Estás acima do peso normal.");
                } else if (imc > 30)
                {
                    Console.WriteLine("[!] Obesidade.");
                }
            }
        }
    }
}
