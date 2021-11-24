namespace RS2.LambdaIndexer
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

        public string this[int index]
        {
            get => skladiste[index];

            set => skladiste[index] = value;
        }

        public int Dimenzija { 
            get { return skladiste.Length; } 
        }
    }
}
