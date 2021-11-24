using System;

namespace RS2.SimpleProperty
{
    internal class Poruka
    {
        private string sadrzaj = "XXX";

        public string Sadrzaj
        {
            get { return sadrzaj; }
            set { sadrzaj = value; }
        }

        public void PrikazNaKonzolu()
        {
            Console.WriteLine(sadrzaj);
        }
    }
}