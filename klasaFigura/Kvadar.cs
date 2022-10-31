using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaFigura
{
    public class Kvadar:Trodimenzionalna
    {
        private int sirina, duzina, visina;

        public Kvadar(int x, int y, int z, int sirina, int duzina, int visina) : base(x, y, z)
        {
            this.sirina = sirina;
            this.duzina = duzina;
            this.visina = visina;
        }

        public override double Povrsina()
        {
            return 2 * (sirina * duzina + sirina * visina + duzina * visina);
        }

        public override double Zapremina()
        {
            return sirina * visina * duzina;
        }
    }
}
