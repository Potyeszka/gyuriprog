using System;
using System.Collections.Generic;
using System.Text;

namespace gyak6
{
    internal class Jarmu
    {
        private int eni;
        private string nev;

        public int ENI
        {
            get { return eni; }
            set { eni = value; }
        }
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int? Epult;
        public bool? Aktiv;
        public int? Motorok;

        public double? TeljesitmenyKW;
        public double? TeljesitmenyLE;

        public double? Sebesseg;
        public int? MaxUtas;

        public Meretek Meret;
        public int? LeszerelesEve;
        public Tipus Tipus;

        public Jarmu(int eni, string nev)
        {
            ENI = eni;
            Nev = nev;
            Meret = new Meretek();
        }


        public void SzamolTeljesitmeny()
        {
            if (TeljesitmenyKW != null && TeljesitmenyLE == null)
            {
                TeljesitmenyLE = TeljesitmenyKW * 1.341;
            }
            if (TeljesitmenyKW == null && TeljesitmenyLE != null)
            {
                TeljesitmenyKW = TeljesitmenyLE / 1.341;
            }
        }

        public void Info()
        {
            Console.WriteLine($"{Nev} ({Tipus}) - ENI: {ENI}");
        }

        public override string ToString()
        {
            return
                $"Típus: {Tipus}\n" +
                $"ENI: {ENI}\n" +
                $"Név: {Nev}\n" +
                $"Épült: {Epult?.ToString() ?? "nincs adat"}\n" +
                $"Aktív: {(Aktiv == null ? "nincs adat" : (Aktiv.Value ? "igen" : "nem"))}\n" +
                $"Motorok száma: {Motorok?.ToString() ?? "nincs adat"}\n" +
                $"Teljesítmény: {TeljesitmenyKW?.ToString("0.00") ?? "?"} kW / " +
                $"{TeljesitmenyLE?.ToString("0.00") ?? "?"} LE\n" +
                $"Sebesség: {Sebesseg?.ToString() ?? "nincs adat"} km/h\n" +
                $"Max utas: {MaxUtas?.ToString() ?? "nincs adat"} fő\n" +
                $"Méretek:\n" +
                $"  - Legnagyobb hossz: {Meret.LegnagyobbHossz?.ToString() ?? "nincs adat"} m\n" +
                $"  - Hossz függély: {Meret.HosszFuggely?.ToString() ?? "nincs adat"} m\n" +
                $"  - Legnagyobb szélesség: {Meret.LegnagyobbSzelesseg?.ToString() ?? "nincs adat"} m\n" +
                $"  - Szélesség főbordán: {Meret.SzelessegFoborda?.ToString() ?? "nincs adat"} m\n" +
                $"  - Fixpont magasság: {Meret.FixpontMagassag?.ToString() ?? "nincs adat"} m\n" +
                $"  - Oldalmagasság: {Meret.OldalMagassag?.ToString() ?? "nincs adat"} m\n" +
                $"  - Legnagyobb merülés: {Meret.LegnagyobbMerules?.ToString() ?? "nincs adat"} m\n" +
                $"Leszerelés éve: {LeszerelesEve?.ToString() ?? "nincs"}";
        }

    }
}
