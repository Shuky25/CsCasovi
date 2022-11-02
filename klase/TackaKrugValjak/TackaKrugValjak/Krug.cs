using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TackaKrugValjak
{
    internal class Krug:Tacka
    {
        private int poluprecnik;

        public int Poluprecnik
        {
            get { return poluprecnik; }
            set { poluprecnik = value; }
        }

        public Krug():base()
        {
            poluprecnik = 0;
        }

        public virtual double Povrsina()
        {
            return Math.Pow(poluprecnik, 2) * Math.PI;
        }

        public double Obim()
        {
            return 2 * poluprecnik * Math.PI;
        }
    }
}
