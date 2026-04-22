using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace gyak9
{
    internal class Flotta
    {
        public List<Hajo> hajok = new List<Hajo>();

        public void Beolvas(string fajl)
        {
            try
            {
                StreamReader sr = new StreamReader(fajl);
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] r = sor.Split(';');

                    int eni= int.Parse(r[0]);
                    string nev = r[1];
                    string tipus = r[2];
                    int ar1=int.Parse(r[3]);
                    int ar2=int.Parse(r[4]);
                    int ar3=int.Parse(r[5]);

                    Hajo h;
                    if (tipus == "személyhajó")
                    {
                        h = new Szemely(eni, nev, tipus, ar1, ar2, ar3);
                    }
                    else if (tipus == "nosztalgia")
                    {
                        h = new Nosztalgia(eni, nev, tipus, ar1, ar2, ar3);
                    }
                    else if (tipus == "katamaran" || tipus == "új katamarán")
                    {
                        h = new Katamaran(eni, nev, tipus, ar1, ar2, ar3);
                    }
                    else if (tipus == "komp" || tipus == "új komp")
                    {
                        h = new Komp(eni, nev, tipus, ar1, ar2, ar3);
                    }
                    else
                        throw new Exception("Ismeretlen hiba");

                    hajok.Add(h);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba " + ex.Message);
            }
        }


        public void Mutat()
        {
            foreach (var h in hajok)
            {
                Console.WriteLine(h);
            }
        }
    }
}
