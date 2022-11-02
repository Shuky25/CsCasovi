using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblici
{
    internal class Krug : Oblik
    {
        private int r;

        public Krug(Color boja, PointF centar, int r):base(boja, centar)
        {
            this.r = r;
        }

        public override float Povrsina
        {
            get { return r * r * (float)Math.PI; }
        }

        public override float Obim
        {
            get { return 2 * r * (float)Math.PI; }
        }

        public override void Crtaj(Graphics g)
        {
            g.FillEllipse(new SolidBrush(base.boja), base.centar.X - r, base.centar.Y - r, 2 * r, 2 * r);
        }
    }
}
