
using System;

namespace DSS.InitializationExpression
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
            p.Sadrzaj = "Mickey Mouse";
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
        Mickey Mouse
        Mickey Mouse
        Mickey Mouse
        ---

         */

    }

}
