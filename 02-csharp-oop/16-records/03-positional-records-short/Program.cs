
using System;

namespace RS2.RecordPositional
{

    public record Proizvod
    {
        public string Naziv { get; init; }
        public int KategorijaId { get; init; }

        public Proizvod(string naziv, int kategorijaId)
          => (Naziv, KategorijaId) = (naziv, kategorijaId);

        public void Deconstruct(out string naziv, out int kategorijaId)
          => (naziv, kategorijaId) = (Naziv, KategorijaId);
    }

    class Program
    {
        public static void Main()
        {
            var proizvod = new Proizvod("Igrica WOT", 1);
            var (n, k) = proizvod;
            Console.WriteLine("{0}: ({1}, {2})", nameof(proizvod), k, n);
            Console.WriteLine("---");

            var proizvod2 = proizvod with { KategorijaId = 42 };
            var (n2, k2) = proizvod2;
            Console.WriteLine("{0}: ({1}, {2})", nameof(proizvod2), k2, n2);
            Console.WriteLine("---");

        }
    }
}