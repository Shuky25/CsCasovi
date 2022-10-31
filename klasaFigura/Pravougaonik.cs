using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaFigura
{
    public class Pravougaonik:Dvodimenzionalna
    {
        private int sirina, duzina;

        public Pravougaonik(int x, int y, int sirina, int duzina):base(x, y)
        {
            this.sirina = sirina;
            this.duzina = duzina;
        }

        public override double Povrsina()
        {
            return sirina * duzina;
        }
    }
}
