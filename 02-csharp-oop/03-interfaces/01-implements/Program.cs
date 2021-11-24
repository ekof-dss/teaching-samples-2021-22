
using System;

namespace DSS.InterfaceImplementation
{
    public interface IControl
    {
        void PrintIt();
    }

    public interface IArea
    {
        void PrintIt();
    }
    
    public class SomeClass : IControl, IArea
    {
        // oba metoda interfejsa IPovrs.Iscrtaj i IKontrola.Iscrtaj su realizovana pomocu ovog metoda.
        public void PrintIt()
        {
            Console.WriteLine("Method PrintIt in SomeClass");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SomeClass sample = new SomeClass();
            IControl control = sample;
            IArea surface = sample;

            // The following lines all call the same method.
            sample.PrintIt();
            control.PrintIt();
            surface.PrintIt();

        }
    }
}
