using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generickazadatak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tacka<int> A;
        Tacka<int> B;
        Tacka<int> C;
        Graphics g;
        private void button1_Click(object sender, EventArgs e)
        {
            // copyright by Vojin Sundovic Suki 2k22 --> deco, ucite programiranje
            pictureBox1.Refresh();
            g = pictureBox1.CreateGraphics();
            Pen osa = new Pen(Color.Red, 1);
            g.DrawLine(osa, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
            g.DrawLine(osa, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);

            A = new Tacka<int>(Convert.ToInt32(tbX1.Text), Convert.ToInt32(tbY1.Text));
            B = new Tacka<int>(Convert.ToInt32(tbX2.Text), Convert.ToInt32(tbY2.Text));
            C = new Tacka<int>(Convert.ToInt32(tbX3.Text), Convert.ToInt32(tbY3.Text));

            Trougao<int> tr = new Trougao<int>(A, B, C);
            tr.Crtaj(g, pictureBox1);
            label6.Text = "Povrsina je: " + tr.Povrsina().ToString();
            label7.Text = A.Ispis() + "; " + B.Ispis() + "; " + C.Ispis();
        }
    }
}
