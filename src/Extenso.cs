using System;
using System.ComponentModel.Design;

namespace Programa
{
    class Programa
    {
        static void Main()
        {
            int unidades;
            int dezenas;
            int num;


            Console.Write("Numero: ");
            num = Convert.ToInt16(Console.ReadLine());

            if (num > 99 & num < 1)
            {
                Console.WriteLine("[ERRO] O número tem que ser entre 1 e 99");
            }

            unidades = num % 10;
            dezenas = num / 10;

            if (dezenas == 1)
            {
                switch (unidades)
                {
                    case 0:
                        Console.WriteLine("Dez");
                        break;
                    case 1:
                        Console.WriteLine("Onze");
                        break;
                    case 2:
                        Console.WriteLine("Doze");
                        break;
                    case 3:
                        Console.WriteLine("Treze");
                        break;
                    case 4:
                        Console.WriteLine("Quaorze");
                        break;
                    case 5:
                        Console.WriteLine("Quinze");
                        break;
                    case 6:
                        Console.WriteLine("Dezasseis");
                        break;
                    case 7:
                        Console.WriteLine("Dezassete");
                        break;
                    case 8:
                        Console.WriteLine("Dezoito");
                        break;
                    case 9:
                        Console.WriteLine("Dezanove");
                        break;
                }
            }

            else if (dezenas == 2)
            {
                switch (unidades)
                {
                    case 0: Console.WriteLine("Vinte"); break;
                    case 1: Console.WriteLine("Vinte e um"); break;
                    case 2: Console.WriteLine("Vinte e dois"); break;
                    case 3: Console.WriteLine("Vinte três"); break;
                    case 4: Console.WriteLine("Vinte e quatro"); break;
                    case 5: Console.WriteLine("Vinte e cinco"); break;
                    case 6: Console.WriteLine("Vinte e seis"); break;
                    case 7: Console.WriteLine("Vinte e sete"); break;
                    case 8: Console.WriteLine("Vinte e oito"); break;
                    case 9: Console.WriteLine("Vinte e nove"); break;
                }
            }

            else if (dezenas == 3)
            {
                switch (unidades)
                {
                    case 0: Console.WriteLine("Trinta"); break;
                    case 1: Console.WriteLine("Trinta e um"); break;
                    case 2: Console.WriteLine("Trinta e dois"); break;
                    case 3: Console.WriteLine("Trinta e três"); break;
                    case 4: Console.WriteLine("Trinta e quatro"); break;
                    case 5: Console.WriteLine("Trinta e cinco"); break;
                    case 6: Console.WriteLine("Trinta e seis"); break;
                    case 7: Console.WriteLine("Trinta e sete"); break;
                    case 8: Console.WriteLine("Trinta e oito"); break;
                    case 9: Console.WriteLine("Trinta e nove"); break;

                    
                }



            }
            else if(dezenas == 4)
            {
                switch (unidades)
                {
                    case 0: Console.WriteLine("Quarenta"); break;
                    case 1: Console.WriteLine("Quarenta e um"); break;
                    case 2: Console.WriteLine("Quarenta e dois"); break;
                    case 3: Console.WriteLine("Quarenta e três"); break;
                    case 4: Console.WriteLine("Quarenta e quatro"); break;
                    case 5: Console.WriteLine("Quarenta e cinco"); break;
                    case 6: Console.WriteLine("Quarenta e seis"); break;
                    case 7: Console.WriteLine("Quarenta e sete"); break;
                    case 8: Console.WriteLine("Quarenta e oito"); break;
                    case 9: Console.WriteLine("Quarenta e nove"); break;
                }
            }
            else if(dezenas == 5)
            {
               switch (unidades)
                {
                    case 0: Console.WriteLine("Cinquenta"); break;
                    case 1: Console.WriteLine("Cinquenta e um"); break;
                    case 2: Console.WriteLine("Cinquenta e dois"); break;
                    case 3: Console.WriteLine("Cinquenta e três"); break;
                    case 4: Console.WriteLine("Cinqueta e quatro"); break;
                    case 5: Console.WriteLine("Cinquenta e cinco"); break;
                    case 6: Console.WriteLine("Cinquenta e seis"); break;
                    case 7: Console.WriteLine("Cinquenta e sete"); break;
                    case 8: Console.WriteLine("Cinquenta e oito"); break;
                    case 9: Console.WriteLine("Cinqunta e nove"); break;
                }
            }else if(dezenas == 6)
            {
              switch (unidades)
                {
                    case 0: Console.WriteLine("Sessenta"); break;
                    case 1: Console.WriteLine("Sessenta e um"); break;
                    case 2: Console.WriteLine("Sessenta e dois"); break;
                    case 3: Console.WriteLine("Sessenta e três"); break;
                    case 4: Console.WriteLine("Sessenta e quatro"); break;
                    case 5: Console.WriteLine("Sesenta e cinco"); break;
                    case 6: Console.WriteLine("Sessenta e seis"); break;
                    case 7: Console.WriteLine("Sessenta e sete"); break;
                    case 8: Console.WriteLine("Sessenta e oito"); break;
                    case 9: Console.WriteLine("Sessenta e nove"); break;
                }
            }else if (dezenas == 7)
            {
                switch (unidades)
                {
                    case 0: Console.WriteLine("Setenta"); break;
                    case 1: Console.WriteLine("Setenta e um"); break;
                    case 2: Console.WriteLine("Setenta e dois"); break;
                    case 3: Console.WriteLine("Setenta e três"); break;
                    case 4: Console.WriteLine("Setenta e quatro"); break;
                    case 5: Console.WriteLine("Setenta e cinco"); break;
                    case 6: Console.WriteLine("Setenta e seis"); break;
                    case 7: Console.WriteLine("Setenta e sete"); break;
                    case 8: Console.WriteLine("Setenta e oito"); break;
                    case 9: Console.WriteLine("Seteta e nove"); break;
                }
            }else if (dezenas == 8)
            {
                switch (unidades)
                {
                    case 0: Console.WriteLine("Oitenta"); break;
                    case 1: Console.WriteLine("Oitenta e um"); break;
                    case 2: Console.WriteLine("Oitenta e dois"); break;
                    case 3: Console.WriteLine("Oitenta e três"); break;
                    case 4: Console.WriteLine("Oitenta e quatro"); break;
                    case 5: Console.WriteLine("Oitenta e cinco"); break;
                    case 6: Console.WriteLine("Oitenta e seis"); break;
                    case 7: Console.WriteLine("Oitenta e sete"); break;
                    case 8: Console.WriteLine("Oitenta e oito"); break;
                    case 9: Console.WriteLine("Oitenta e nove"); break;
                }
            }else if (dezenas == 9)
            {
                switch (unidades)
                {
                    case  0: Console.WriteLine("Noventa"); break;
                    case  1: Console.WriteLine("Noventa e um"); break;
                    case  2: Console.WriteLine("Noventa e dois"); break;
                    case  3: Console.WriteLine("Noventa e três"); break;
                    case  4: Console.WriteLine("Noventa e quatro"); break;
                    case  5: Console.WriteLine("Noventa e cinco"); break;
                    case  6: Console.WriteLine("Noventa e seis"); break;
                    case  7: Console.WriteLine("Noventa e sete"); break;
                    case  8: Console.WriteLine("Noventa e oito"); break;
                    case  9: Console.WriteLine("Noventa e nove"); break;
                }
            }

        }     
    }
}
