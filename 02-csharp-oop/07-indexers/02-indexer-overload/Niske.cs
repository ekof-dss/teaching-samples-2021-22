
using System;

namespace RS2.IndexerOverload
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

        // indeksiranje celim brojem
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= skladiste.Length)
                    throw new IndeksVanOpsegaException(index, skladiste);
                return skladiste[index];
            }

            set
            {
                if (index < 0 || index >= skladiste.Length)
                    throw new IndeksVanOpsegaException(index, skladiste);
                skladiste[index] = value;
            }
        }

        // indeksiranje niskom - asocijativno case insensitive
        public string this[string name]
        {
            get
            {
                foreach (string str in skladiste)
                {
                    if (str != null)
                        if (str.ToLower() == name.ToLower())
                            return str;
                }
                return null;
            }
        }

        public int Dimenzija
        {
            get { return skladiste.Length; }
        }
    }
}
