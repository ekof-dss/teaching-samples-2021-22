using System;

namespace DSS.SimpleProperty
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