
using System;
using System.Threading;

namespace RS2.LambdaEvent
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
                data.CompletionTime = DateTime.Now;
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
            bl.ProcessCompleted += (sender, ea) =>
            {
                Console.WriteLine("EH1: Process " + (ea.IsSuccessful ? "Completed Successfully" : "failed"));
                Console.WriteLine("EH1: Completion Time: " + ea.CompletionTime.ToLongDateString() + " "
                    + ea.CompletionTime.ToLongTimeString());
            };
            bl.ProcessCompleted += (_, ea) => Console.WriteLine("EH2: Jos jedna obrada istog dogadjaja ProcessCompleted.");
            bl.StartProcess();
        }

    }

}


