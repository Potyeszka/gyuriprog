namespace gyak9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a fájl elérését");
            string fajl = Console.ReadLine();
            Flotta f = new Flotta();
            f.Beolvas(fajl);
            f.Mutat();




        }
    }
}
