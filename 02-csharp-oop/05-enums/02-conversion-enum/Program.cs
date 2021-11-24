
using System;

namespace RS2.ConversionEnum
{
    enum Boja
    {
        Crvena,
        Zelena = 10,
        Plava,
        Zuta = 77,
        Ljubicasta,
        Crna
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(Boja.Ljubicasta);
            Console.WriteLine();

            int purple = (int)Boja.Ljubicasta;
            Console.WriteLine(purple);
            Console.WriteLine();

            var color = (Boja)11;
            Console.WriteLine(color);

            var color2 = (Boja)42;
            Console.WriteLine(color2);
        }
    }
}

/*  Program output:
Ljubicasta

78

Plava
 */


