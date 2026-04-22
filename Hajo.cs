using System;
using System.Collections.Generic;
using System.Text;

namespace gyak9
{
    abstract class Hajo
    {
        public int ENI;
        public string Nev;
        public string Tipus;
        public int Ar1;
        public int Ar2;
        public int Ar3;

        protected Hajo(int eni, string nev, string tipus, int ar1, int ar2, int ar3)
        {
            ENI = eni;
            Nev = nev;
            Tipus = tipus;
            Ar1 = ar1;
            Ar2 = ar2;
            Ar3 = ar3;
        }

        public override string ToString()
        {
            return $"ENI: {ENI}, név: {Nev} ms, besorolás: {Tipus} ";
        }
        public abstract int BerletiDij(int ora);

    }
}
