using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voziloKlasa
{
    abstract public class Vozilo
    {
        protected string model, proizvodjac, registracija;
        protected int god;

        public Vozilo(string model, string proizvodjac, string registracija, int god)
        {
            this.model = model;
            this.proizvodjac = proizvodjac;
            this.registracija = registracija;
            this.god = god;
        }

        public bool StarijeOd(Vozilo V)
        {
            return god < V.god;
        }

        public abstract string Ispis();
    }
}
