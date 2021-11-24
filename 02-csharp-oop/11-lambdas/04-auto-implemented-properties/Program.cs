
using System;

namespace RS2.AutoImplementedProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Poruka p = new Poruka();
            p.Sadrzaj = "Miki Maus";
            Console.WriteLine(p.Sadrzaj);
            p.Sadrzaj = "Paja Patak";
            p.PrikazNaKonzolu();
        }

    }

}
