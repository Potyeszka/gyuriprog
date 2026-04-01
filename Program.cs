namespace gyak6
{

    enum Tipus
    {
        Katamaran, Szemely, Komp, Egyeb
    }

    struct Meretek
    {
        public double? LegnagyobbHossz;
        public double? HosszFuggely;
        public double? LegnagyobbSzelesseg;
        public double? SzelessegFoborda;
        public double? FixpontMagassag;
        public double? OldalMagassag;
        public double? LegnagyobbMerules;

        public Meretek(double? lh, double? hf, double? lsz, double? szf, double? fm, double? om, double? lm)
        {
            LegnagyobbHossz = lh;
            HosszFuggely = hf;
            LegnagyobbSzelesseg = lsz;
            SzelessegFoborda = szf;
            FixpontMagassag = fm;
            OldalMagassag = om;
            LegnagyobbMerules = lm;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Flotta f = new Flotta();
            f.Beolvas("hajok.csv");
            foreach (var j in f.Jarmuvek)
                j.Info();

            foreach (var j in f.Jarmuvek)
                Console.WriteLine(j);

            

        }
    }
}
