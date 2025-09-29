using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)

        {

            int num, dez, uni;

            Console.WriteLine("introduza um número entre 0 e 99");

            num = Convert.ToInt16(Console.ReadLine());

            dez = num / 10;

            uni = num % 10;



            if ((num == 0) || ((num >= 10) && (num <= 19)))

            {

                switch (num)

                {

                    case 0:

                        Console.WriteLine("zero");

                        break;

                    case 10:

                        Console.WriteLine("dez");

                        break;

                    case 11:

                        Console.WriteLine("onze");

                        break;

                    case 12:

                        Console.WriteLine("doze");

                        break;

                    case 13:

                        Console.WriteLine("treze");

                        break;

                    case 14:

                        Console.WriteLine("catorze");

                        break;

                    case 15:

                        Console.WriteLine("quinze");

                        break;

                    case 16:

                        Console.WriteLine("dezasseis");

                        break;

                    case 17:

                        Console.WriteLine("desassete");

                        break;

                    case 18:

                        Console.WriteLine("desoito");

                        break;

                    case 19:

                        Console.WriteLine("desanove");

                        break;

                }







            }



            else

            {

                switch (dez)

                {

                    case 2:

                        Console.Write("vinte");

                        break;

                    case 3:

                        Console.Write("trinta");

                        break;

                    case 4:

                        Console.Write("quarenta");

                        break;

                    case 5:

                        Console.WriteLine("cinquenta");

                        break;

                    case 6:

                        Console.WriteLine("sessenta");

                        break;

                    case 7:

                        Console.WriteLine("setenta");

                        break;

                    case 8:

                        Console.WriteLine("oitenta");

                        break;

                    case 9:

                        Console.WriteLine("noventa");

                        break;



                }



                if ((dez > 0) && (uni > 0)) Console.Write(" e ");



                switch (uni)

                {

                    case 1:

                        Console.WriteLine("um");

                        break;

                    case 2:

                        Console.WriteLine("dois");

                        break;

                    case 3:



                        Console.WriteLine("tres");

                        break;

                    case 4:

                        Console.WriteLine("quatro");

                        break;

                    case 5:

                        Console.WriteLine("cinco");

                        break;

                    case 6:

                        Console.WriteLine("seis");

                        break;

                    case 7:

                        Console.WriteLine("sete");

                        break;

                    case 8:

                        Console.WriteLine("oito");

                        break;

                    case 9:

                        Console.WriteLine("nove");

                        break;

                }

            }

            Console.ReadLine();

        }
    }
}
