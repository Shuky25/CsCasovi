using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaFigura
{
    abstract public class Trodimenzionalna:Figura
    {
        protected int x, y, z;

        public Trodimenzionalna(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public abstract override double Povrsina();

        abstract public double Zapremina();
    }
}
