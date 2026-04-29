using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace gyak10
{
    internal class Alkalmazott : IDolgozo
    {
        public string Nev;
        public int Alapber;

        public Alkalmazott(string n, int Alapber)
        {
            Nev = n;
            this.Alapber = Alapber;
        }


        public int Fizetes()
        {
            return Alapber;
        }
    }
}
