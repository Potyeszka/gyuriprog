using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.WebSockets;
using System.Text;

namespace gyak6
{
    internal class Flotta
    {
        public Jarmu[] Jarmuvek;

        private double? ParseDouble(string s) => s == "" ? null : double.Parse(s,CultureInfo.InvariantCulture);
        private int? ParseInt(string s) => s == "" ? null : int.Parse(s);
        private bool? ParseBool(string s) => s == "" ? null : bool.Parse(s);

        public void Beolvas(string fajl)
        {
            try
            {
                Jarmuvek = new Jarmu[File.ReadAllLines(fajl).Length-1];
                int index = 0;
                StreamReader sr=new StreamReader(fajl);
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string sor=sr.ReadLine();
                    string[] r = sor.Split(';');

                    Jarmu j = new Jarmu(int.Parse(r[0]), r[1]);

                    j.Epult=ParseInt(r[2]);
                    j.Aktiv = ParseBool(r[3]);
                    j.Motorok = ParseInt(r[4]);

                    j.TeljesitmenyKW=ParseDouble(r[5]);
                    j.TeljesitmenyLE=ParseDouble(r[6]);

                    j.Sebesseg = ParseDouble(r[7]);
                    j.MaxUtas= ParseInt(r[8]);

                    j.Meret = new Meretek(
                        ParseDouble(r[9]),
                        ParseDouble(r[10]),
                        ParseDouble(r[11]),
                        ParseDouble(r[12]),
                        ParseDouble(r[13]),
                        ParseDouble(r[14]),
                        ParseDouble(r[15])
                        );


                    j.LeszerelesEve=ParseInt(r[16]);
                    j.SzamolTeljesitmeny();
                    Jarmuvek[index++] = j;
                }sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba: " + ex.Message);
            }
        }
    }
}
