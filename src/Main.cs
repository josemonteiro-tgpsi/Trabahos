using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        int numero, dezenas, unidades, centenas, resto;
        Console.Write("Insere um numero (0-999) : ");
        numero = Convert.ToInt32(Console.ReadLine());
        centenas = numero / 100;
        resto = numero % 100;
        dezenas = resto / 10;
        unidades = resto % 10;

        switch (centenas)
        {
            case 1:
                if (numero == 100) Console.WriteLine("Cem");
                else Console.Write("Cento e ");
                break;

            case 2: Console.Write("Duzentos"); break;
            case 3: Console.Write("Trezentos"); break;
            case 4: Console.Write("Quatrocentos"); break;
            case 5: Console.Write("Quinhentos"); break;
            case 6: Console.Write("Seiscentos"); break;
            case 7: Console.Write("Setecentos"); break;
            case 8: Console.Write("Oitocentos"); break;
            case 9: Console.Write("Novecentos"); break;
        }

        if ((centenas >= 1) && ((dezenas >= 1) || (unidades >= 1))) Console.Write(" e ");

        switch (dezenas)
        {
            case 2:
                Console.Write("Vinte");
                break;
            case 3: Console.Write("Trinta"); break;
            case 4: Console.Write("Quarenta"); break;
            case 5: Console.Write("Cinquenta"); break;
            case 6: Console.Write("Sessenta"); break;
            case 7: Console.Write("Setente"); break;
            case 8: Console.Write("Oitenta"); break;
            case 9: Console.Write("Noventa"); break;

        }

        if ((centenas >= 1) && ((dezenas >= 1) || (unidades >= 1))) Console.Write(" e ");

        switch (unidades)
        {  
            case 1: Console.Write("Um"); break;
            case 2: Console.Write("Dois"); break;
            case 3: Console.Write("Três"); break;
            case 4: Console.Write("Quatro"); break;
            case 5: Console.Write("Cinco"); break;
            case 6: Console.Write("Seis"); break;
            case 7: Console.Write("Sete"); break;
            case 8: Console.Write("Oito"); break;
            case 9: Console.Write("Nove"); break;
        }



        if ((numero == 0) || ((numero >= 100) && (numero <= 999)))
        {
            switch (resto)
            {
                case 0:

                    Console.Write("zero");
                    break;

                case 1:
                    Console.Write("Um");
                    break;

                case 2:
                    Console.Write("Dois");
                    break;

                case 3:
                    Console.Write("Três");
                    break;

                case 4:
                    Console.Write("Quatro");
                    break;

                case 5:
                    Console.Write("Cinco");
                    break;

                case 6:
                    Console.Write("Seis");
                    break;

                case 7:
                    Console.Write("Sete");
                    break;

                case 8:
                    Console.Write("Oito");
                    break;

                case 9:
                    Console.Write("Nove");
                    break;

                case 10:

                    Console.Write("dez");
                    break; 

                case 11:

                    Console.Write("onze");
                    break;

                case 12:

                    Console.Write("doze");
                    break;

                case 13:

                    Console.Write("treze");
                    break;

                case 14:

                    Console.Write("quatorze");
                    break;

                case 15:

                    Console.Write("quinze");
                    break;

                case 16:

                    Console.Write("dezasseis");
                    break;

                case 17:

                    Console.Write("dezassete");
                    break;

                case 18:

                    Console.Write("dezoito");
                    break;

                case 19:

                    Console.Write("dezanove");
                    break;
            }
        } 
    }
}
