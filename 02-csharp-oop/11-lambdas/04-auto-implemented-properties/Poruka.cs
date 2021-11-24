using System;

namespace RS2.AutoImplementedProperties
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