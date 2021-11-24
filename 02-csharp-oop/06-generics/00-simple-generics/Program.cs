using System;

namespace RS2.SimpleGeneric
{
    public class SkladistePodataka<T>
    {
        private T[] podaci = new T[10];

        public void DodajIliAzuriraj(int index, T item)
        {
            if (index >= 0 && index < podaci.Length)
                podaci[index] = item;
        }

        public T Podatak(int index)
        {
            if (index >= 0 && index < podaci.Length)
                return podaci[index];
            else
                return default(T);
        }

        public void PrikaziNaKonzoli()
        {
            foreach (T elem in podaci)
                Console.WriteLine(elem);
        }
    }

    public class Program
    {
        static void Main()
        {
            SkladistePodataka<string> gradovi = new SkladistePodataka<string>();
            gradovi.DodajIliAzuriraj(0, "Bombaj");
            gradovi.DodajIliAzuriraj(1, "Cikago");
            gradovi.DodajIliAzuriraj(2, "London");
            gradovi.DodajIliAzuriraj(7, "Beograd");
            gradovi.PrikaziNaKonzoli();
            Console.WriteLine("---");

            SkladistePodataka<int> identifikatori = new SkladistePodataka<int>();
            identifikatori.DodajIliAzuriraj(0, 50);
            identifikatori.DodajIliAzuriraj(1, 65);
            identifikatori.DodajIliAzuriraj(2, 89);
            identifikatori.PrikaziNaKonzoli();
            Console.WriteLine();
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Bombaj
Cikago
London




Beograd


---
50
65
89
0
0
0
0
0
0
0

 */
