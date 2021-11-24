namespace DSS.ImplementsExplicit
{
    public interface IControl
    {
        void PrintIt();
    }

    public interface IArea
    {
        void Printit();
    }

    public class SomeClass : IControl, IArea
    {
        void IControl.PrintIt()
        {
            System.Console.WriteLine("IControl.PrintIt");
        }

        void IArea.Printit()
        {
            System.Console.WriteLine("IArea.PrintIt");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SomeClass sample = new SomeClass();
            IControl control = sample;
            IArea surface = sample;

            control.PrintIt();
            surface.Printit();
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
IKontrola.Iscrtaj
IPovrs.Iscrtaj 
 */
