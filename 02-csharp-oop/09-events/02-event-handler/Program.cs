/*

.NET Framework includes built-in delegate types EventHandler for the most common events. 

Typically, any event should include two parameters: the source of the event and event data. 

Use the EventHandler delegate for all events that do not include event data. 

 */


using System;
using System.Threading;

namespace RS2.EventHandlerSample
{
    public class BusinessLogic
    {
        // deklarisanje dogadjaja
        public event EventHandler ProcesOkoncan;

        // metoda u okviru koje se ispaljuje dogadjaj
        public void StartProcess()
        {
            Console.WriteLine("BL: Metod je pokrenut!");
            // some code here..
            Console.WriteLine("BL: Simulacija izvrsavanja programskog koda!");
            Thread.Sleep(500);
            // potom se ispaljuje dogadjaj
            Console.WriteLine("BL: Ispali dogadjaj!");
            IspaliProcesOkoncan(EventArgs.Empty);
            // some code here..
            Console.WriteLine("BL: Simulacija izvrsavanja prograskog koda!");
            Thread.Sleep(500);
            Console.WriteLine("BL: Gotovo!");
        }

        // metod koji ispaljuje dogadjaj
        protected virtual void IspaliProcesOkoncan(EventArgs e)
        {
            if(ProcesOkoncan != null)
                ProcesOkoncan.Invoke(this, e);
        }
    }

    class Program
    {
        public static void Main()
        {
            BusinessLogic bl = new BusinessLogic();
            // registruj rukovaoca za dogadjaj
            bl.ProcesOkoncan += onProcessCompleted; 

            bl.StartProcess();
        }

        // rukovalac dogadjaja
        public static void onProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("EH: Process Completed!");
        }
    }

}


