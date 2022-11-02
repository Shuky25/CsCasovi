using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TackaKrugValjak
{
    internal class Valjak:Krug
    {
        private int visina;

        public int Visina
        {
            get { return visina; }
            set { visina = value; }
        }

        public Valjak() : base()
        {
            Visina = 0;
        }

        public Valjak(int x, int y, int r, int visina):base()
        {
            Visina = visina;
        }

        public override double Povrsina()
        {
            return base.Povrsina() * 2 + base.Obim() * visina;
        }

        public double Zapremina()
        {
            return base.Povrsina() * visina;
        }
    }
}
