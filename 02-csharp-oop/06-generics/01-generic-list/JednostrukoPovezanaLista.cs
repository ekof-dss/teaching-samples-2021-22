using System.Collections.Generic;

namespace RS2.GenericList
{
    // parameter tipa T je u uglastim zagradama
    public class JednostrukoPovezanaLista<T>
    {
        // ugnezdena klasa je takodje genericka, sa parametrom tipa T.
        private class CvorListe
        {
            // ovde je privatno polje tipa T 
            private T podatak;
            private CvorListe sledeci;

            // ovde se parametar tipa T koristi u negenerickom konstruktoru
            public CvorListe(T t)
            {
                sledeci = null;
                podatak = t;
            }

            public CvorListe Sledeci
            {
                get { return sledeci; }
                set { sledeci = value; }
            }

 
            // ovde metod kao rezultat vrace tip T
            public T Podatak
            {
                get { return podatak; }
                set { podatak = value; }
            }
        }

        private CvorListe glava;

        // konstruktor liste
        public JednostrukoPovezanaLista()
        {
            glava = null;
        }

        // ovde je parametar metoda tipa T
        public void DodajNaPocetak(T t)
        {
            CvorListe n = new CvorListe(t);
            n.Sledeci = glava;
            glava = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            CvorListe current = glava;
            while (current != null)
            {
                yield return current.Podatak;
                current = current.Sledeci;
            }
        }
    }

}