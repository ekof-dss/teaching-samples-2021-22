namespace RS2.ImplementsExplicit
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
        void IKontrola.Iscrtaj()
        {
            System.Console.WriteLine("IKontrola.Iscrtaj");
        }

        void IPovrs.Iscrtaj()
        {
            System.Console.WriteLine("IPovrs.Iscrtaj");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            NekaKlasa sample = new NekaKlasa();
            IKontrola control = sample;
            IPovrs surface = sample;

            control.Iscrtaj();
            surface.Iscrtaj();
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
IKontrola.Iscrtaj
IPovrs.Iscrtaj 
 */
