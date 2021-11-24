using System;

namespace DSS.AutoImplementedProperties
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