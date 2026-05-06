namespace gyak11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Konyvtar k = new Konyvtar();
            Console.WriteLine("Fájl beolvasása:");
            k.Beolvas("dokumentumok.txt");
            Console.WriteLine("Listaz metodus: ");
            k.Listaz();
            Console.WriteLine("Átlagár metódus: ");
            k.AtlagAr();
            Console.WriteLine("Legdragabb metodus: ");
            k.Legdragabb();
            Console.WriteLine("");
            //...... így folytatni tovább


        }
    }
}
