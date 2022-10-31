using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voziloKlasa
{
    internal class Automobil:Vozilo
    {
        private int brVrata;

        public Automobil(string model, string proizvodjac, string registracija, int god, int brVrata):base(model, proizvodjac, registracija, god)
        {
            this.brVrata = brVrata;
        }

        public override string Ispis()
        {
            string s = proizvodjac + " - " + model + "; Registracija: " + registracija + "; Godiste: " + god + "; " + "; Broj vrata: " + brVrata + "\n";
            return s;
        }
    }
}
