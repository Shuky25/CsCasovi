using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaProizvod
{
    abstract public class Proizvod
    {
        protected string naziv;
        protected double cena;

        public Proizvod(string naziv, double cena)
        {
            this.naziv = naziv;
            this.cena = cena;
        }

        public bool VeceOd(Proizvod P)
        {
            return cena < P.cena;
        }

        public abstract void Prikaz(ListBox lb);
        public abstract override string ToString();
    }
}
