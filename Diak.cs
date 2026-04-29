using System;
using System.Collections.Generic;
using System.Text;

namespace gyak10
{
    internal class Diak : IComparable<Diak>
    {
        public string Nev;
        public int Jegy;

        public Diak(string nev, int jegy)
        {
            Nev = nev;
            Jegy = jegy;
        }

        public int CompareTo(Diak? other)
        {
            bool novekvo = true;
            bool jegy = true;

            if (jegy == true)
            {

                if (other == null) return 1;
                if (novekvo)
                {
                    return Jegy.CompareTo(other.Jegy);
                }
                else
                {
                    return other.Jegy.CompareTo(Jegy);
                }
            }
            else
            {
                if (other == null) return 1;
                if (novekvo)
                {
                    return Nev.CompareTo(other.Nev);
                }
                else
                {
                    return other.Nev.CompareTo(Nev);
                }
            }
        }



    }
}
