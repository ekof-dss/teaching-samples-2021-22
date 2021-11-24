
using System;

namespace RS2.GenericIndexer
{
    class Program
    {
         static void Main()
        {
            Elementi<int> procenti = new Elementi<int>();
            procenti[0] = 100;
            procenti[1] = 25;
            procenti[2] = 34;
            procenti[3] = 42;
            procenti[4] = 12;
            procenti[5] = 18;
            procenti[6] = 2;
            procenti[7] = 95;
            procenti[8] = 75;
            procenti[9] = 53;
            for (int i = 0; i < procenti.Dimenzija; i++)
                Console.WriteLine(procenti[i]);
            Console.WriteLine("---");

            Elementi<string> imena = new Elementi<string>(5);
            imena[0] = "Zagor";
            imena[1] = "Komandant Mark";
            imena[2] = "Veliki Blek";
            imena[3] = "Teks Viler";
            imena[4] = "Kit Karson";

            for (int i = 0; i < imena.Dimenzija; i++)
                Console.WriteLine(imena[i]);
            Console.WriteLine("---");
        }

    }
}

