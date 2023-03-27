using _20230327_ss_cs;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static List<Vilagbajnoksag> Vilagb_List = new List<Vilagbajnoksag>();
        static void Main(string[] args)
        {
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat78();
            Feladat9();
        }

        private static void Feladat9()
        {
            
        }

        private static void Feladat78()
        {
            Console.Write("Adjon meg egy város nevet: ");
            string bekert = Console.ReadLine();
            foreach (var v in Vilagb_List)
            {
                if (bekert.Length < 3)
                {
                    Console.WriteLine("Nem jó");
                    break;
                }
                if (bekert == v.Varos)
                {
                    Console.WriteLine("A megadott város VB helyszín");
                    break;
                }
                else
                {
                    Console.WriteLine("A megadott város nem VB helyszín");
                    break;
                }
            }
        }

        private static void Feladat6()
        {
            int darab_nev = 0;
            foreach (var v in Vilagb_List)
            {
                if (v.Nev_2 == "n.a.")
                {
                    darab_nev++;
                }
            }
            Console.WriteLine($"Ennyi stadion rendelkezik alternatív névvel: {darab_nev}");
        }

        private static void Feladat5()
        {
            double Osszeg = 0;
            foreach (var v in Vilagb_List)
            {
                Osszeg += v.Ferohely;
            }
            double atlag = Osszeg / 12;
            Console.WriteLine($"Össz átlag férőhelyszám: {atlag:0.0}");
        }

        private static void Feladat4()
        {
            int max = int.MaxValue;
            string nev = "ok";
            string nev2 = "ok";
            string varos = "ok";
            foreach (var v in Vilagb_List)
            {
                if (max > v.Ferohely)
                {
                    max = v.Ferohely;
                    nev = v.Nev;
                    nev2 = v.Nev_2;
                    varos = v.Varos;
                }
            }
            Console.WriteLine($"{nev}, {nev2}, {varos}, {max}");
        }

        private static void Feladat3()
        {
            Console.WriteLine($"Beolvasott sorok száma: {Vilagb_List.Count}");
        }

        private static void Feladat2()
        {
            var sr = new StreamReader(@"vb2018.txt", Encoding.UTF8);
            string sor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                Vilagb_List.Add(new Vilagbajnoksag(sor));
            }
            sr.Close();
        }
    }
}