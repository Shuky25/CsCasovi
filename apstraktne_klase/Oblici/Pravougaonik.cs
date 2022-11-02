using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oblici
{
    internal class Pravougaonik:Oblik
    {
        private int a, b;

        public Pravougaonik(Color boja, PointF centar, int a, int b):base(boja,centar)
        {
            this.a = a;
            this.b = b;
        }

        public override float Povrsina
        {
            get { return a * b; }
        }

        public override float Obim
        {
            get { return 2 * (a + b); }
        }

        public override void Crtaj(Graphics g)
        {
            g.FillRectangle(new SolidBrush(base.boja), base.centar.X - a/2, base.centar.Y - b/2, a, b);
        }
    }
}
