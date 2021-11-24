
using System;

namespace RS2.SimpleIndexer
{
    class Niske
    {
        private string[] skladiste;

        public Niske()
        {
            skladiste = new string[10];
        }

        public Niske(int dimenzija)
        {
            skladiste = new string[dimenzija];
        }

        public string this[int index]
        {
            get
            {
                if (index < 0)
                    index = -index;
                index = index % Dimenzija;
                return skladiste[index];
            }

            set
            {
                if (index < 0)
                    index = -index;
                index = index % Dimenzija;
                skladiste[index] = value;
            }
        }
        public int Dimenzija
        {
            get { return skladiste.Length; }

            set { 
                string[] novoSkladiste = new string[value];
                int zaPrepis = (skladiste.Length < novoSkladiste.Length) ? skladiste.Length : novoSkladiste.Length;
                for (int i = 0; i < zaPrepis; i++)
                    novoSkladiste[i] = skladiste[i];
                skladiste = novoSkladiste;
            }
        }
    }
}
