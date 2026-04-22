using System;
using System.Collections.Generic;
using System.Text;

namespace gyak9
{
    internal class Szemely : Hajo
    {
        public Szemely(int eni, string nev, string tipus, int ar1, int ar2, int ar3) : base(eni, nev, tipus, ar1, ar2, ar3)
        {

        }

        public override int BerletiDij(int ora)
        {
            if (ora == 1) return Ar1;
            else if (ora == 2) return Ar2 * ora;
            else return Ar3 * ora;
        }

    }
}
