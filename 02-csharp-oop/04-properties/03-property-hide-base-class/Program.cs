namespace RS2.PropertyHiding
{

    public class Zaposleni
    {
        private string imePrezime;

        public string ImePrezime
        {
            get { return imePrezime; }
            set { imePrezime = value; }
        }
    }

    public class Direktor : Zaposleni
    {
        private string imePrezime;

        // Notice the use of the new modifier:
        public new string ImePrezime
        {
            get { return imePrezime; }
            set { imePrezime = "direktor " + value; }
        }
    }

    class Program
    {
        static void Main()
        {
            Direktor d1 = new Direktor();

            // Derived class property.
            d1.ImePrezime = "Srećko Šojić";

            // Base class property.
            ((Zaposleni)d1).ImePrezime = "Dimitrije Pantić";

            System.Console.WriteLine("Ime u izvedenoj klasi: {0}", d1.ImePrezime);
            System.Console.WriteLine("Ime u nadklasi: {0}", ((Zaposleni)d1).ImePrezime);
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Ime u izvedenoj klasi: direktor Srecko Sojic
Ime u nadklasi: Dimitrije Pantic

*/

