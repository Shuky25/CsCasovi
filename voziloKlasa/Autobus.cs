using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voziloKlasa
{
    internal class Autobus:Vozilo
    {
        private int brSedista;

        public Autobus(string model, string proizvodjac, string registracija, int god, int brSedista):base(model, proizvodjac, registracija, god)
        {
            this.brSedista = brSedista;
        }

        public override string Ispis()
        {
            string s = proizvodjac + " - " + model + "; Registracija: " + registracija + "; Godiste: " + god + "; Broj Sedista: " + brSedista + "\n";
            return s;
        }
    }
}
