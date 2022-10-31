using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voziloKlasa
{
    internal class Kamion:Vozilo
    {
        private double visina, tezina, tezinaTereta;

        public Kamion(string model, string proizvodjac, string registracija, int god, double visina, double tezina, double tezinaTereta):base(model, proizvodjac, registracija, god)
        {
            this.visina = visina;
            this.tezina = tezina;
            this.tezinaTereta = tezinaTereta;
        }

        public override string Ispis()
        {
            string s = proizvodjac + " - " + model + "; Registracija: " + registracija + "; Godiste: " + god + "; Visina: " + visina + "; Tezina: " + tezina + " tona; Tezina tereta: " + tezinaTereta + " tona;\n";
            return s;
        }
    }
}
