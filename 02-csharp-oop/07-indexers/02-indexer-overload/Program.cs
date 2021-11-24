
using System;

namespace RS2.IndexerOverload
{
    class Program
    {
         static void Main()
        {
            Niske elementi = new Niske();

            elementi[0] = "Jedan";
            elementi[1] = "Dva";
            elementi[8] = "Devet";
            elementi[3] = "Cetiri";
            elementi[7] = "Osam";
            for (int i = 0; i < elementi.Dimenzija; i++)
                Console.WriteLine(elementi[i]);
            Console.WriteLine("---");

            Console.WriteLine(elementi["Dva"]);
            Console.WriteLine(elementi["osam"]);
            Console.WriteLine(elementi["JEDAN"]);
            Console.WriteLine(elementi["Tri"]);
            Console.WriteLine(elementi["CeTiRi"]);
        }

    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Jedan
Dva

Cetiri



Osam
Devet

---
Dva
Osam
Jedan

Cetiri

 */

