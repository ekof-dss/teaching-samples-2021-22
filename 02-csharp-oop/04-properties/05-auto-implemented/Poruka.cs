using System;

namespace RS2.SimpleProperty
{
    internal class Poruka
    {
        public string Sadrzaj
        {
            get;
            set;
        }

        public void PrikazNaKonzolu()
        {
            Console.WriteLine(Sadrzaj);
        }
    }
}