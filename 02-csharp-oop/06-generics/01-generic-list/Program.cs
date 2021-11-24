using System;

namespace RS2.GenericList
{
    public class Program
    {
        static void Main()
        {
            // ovde int predstavlja argument tipa
            JednostrukoPovezanaLista<int> list = new JednostrukoPovezanaLista<int>();
            for (int x = 0; x < 5; x++)
            {
                list.DodajNaPocetak(x);
            }
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("---");
            

            // ovde je Poruka argument tipa
            JednostrukoPovezanaLista<Poruka> list2 = new JednostrukoPovezanaLista<Poruka>();
            for (int x = 0; x < 5; x++)
            {
                list2.DodajNaPocetak(new Poruka
                {
                    Sadrzaj = "Broj" + x,
                    BrojPonavljanja = 1
                });
            }
            foreach (Poruka p in list2)
            {
                p.PrikazNaKonzolu();
            }
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
4 3 2 1 0 ---
Broj4
---
---
Broj3
---
---
Broj2
---
---
Broj1
---
---
Broj0
---

 */
