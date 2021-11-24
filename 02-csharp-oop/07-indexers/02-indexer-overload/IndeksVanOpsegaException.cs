using System;
using System.Collections.Generic;
using System.Text;

namespace RS2.IndexerOverload
{
    public class IndeksVanOpsegaException: Exception
    {
        private int indeks;
        private string[] skladiste;

        public IndeksVanOpsegaException(int indeks, string[] skladiste): base()
        {
            this.indeks = indeks;
            this.skladiste = skladiste;
        }
    }
}
