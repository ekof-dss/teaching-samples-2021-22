
using System;

namespace RS2.InitializationExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            Poruka p = new Poruka {
                BrojPonavljanja = 2, 
                Sadrzaj = "YYY"};
            p.PrikazNaKonzolu();
            Console.WriteLine("+++");

            p.BrojPonavljanja = 3;
            p.Sadrzaj = "Miki Maus";
            p.PrikazNaKonzolu();
            Console.WriteLine("+++");
        }
        /*
        Program output: 
        ---
        YYY
        YYY
        ---

        ---
        Miki Maus
        Miki Maus
        Miki Maus
        ---

         */

    }

}
