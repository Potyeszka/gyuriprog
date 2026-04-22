using System;
using System.Collections.Generic;
using System.Text;

namespace gyak9_2
{
    abstract class Sokszog
    {
        protected double[] oldalak;

        protected Sokszog(int oldalakszama)
        {
            oldalak = new double[oldalakszama];
        }


        public virtual double Kerulet()
        {
            double K = 0;
            for (int i = 0; i < oldalak.Length; i++)
            {
                K += oldalak[i];
            } return K;
        }

        public abstract double Terulet();
        

    }
}
