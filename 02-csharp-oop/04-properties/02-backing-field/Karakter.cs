using System.Text;

namespace RS2.PropertyBackingField
{
    internal class Karakter
    {
        private string ime;
        private string prezime;

        public Karakter(string ime = "XXX", string prezime = "XXX")
        {
            this.ime = ime;
            this.prezime = prezime;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string PunoIme
        {
            get { return ime + " " + prezime; }
            set { 
                string[] sekvenca = value.Split(" ".ToCharArray());
                if( sekvenca.Length == 1){
                    ime = "XXX";
                    prezime = sekvenca[0];
                }
                else if(sekvenca.Length == 2)
                {
                    ime = sekvenca[0];
                    prezime = sekvenca[1];
                }
                else
                {
                    StringBuilder sb = new StringBuilder("");
                    for (int i = 0; i < sekvenca.Length-1; i++)
                        sb.Append(sekvenca[i] + " ");
                    ime = sb.ToString().TrimEnd();
                    prezime = sekvenca[sekvenca.Length - 1];
                }
            }
        }

    }
}