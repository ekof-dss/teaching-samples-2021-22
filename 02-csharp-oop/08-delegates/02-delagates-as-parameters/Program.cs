
using System;

namespace RS2.DelegatesAsParameters
{
    // deklaracija delegata
    public delegate void NoviDelegat(string s);

    public class KlasaA
    {
        public static void MetodA(string poruka)
        {
            Console.WriteLine("Pozvan je metod KlasaA.MetodA() sa parametrom: " + poruka);
            Console.WriteLine(poruka.ToUpper());
        }
    }

    public class KlasaB
    {
        public static void MetodB(string por)
        {
            Console.WriteLine("Pozvan je metod KlasaB.MetodB() sa parametrom: " + por);
            var n = por.Length;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < i; j++)
                    Console.Write(" ");
                Console.WriteLine(por[i]);
            }
        }
    }

    public class Program
    {
        // u ovom metodu delegat je parametar
        public static void PozoviDelegat(NoviDelegat del, string str) 
        {
            del(str);
        }
        static void Main(string[] args)
        {
            NoviDelegat del = KlasaA.MetodA;
            PozoviDelegat(del, "Zagor");

            del = KlasaB.MetodB;
            PozoviDelegat(del, "Veliki Blek");
        }
     }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Pozvan je metod KlasaA.MetodA() sa parametrom: Zagor
ZAGOR
Pozvan je metod KlasaB.MetodB() sa parametrom: Veliki Blek
V
 e
  l
   i
    k
     i

       B
        l
         e
          k
 */

