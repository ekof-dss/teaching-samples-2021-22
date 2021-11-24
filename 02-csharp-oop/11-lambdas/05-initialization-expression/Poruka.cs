using System;

namespace DSS.InitializationExpression
{
    internal class Poruka
    {
        public byte BrojPonavljanja{
            get;
            set;
        }
        
        public string Sadrzaj {
            get;
            set;
        }

        public void PrikazNaKonzolu()
        {
            Console.WriteLine("---");
            for(int i=0; i<BrojPonavljanja; i++)
                Console.WriteLine(Sadrzaj);
            Console.WriteLine("---");
        }
    }
}