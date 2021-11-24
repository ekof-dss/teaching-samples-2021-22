
using System;

namespace RS2.RecordPositional
{

    public record Proizvod
    {
        public string Naziv { get; init; }
        public int KategorijaId { get; init; }
    }

    public record Knjiga : Proizvod
    {
        public string ISBN { get; init; }
    }

    class Program
    {
        public static void Main()
        {
            Proizvod proizvod = new Knjiga
            {
                Naziv = "AUtostoperski vodic kroz galaksiju",
                KategorijaId = 2,
                ISBN = "00000000000000"
            };

            var noviProizvod = proizvod with { KategorijaId = 4 };

            Console.WriteLine(noviProizvod.GetType().Name);
            Console.WriteLine(noviProizvod.Naziv);
            Console.WriteLine(noviProizvod.KategorijaId);
            // unavaliable
            //Console.WriteLine(noviProizvod.ISBN);


            var knjiga = (Knjiga)noviProizvod;
            // available after casting
            Console.WriteLine(knjiga.ISBN);

            var proizvod3 = new Proizvod
            {
                Naziv = "AUtostoperski vodic kroz galaksiju",
                KategorijaId = 2
            };
            if (proizvod.Equals(proizvod3))
                Console.WriteLine("Za {0} i {1} metod Equals vrace true", nameof(proizvod), nameof(proizvod3));
            else
                Console.WriteLine("Za {0} i {1} metod Equals vrace false", nameof(proizvod), nameof(proizvod3));
        }
    }
}