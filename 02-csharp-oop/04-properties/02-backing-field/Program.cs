
using System;

namespace RS2.PropertyBackingField
{
    class Program
    {
        static void Main()
        {
            Karakter lik = new Karakter(ime:"Paja", "Patak");
            Console.WriteLine("lik - ime: {0}", lik.Ime);
            Console.WriteLine("lik - prezime: {0}", lik.Prezime);
            Console.WriteLine("lik - puno ime: {0}", lik.PunoIme);
            Console.WriteLine();

            lik.Ime = "Baja";
            Console.WriteLine("lik - ime: {0}", lik.Ime);
            Console.WriteLine("lik - prezime: {0}", lik.Prezime);
            Console.WriteLine("lik - puno ime: {0}", lik.PunoIme);
            Console.WriteLine();

            lik.PunoIme = "Felipe Kaetano Lopez Martinez Gonzales";
            Console.WriteLine("lik - ime: {0}", lik.Ime);
            Console.WriteLine("lik - prezime: {0}", lik.Prezime);
            Console.WriteLine("lik - puno ime: {0}", lik.PunoIme);
            Console.WriteLine();

            lik.PunoIme = "Supermen";
            Console.WriteLine("lik - ime: {0}", lik.Ime);
            Console.WriteLine("lik - prezime: {0}", lik.Prezime);
            Console.WriteLine("lik - puno ime: {0}", lik.PunoIme);
            Console.WriteLine();
        }
    }

}

/* Izlaz dobijen prilikom izvrsavanja programa:
lik - ime: Paja
lik - prezime: Patak
lik - puno ime: Paja Patak

lik - ime: Baja
lik - prezime: Patak
lik - puno ime: Baja Patak

lik - ime: Felipe Kaetano Lopez Martinez
lik - prezime: Gonzales
lik - puno ime: Felipe Kaetano Lopez Martinez Gonzales

lik - ime: XXX
lik - prezime: Supermen
lik - puno ime: XXX Supermen
 */

