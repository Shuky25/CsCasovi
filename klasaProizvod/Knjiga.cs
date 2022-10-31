using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaProizvod
{
    internal class Knjiga:Proizvod
    {
        private string autor;

        public Knjiga(string naziv, double cena, string autor) : base(naziv, cena)
        {
            this.autor = autor;
        }

        public override void Prikaz(ListBox lb)
        {
            lb.Items.Add("Naziv: " + naziv);
            lb.Items.Add("Autor: " + autor);
            lb.Items.Add("Cena: " + cena);
            lb.Items.Add("");
        }

        public override string ToString()
        {
            return naziv + ", " + autor + ", " + cena;
        }
    }
}
