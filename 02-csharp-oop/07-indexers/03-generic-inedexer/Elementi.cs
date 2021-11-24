using System;

namespace RS2.GenericIndexer
{
    class Elementi<T>
    {
        private T[] skladiste;

        public Elementi()
        {
            skladiste = new T[10];
        }

        public Elementi(int length)
        {
            skladiste = new T[length];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 && index >= skladiste.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return skladiste[index];
            }

            set
            {
                if (index < 0 || index >= skladiste.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                skladiste[index] = value;
            }
        }

        public int Dimenzija
        {
            get
            {
                return skladiste.Length;
            }
        }
    }
}
