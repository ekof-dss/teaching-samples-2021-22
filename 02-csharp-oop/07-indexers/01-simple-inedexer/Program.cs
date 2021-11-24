
using System;

namespace RS2.SimpleIndexer
{
    class Program
    {
         static void Main()
        {
            Niske elementi = new Niske();

            elementi[0] = "Jedan";
            elementi[1] = "Dva";
            elementi[2] = "Tri";
            elementi[3] = "Cetiri";
            for (int i = 0; i < elementi.Dimenzija; i++)
                Console.WriteLine(elementi[i]);
            Console.WriteLine("---");
            
            elementi.Dimenzija = 15;
            elementi[-17] = "Osam";
            for (int i = 0; i < elementi.Dimenzija; i++)
                Console.WriteLine(elementi[i]);
            Console.WriteLine();
            Console.WriteLine("---");
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Jedan
Dva
Tri
Cetiri






---
Jedan
Dva
Tri
Cetiri



Osam




 */

