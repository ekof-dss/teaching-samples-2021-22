
using System;

namespace RS2.AnonimousMethod
{
    // deklaracija delegata, koji ocekuje jedan celobrojni argument
    public delegate void Prikazi(int value);

    public class Program
    {
        // ovde je delegat parametar metoda
        public static void PrikaziHelper(Prikazi delegatZaPrikaz, int val)
        {
            val += 10;
            delegatZaPrikaz(val);
        }

        static void Main(string[] args)
        {
            int i = 5;
            // napravljen je anonimni metod i dodeljen delegatu
            Prikazi prkz = delegate (int x){
                x += i;
                Console.WriteLine("Vrednost promenljive {0} u prvom anonimnom metodu: {1}", nameof(x), x);
            };
            // poziva se prethodno napravljeni anonimni metod
            prkz(100);
            Console.WriteLine("---");

            // prilikom poziva metoda u kom je parametar delegat, odgovarajuci argument moze biti anonimni metod
            PrikaziHelper( 
                delegate (int val) { 
                    Console.WriteLine("Vrednost promenljive {0} u drugom anonimnom metodu: {1}", nameof(val), val); 
                }, 
                120);
            Console.WriteLine("---");
        }
    }
}

/*
Vrednost promenljive val u prvom anonimnom metodu: 105

Vrednost promenljive val u drugom anonimnom metodu: 130

 */

