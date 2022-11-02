using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generickazadatak2
{
    internal class Trougao<T>
    {
        private Tacka<T> A;
        private Tacka<T> B;
        private Tacka<T> C;


        public Trougao(Tacka<T> a, Tacka<T> b, Tacka<T> c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Stranica(Tacka<T> A, Tacka<T> B)
        {
            dynamic x1 = A.X;
            dynamic y1 = A.Y;
            dynamic x2 = B.X;
            dynamic y2 = B.Y;

            return Math.Sqrt(Math.Pow(Math.Abs(x2 - x1), 2) + Math.Pow(Math.Abs(y2 - y1), 2));
        }

        public double Povrsina()
        {
            dynamic a = Stranica(A, B);
            dynamic b = Stranica(B, C);
            dynamic c = Stranica(C, A);
            dynamic s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public void Crtaj(Graphics g, PictureBox p)
        {
            float w = (float)p.Width;
            float h = (float)p.Height;
            dynamic x1 = A.X;
            dynamic y1 = A.Y;
            dynamic x2 = B.X;
            dynamic y2 = B.Y;
            dynamic x3 = C.X;
            dynamic y3 = C.Y;
            //g = p.CreateGraphics();
            Pen olovka = new Pen(Color.Black, 5);
            g.DrawLine(olovka, (float)x1 + w / 2, h / 2 - (float)y1, (float)x2 + w / 2, h / 2 - (float)y2);
            g.DrawLine(olovka, x2 + w / 2, h / 2 - y2, x3 + w / 2, h / 2 - y3);
            g.DrawLine(olovka, x3 + w / 2, h / 2 - y3, x1 + w / 2, h / 2 - y1);
        }
    }
}
