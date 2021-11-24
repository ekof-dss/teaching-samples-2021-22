namespace RS2.PropertyAbstract
{

    abstract class Oblik
    {
        public abstract double Povrsina
        {
            get;
            set;
        }
    }

    class Kvadrat : Oblik
    {
        private double ivica;

        public double Ivica
        {
            get { return ivica; }
        }

        public Kvadrat(double a)
        {
            ivica = a;
        }

        public override double Povrsina
        {
            get { return ivica * ivica; }
            set { ivica = System.Math.Sqrt(value); }
        }
    }

    class Kocka : Oblik
    {
        private double ivica;
        public double Ivica
        {
            get { return ivica; }
        }

        public Kocka(double a)
        {
            ivica = a;
        }

        public override double Povrsina
        {
            get { return 6 * ivica * ivica; }
            set { ivica = System.Math.Sqrt(value / 6); }
        }
    }

    class Program
    {
        static void Main()
        {
            System.Console.Write("Unesi duzinu ivice: ");
            double ivica = double.Parse(System.Console.ReadLine());

            Kvadrat kv = new Kvadrat(ivica);
            Kocka ko = new Kocka(ivica);

            System.Console.WriteLine("Povrsina kvadrata = {0:F2}", kv.Povrsina);
            System.Console.WriteLine("Povrsina kocke = {0:F2}", ko.Povrsina);
            System.Console.WriteLine();

            System.Console.Write("Unesi povrsinu: ");
            double povrsina = double.Parse(System.Console.ReadLine());

            kv.Povrsina = povrsina;
            ko.Povrsina = povrsina;

            System.Console.WriteLine("Ivica kvadrata = {0:F2}", kv.Ivica);
            System.Console.WriteLine("Ivica kocke = {0:F2}", ko.Ivica);
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Unesi duzinu ivice: 4
Povrsina kvadrata = 16.00
Povrsina kocke = 96.00

Unesi povrsinu: 64
Ivica kvadrata = 8.00
Ivica kocke = 3.27
*/

