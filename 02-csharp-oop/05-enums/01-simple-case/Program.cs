
using System;

namespace RS2.SimpleEnum
{
    public enum Boja
    {
        Crvena,
        Zelena = 10,
        Plava
    }

    public static class BojaProsirenje
    {
        public static string Opis2(this Boja boja)
        {
            return String.Format("{0} = {1}", boja, (int)boja);
        }
    }

    class Test
    {
        static string Opis1(Boja c)
        {
            switch (c)
            {
                case Boja.Crvena:
                    return String.Format("Crvena = {0}", (int)c);

                case Boja.Zelena:
                    return String.Format("Zelena = {0}", (int)c);

                case Boja.Plava:
                    return String.Format("Plava = {0}", (int)c);

                default:
                    return "Nepostojeca boja";
            }
        }

        static void Main()
        {
            Console.WriteLine(Opis1(Boja.Crvena));
            Console.WriteLine(Opis1(Boja.Zelena));
            Console.WriteLine(Opis1(Boja.Plava));
            Console.WriteLine("---");

            Boja b = Boja.Crvena;
            Console.WriteLine(b.Opis2());
            Console.WriteLine(Boja.Zelena.Opis2());
        }

    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Crvena = 0
Zelena = 10
Plava = 11
 */

