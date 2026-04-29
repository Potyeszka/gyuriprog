using System;
using System.Collections.Generic;
using System.Text;

namespace gyak10
{
    internal class Manager : IDolgozo
    {
        public string Nev;
        public int Alapber;
        public int Bonusz;
    

        public Manager(string n, int a, int b)
        {
                Nev = n;
                Alapber = a;
                Bonusz = b;
        }


        public int Fizetes()
        {  
            return Alapber+Bonusz;
        }
    }
}
