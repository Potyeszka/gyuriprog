using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace gyak10
{
    internal class Szogyak
    {
        public static Dictionary<string, int> Szotar(string szoveg)
        {
            Dictionary<string, int> szotar = new Dictionary<string, int>();
            string[] szavak = szoveg.ToLower().Split(' ');

            foreach (string s in szavak)
            {
                if (szotar.ContainsKey(s))
                {
                    szotar[s]++;
                }
                else
                {
                    szotar[s] = 1;
                }
            }

            return szotar;
        }
    }
}
