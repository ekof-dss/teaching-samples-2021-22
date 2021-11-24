
using System;

namespace RS2.InterfaceImplementation
{
    public interface IKontrola
    {
        void Iscrtaj();
    }

    public interface IPovrs
    {
        void Iscrtaj();
    }
    
    public class NekaKlasa : IKontrola, IPovrs
    {
        // oba metoda interfejsa IPovrs.Iscrtaj i IKontrola.Iscrtaj su realizovana pomocu ovog metoda.
        public void Iscrtaj()
        {
            Console.WriteLine("Iscrtaj method in NekaKlasa");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            NekaKlasa sample = new NekaKlasa();
            IKontrola control = sample;
            IPovrs surface = sample;

            // The following lines all call the same method.
            sample.Iscrtaj();
            control.Iscrtaj();
            surface.Iscrtaj();

        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Iscrtaj method in NekaKlasa
Iscrtaj method in NekaKlasa
Iscrtaj method in NekaKlasa
 */
