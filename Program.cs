namespace gyak9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teglalap T = new Teglalap(4);
            Console.WriteLine($"A téglalap kerülete: {T.Kerulet()}");
            Console.WriteLine($"A téglalap területe: {T.Terulet()}");
            Haromszog H = new Haromszog(3);
            Console.WriteLine($"A háromszög kerülete: {H.Kerulet()}");
            Console.WriteLine($"A háromszög területe: {H.Terulet()}");
        }
    }
}
