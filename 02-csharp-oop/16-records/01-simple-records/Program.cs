/*

C# 9 Introduces a new keyword: record keyword. record keyword makes an object immutable and behave like a value type. To make 
the whole object immutable you have to set init keyword on each property if you are using an implicit parameterless constructon.

 */

using System;

namespace RS2.SimpleRecord
{

    public record Proizvod
    {
        public string Naziv { get; init; }
        public int KategorijaId { get; init; }
    }

    class Program
    {
        public static void Main()
        {
            var proizvod = new Proizvod
            {
                Naziv = "Igrica WOT",
                KategorijaId = 1
            };
            Console.WriteLine("{0}: ({1}, {2})", nameof(proizvod), proizvod.KategorijaId, proizvod.Naziv);
            Console.WriteLine("---");

            // ovo ne moze
            //proizvod.KategorijaId = 42;

            var proizvod2 = proizvod with { KategorijaId = 42 };
            Console.WriteLine("{0}: ({1}, {2})", nameof(proizvod2), proizvod2.KategorijaId, proizvod2.Naziv);
            Console.WriteLine("---");

            if(proizvod.Equals(proizvod2))
                Console.WriteLine("Za {0} i {1} metod Equals vrace true", nameof(proizvod), nameof(proizvod2));
            else
                Console.WriteLine("Za {0} i {1} metod Equals vrace false", nameof(proizvod), nameof(proizvod2));
            if (proizvod == proizvod2)
                Console.WriteLine("Za {0} i {1} operator == vrace true", nameof(proizvod), nameof(proizvod2));
            else
                Console.WriteLine("Za {0} i {1} operator == vrace false", nameof(proizvod), nameof(proizvod2));
            Console.WriteLine("---");

            var proizvod3 = proizvod = new Proizvod
            {
                Naziv = "Igrica WOT",
                KategorijaId = 1
            };
            Console.WriteLine("{0}: ({1}, {2})", nameof(proizvod3), proizvod3.KategorijaId, proizvod3.Naziv);
            if (proizvod.Equals(proizvod3))
                Console.WriteLine("Za {0} i {1} metod Equals vrace true", nameof(proizvod), nameof(proizvod3));
            else
                Console.WriteLine("Za {0} i {1} metod Equals vrace false", nameof(proizvod), nameof(proizvod3));
            if (proizvod == proizvod3)
                Console.WriteLine("Za {0} i {1} operator == vrace true", nameof(proizvod), nameof(proizvod3));
            else
                Console.WriteLine("Za {0} i {1} operator == vrace false", nameof(proizvod), nameof(proizvod3));
            Console.WriteLine("---");
        }
    }
}