using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaFigura
{
    abstract public class Dvodimenzionalna:Figura
    {
        protected int x, y;

        public Dvodimenzionalna(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract override double Povrsina();
    }
}
