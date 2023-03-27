using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230327_ss_cs
{
    internal class Vilagbajnoksag
    {
        public string Varos;
        public string Nev;
        public string Nev_2;
        public int Ferohely;

        public Vilagbajnoksag (string sor)
        {
            var db = sor.Split(";");
            this.Varos = db[0];
            this.Nev = db[1];
            this.Nev_2 = db[2];
            this.Ferohely = int.Parse(db[3]);
        }
    }
}
