
using System;

namespace RS2.SimpleProperty
{
    class Program
    {
        static void Main()
        {
            Poruka p = new Poruka();
            p.Sadrzaj = "Mickey Mouse";
            Console.WriteLine("Sadrzaj poruke posle postavljanja: {0}", p.Sadrzaj);
            Console.Write("Alternativni prikaz sadrzaja poruke: ");
            p.PrikazNaKonzolu();
        }

    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Sadrzaj poruke posle postavljanja: Mickey Mouse
Alternativni prikaz sadrzaja poruke: Mickey Mouse

 */

