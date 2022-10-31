using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaProizvod
{
    internal class Pribor:Proizvod
    {
        private string proizvodjac;

        public Pribor(string naziv, double cena, string proizvodjac):base(naziv, cena)
        {
            this.proizvodjac = proizvodjac;
        }

        public override void Prikaz(ListBox lb)
        {
            lb.Items.Add("Naziv: " + naziv);
            lb.Items.Add("Proizvodjac: " + proizvodjac);
            lb.Items.Add("Cena: " + cena);
            lb.Items.Add("");
        }

        public override string ToString()
        {
            return naziv + ", " + proizvodjac + ", " + cena;
        }
    }
}
