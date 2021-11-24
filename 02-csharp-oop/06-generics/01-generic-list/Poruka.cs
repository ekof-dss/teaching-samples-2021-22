using System;

namespace RS2.GenericList
{
    internal class Poruka
    {
        public byte BrojPonavljanja { get; set; }

        public string Sadrzaj { get; set; }

        public void PrikazNaKonzolu()
        {
            for(int i=0; i<BrojPonavljanja; i++)
                Console.WriteLine( "---" + Sadrzaj);
        }
    }
}