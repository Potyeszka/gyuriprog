using System;
using System.Collections.Generic;
using System.Text;

namespace gyak9_2
{
    internal class Teglalap : Sokszog
    {
        public Teglalap(int oldalakSzama) : base(oldalakSzama)
        {
            bool jo;
            do
            {
                jo = true;
                Console.WriteLine("Add meg a téglalap hosszabb oldalát:");
                oldalak[0] = oldalak[2] = double.Parse(Console.ReadLine());
                Console.WriteLine("Add meg a téglalap rövidebb oldalát:");
                oldalak[1] = oldalak[3] = double.Parse(Console.ReadLine());

                if (oldalak[0]<=0 || oldalak[1]<=0)
                {
                    Console.WriteLine("Hiábás érték, nem lehet sem, nulla sem pedig negatív");
                    jo = false;
                }
            } while (!jo);
        }


        public override double Terulet()
        {
            return oldalak[0] * oldalak[1];
        }
    }
}
