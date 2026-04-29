namespace gyak10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDolgozo> dolgozok = new()
            {
                new Alkalmazott("Kis Pista" , 250000),
                new Manager("Nagy Pista", 350000,150000)
            };

            foreach(var d in dolgozok)
                Console.WriteLine($"{d.GetType().Name}: {d.Fizetes()} Ft");



            List<Diak> diakok = new()
            {
                new Diak("Anna", 4),
                new Diak("Máté", 3),
                new Diak("Pista", 5)
            };


            Console.WriteLine("Rendezés előtt");
            foreach(var d in diakok)
            {
                Console.WriteLine($"{d.Nev}: {d.Jegy}");
            }
            Console.WriteLine();

            diakok.Sort();

            Console.WriteLine("Rendezés előtt");
            foreach (var d in diakok)
            {
                Console.WriteLine($"{d.Nev}: {d.Jegy}");
            }
            Console.WriteLine();



            var sor = new FIFO<string>();
            sor.Hozzad("Progamozás II.");
            sor.Hozzad("Villamosségtan");
            sor.Hozzad("Fizika");
            sor.Hozzad("Prog.Szigorlat");
            Console.WriteLine("Következő: " +sor.Leker());
            Console.WriteLine("Törölve: " + sor.Torol());
            Console.WriteLine("Következő: " + sor.Leker());
            Console.WriteLine("Törölve: " + sor.Torol());
            Console.WriteLine("Következő: " + sor.Leker());
            Console.WriteLine();

            string szoveg = "alma körte alma alma banán körte citrom áfonya dinnye";
            var szotar = Szogyak.Szotar(szoveg);
            foreach(var s in szotar)
            {
                Console.WriteLine($"{s.Key}: {s.Value} db");
            }
            Console.WriteLine();



            List<int> l1 = new List<int> { 1, 1, 2, 3, 4 }; 
            List<int> l2 = new List<int> { 2, 3, 4, 5, 6 }; 
            var metszet = Halmazok.Metszet(l1, l2);
            var unio = Halmazok.Unio(l1, l2);

            Console.WriteLine("Metszet");
            foreach(var m in metszet)
            {
                Console.WriteLine(m+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Unio");
            foreach(var m in unio)
            {
                Console.WriteLine(m+" ");
            }
            Console.WriteLine();
        }
    }
}
