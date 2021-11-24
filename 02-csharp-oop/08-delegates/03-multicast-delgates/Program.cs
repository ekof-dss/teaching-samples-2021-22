
using System;

namespace RS2.MulticastDelegates
{
    // deklaracija delegata
    public delegate void MojDelegat(string s);

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
        public static void InvokeDelegate(MojDelegat del) // parametar koji predstavlja delegat
        {
            del("Hello World");
        }
        static void Main(string[] args)
        {
            MojDelegat del1 = KlasaA.MetodA;
            MojDelegat del2 = KlasaB.MetodB;

            MojDelegat del = del1;
            del += del2;
            del("Mickey Mouse");
            Console.WriteLine("---");

            del -= del1;
            del("Dusko Dugousko");
            Console.WriteLine("---");

            del -= del2;
            del += del1;
            del("Duck Daca");
            Console.WriteLine("---");
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Pozvan je metod KlasaA.MetodA() sa parametrom: Mickey Mouse
Mickey Mouse
Pozvan je metod KlasaB.MetodB() sa parametrom: Mickey Mouse
M
 i
  k
   i

     M
      a
       u
        s

Pozvan je metod KlasaB.MetodB() sa parametrom: Dusko Dugousko
D
 u
  s
   k
    o

      D
       u
        g
         o
          u
           s
            k
             o

Pozvan je metod KlasaA.MetodA() sa parametrom: Duck Daca
Duck DACA

 */