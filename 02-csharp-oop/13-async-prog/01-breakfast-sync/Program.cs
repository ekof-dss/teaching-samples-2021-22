
using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace RS2.BreakfastSync
{
    class Program
    {
        private static OranzDjus SipajOranzDjus()
        {
            Console.WriteLine(">>>Priprema oranz djusa: sipanje.");
            return new OranzDjus();
        }

        private static void NamaziDzem(Tost tost) =>
            Console.WriteLine(">>>Mazanje dzemom: dzem se stavlja na tost.");

        private static void NamaziPuter(Tost tost) =>
            Console.WriteLine(">>>Mazanje puterom: puter se stavlja na tost.");

        private static Tost IspeciTostHleb(int brojKriski)
        {
            for (int kriska = 0; kriska < brojKriski; kriska++)
            {
                Console.WriteLine(">>>Pecenje tost hleba: stavlja se kriska hleba u toster.");
            }
            Console.WriteLine(">>>Pecenje tost hleba: pocinje hleb da se pece...");
            Task.Delay(3000).Wait();
            Console.WriteLine(">>>Pecenje tost hleba: uklanjaju se ispecene kriske hleba iz tostera.");
            return new Tost();
        }

        private static Slanina IsprziSlaninu(int brojParcica)
        {
            Console.WriteLine($">>>Przenje slanine: postavljanje {brojParcica} parcica slanine u tiganj.");
            Console.WriteLine(">>>Przenje slanine: przenje jedne strane slanine...");
            Task.Delay(3000).Wait();
            for (int parce = 0; parce < brojParcica; parce++)
            {
                Console.WriteLine(">>>Przenje slanine: okretanje jednog parceta slanine");
            }
            Console.WriteLine(">>>Przenje slanine: przenje druge strane slanine......");
            Task.Delay(3000).Wait();
            Console.WriteLine(">>>Przenje slanine: postavljanje isprzene slanine u tanjir");
            return new Slanina();
        }

        private static Jaje IsprziJaja(int koliko)
        {
            Console.WriteLine(">>>Przenje jaja: zagrejavanje tiganja za przenje jaja...");
            Task.Delay(3000).Wait();
            Console.WriteLine($">>>Przenje jaja: lupanje {koliko} jaja.");
            Console.WriteLine(">>>Przenje jaja: przenje jaja...");
            Task.Delay(3000).Wait();
            Console.WriteLine(">>>Przenje jaja: stavljanje jaja na tanjir.");
            return new Jaje();
        }

        private static Kafa SipajEkspresKafu()
        {
            Console.WriteLine(">>>Sipanje kafe: uspi kafu.");
            return new Kafa();
        }

        static void Main(string[] args)
        {
            var stoperica = Stopwatch.StartNew();

            Kafa soljaKafe = SipajEkspresKafu();
            Console.WriteLine("{0} ms: kafa je pripremljena.", stoperica.ElapsedMilliseconds);

            Jaje jaja = IsprziJaja(2);
            Console.WriteLine("{0} ms: jaja su pripremljena.", stoperica.ElapsedMilliseconds);

            Slanina slanina = IsprziSlaninu(3);
            Console.WriteLine("{0} ms: slanina je pripremljena.", stoperica.ElapsedMilliseconds);

            Tost tost = IspeciTostHleb(2);
            NamaziPuter(tost);
            NamaziDzem(tost);
            Console.WriteLine("{0} ms: tost je pripremljen.", stoperica.ElapsedMilliseconds);

            OranzDjus oranzDjus = SipajOranzDjus();
            Console.WriteLine("{0} ms: oranz djus je pripremljen.", stoperica.ElapsedMilliseconds);
            Console.WriteLine("{0} ms: dorucak je spreman!", stoperica.ElapsedMilliseconds);
        }
    }
}

/*  Izlaz dobijen prilikom izvrsavanja programa:
>>>Sipanje kafe: uspi kafu.
19 ms: kafa je pripremljena.
>>>Przenje jaja: zagrejavanje tanjira za przenje jaja...
>>>Przenje jaja: lupanje 2 jaja.
>>>Przenje jaja: przenje jaja...
>>>Przenje jaja: stavljanje jaja na tanjir.
6110 ms: jaja su pripremljena.
>>>Przenje slanine: postavljanje 3 parcica slanine u tiganj.
>>>Przenje slanine: przenje jedne strane slanine...
>>>Przenje slanine: okretanje jednog parceta slanine
>>>Przenje slanine: okretanje jednog parceta slanine
>>>Przenje slanine: okretanje jednog parceta slanine
>>>Przenje slanine: przenje druge strane slanine......
>>>Przenje slanine: postavljanje ispryene slanine u tanjir
12141 ms: slanina je pripremljena.
>>>Pecenje tost hleba: stavlja se kriska helba u toster.
>>>Pecenje tost hleba: stavlja se kriska helba u toster.
>>>Pecenje tost hleba: pocinje thleb da se pece...
>>>Pecenje tost hleba: uklanjaju se ispecene kriske hleba iz tostera.
>>>Mazanje puterom: puter se stavlja na tost.
>>>Mazanje dzemom: dzem se stavlja na tost.
15147 ms: tost je pripremljen.
>>>Priprema oranz djusa: sipanje.
15147 ms: oranz djus je pripremljen.
15147 ms: dorucak je spreman!
 */


