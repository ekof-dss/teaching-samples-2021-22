
using System;

namespace RS2.SimpleDelegate
{
    //deklaracija delegata
    public delegate void MojDelegat(string tekst); 

    public class KlasaA
    {
        public static void MetodaA(string poruka)
        {
            Console.WriteLine("Pozvan je metod KlasaA.MetodA() sa parametrom: " + poruka);
            Console.WriteLine(poruka.ToUpper());
        }
    }

    public class KlasaB
    {
        public static void MetodaB(string message)
        {
            Console.WriteLine("Pozvan je metod KlasaB.MetodB() sa parametrom: " + message);
            var n = message.Length;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < i; j++)
                    Console.Write(" ");
                Console.WriteLine(message[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MojDelegat del;
            del = KlasaA.MetodaA;
            del("Zdravo svete");

            del = KlasaB.MetodaB;
            del("Zdravo svete");
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Pozvan je metod KlasaA.MetodA() sa parametrom: Zdravo svete
ZDRAVO SVETE
Pozvan je metod KlasaB.MetodB() sa parametrom: Zdravo svete
Z
 d
  r
   a
    v
     o

       s
        v
         e
          t
           e

 */

