/*

Most events send some data to the subscribers. The EventArgs class is the base class for all the event data classes. 
.NET includes many built-in event data classes such as SerialDataReceivedEventArgs. 
It follows a naming pattern of ending all event data classes with EventArgs. 

You can create your custom class for event data by deriving EventArgs class. In that case, use EventHandler<TEventArgs> to pass 
data to the handler.

 */


using System;
using System.Threading;

namespace RS2.PassEventData
{
    // podaci koji se prosledjuju uz dogadjaj
    public class ProcessEventArgs : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }

    public class BusinessLogic
    {
        // deklarisanje dogadjaja
        public event EventHandler<ProcessEventArgs> ProcessCompleted;

        // metoda u okviru koje se ispaljuje dogadjaj
        public void StartProcess()
        {
            var data = new ProcessEventArgs();
            try
            {
                Console.WriteLine("BL: Metod je pokrenut!");
                // some code here..
                Console.WriteLine("BL: Simulacija izvrsvanja prograskog koda!");
                Thread.Sleep(500);
                // potom se ispaljuje dogadjaj
                Console.WriteLine("BL: Ispali dogadjaj!");
                data.IsSuccessful = true;
                data.CompletionTime = DateTime.Now.AddMinutes(5);
                FireProcessCompleted(data);
                // some code here..
                Console.WriteLine("BL: Simulacija izvrsvanja prograskog koda!");
                Thread.Sleep(500);
                Console.WriteLine("BL: Gotovo!");
            }
            catch (Exception ex)
            {
                data.IsSuccessful = false;
                data.CompletionTime = DateTime.Now;
                FireProcessCompleted(data);
            }
        }

        // metod koji ispaljuje dogadjaj
        protected virtual void FireProcessCompleted(ProcessEventArgs e)
        {
            if (ProcessCompleted != null)
                ProcessCompleted.Invoke(this, e);
        }
    }

    class Program
    {
        public static void Main()
        {
            BusinessLogic bl = new BusinessLogic();
            // registruj rukovaoca za dogadjaj
            bl.ProcessCompleted += onProcessCompleted;

            bl.StartProcess();
        }

        // rukovalac dogadjaja
        public static void onProcessCompleted(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("EH: Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
            Console.WriteLine("EH: Completion Time: " + e.CompletionTime.ToLongDateString() + " "
                + e.CompletionTime.ToLongTimeString());
        }
    }

}


