using System;
using System.Collections.Generic;
using System.Text;

namespace gyak11
{
    internal class Konyv : Dokumentum
    {
        public Konyv(int a, string b, string c, int d, int e, int f) : base(a, b, c, d, e, f)
        { }

        public override int KezelesiTerheles()
        {
            return KolcsonzesiIdo * Darab;
        }

        public int CompareTO(Dokumentum? other)
        {
            if(other == null) return 1;
            return other.Ar.CompareTo(this.Ar);
        }
    }
}
