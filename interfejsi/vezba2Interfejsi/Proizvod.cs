using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezba2Interfejsi
{
    internal class Proizvod : IComparable
    {
        #region atributi
        private string naziv, proizvodjac;
        private double cena;
        #endregion

        public Proizvod(string naziv, string proizvodjac, double cena)
        {
            if (naziv.Equals(string.Empty))
                throw new Exception("Nema naziv!");
            else if (proizvodjac.Equals(string.Empty))
                throw new Exception("Nema proizvodjaca!");

            if (cena < 0)
                throw new Exception("Cena ne moze biti 0");
            else
            {
                this.naziv = naziv;
                this.proizvodjac = proizvodjac;
                this.cena = cena;
            }
        }

        public override string ToString()
        {
            return naziv + ", " + proizvodjac + ", " + cena + "RSD";
        }

        public int CompareTo(object obj)
        {
            Proizvod p = (Proizvod)obj;
            if (cena < p.cena) return -1;
            else if (cena > p.cena) return 1;
            else return 0;
        }
    }
}
