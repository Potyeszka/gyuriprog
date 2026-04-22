using System;
using System.Collections.Generic;
using System.Text;

namespace gyak9_2
{
    internal class Haromszog : Sokszog
    {
        public Haromszog(int oldalakSzama) : base(oldalakSzama)
        {
            bool jo;
            do
            {
                jo = true;
                for (int i = 0; i < oldalakSzama; i++)
                {
                    Console.WriteLine($"Add meg a(z) {i+1}. oldlat:");
                    oldalak[i]=double.Parse(Console.ReadLine());
                }
                if (oldalak[0] >= oldalak[1]+oldalak[2] || oldalak[1] >= oldalak[0] + oldalak[2]|| oldalak[2] >= oldalak[1] + oldalak[0])
                {
                    jo = false;
                    Console.WriteLine("Hibás érték!");
                }
            }while(!jo);
        }


        public override double Terulet()
        {
            double s = Kerulet() / 2;
            return Math.Sqrt(s * (s - oldalak[0]) * (s - oldalak[1])  + (s - oldalak[2]));
        }
    }
}
