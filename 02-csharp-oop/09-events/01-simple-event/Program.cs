/*

Dogadjaj je informacija tj, notifikacija koju salje objekat da bi njom signalizirao da se dogodila neka akcija. 

Kod .NET, dogadjaji su realizovani preko obrasaca dizajna "posmatrac" (observer). Klasa koja ispaljuje dogadjaje se naziva 
"izdavac" (publisher), a klasa koja prima notifikaciju se naziva "pretplatnik" (subscriber). 

Moguce je da se vise razlicitih pretplatnika preplacuje na jedan dogadjaj. 

Uobicajeni scenario je da izdavac ispali dogadjaj kada se dogodi neka akcija. Pretplatnici koji su zainteresovani za dobijanje
notifikacije kada se dogodi ta akcija treba da se registuju tj. pretplate na taj dogadjaj. Prilikom registracije, pretplatnik 
specificira kako ce odgovoriti u slucaju nastupanja dogadjaja tj. specificira "rukovaoca" (handler) ya dati dogadjaj. 

U jeziku C#, dogadjaj je realizovan kao enkapsulacija delegata i on zavisi od delegata. Preciznije, preko delegata se definse
potpis za rukovaoca dogadjaja kod pretplatnika.

 */


using System;
using System.Threading;

namespace RS2.SimpleEvent
{
    // delegat preko kog ide komunikacija
    public delegate void Obavesti();  
        
    public class PoslovnaLogika
    {
        // deklarisanje dogadjaja
        public event Obavesti ProcesZavrsen;

        // metoda u okviru koje se ispaljuje dogadjaj
        public void PokreniProces()
        {
            Console.WriteLine("PL> Metod je pokrenut!");
            // some code here..
            Console.WriteLine("PL> Simulacija izvrsvanja prograskog koda!");
            Thread.Sleep(500);
            // potom se ispaljuje dogadjaj
            Console.WriteLine("PL> Ispali dogadjaj!");
            IspaliProcesZavrsen();
            // some code here..
            Console.WriteLine("PL> Simulacija izvrsvanja prograskog koda!");
            Thread.Sleep(500);
            Console.WriteLine("PL> Gotovo!");
        }

        // metod koji ispaljuje dogadjaj
        protected virtual void IspaliProcesZavrsen() //protected virtual method
        {
            // ako dogadjaj nije null, pokreni delegat
            if( ProcesZavrsen != null) 
                ProcesZavrsen.Invoke();
        }
    }

    // rukovalac dogadjajem
    public static class PretplatnikProcesZavrsen 
    {
        // event handler
        public static void onProcesZavrsen()
        {
            Console.WriteLine("PZ> Proces je zavrsen!");
        }
    }

    class Program
    {
        static void onProcesZavrsen2()
        {
            Console.WriteLine("PZ2> Proces je zavrsen!");
        }

        public static void Main()
        {
            PoslovnaLogika app = new PoslovnaLogika();
            // registruj rukovaoce za dogadjaj
            app.ProcesZavrsen += PretplatnikProcesZavrsen.onProcesZavrsen;
            app.ProcesZavrsen += onProcesZavrsen2;
            
            app.PokreniProces();
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
PL> Metod je pokrenut!
PL> Simulacija izvrsvanja prograskog koda!
PL> Ispali dogadjaj!
PZ> Proces je zavrsen!
PZ2> Proces je zavrsen!
PL> Simulacija izvrsvanja prograskog koda!
PL> Gotovo!
 */

