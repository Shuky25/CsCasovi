using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblici
{
    public abstract class Oblik
    {
        protected Color boja;
        protected PointF centar;

        public Oblik(Color boja, PointF centar)
        {
            this.boja = boja;
            this.centar = centar;
        }

        public Oblik()
        {
            this.boja = Color.Black;
            this.centar = new PointF(0, 0);
        }

        public abstract float Obim
        {
            get;
        }

        public abstract float Povrsina
        {
            get;
        }

        public abstract void Crtaj(Graphics g);
    }
}
