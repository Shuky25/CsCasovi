using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oblici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random R = new Random();
        Oblik[] o;
        int n;
        float S = 0;
        float O = 0;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            n = (int)numericUpDown1.Value;
            o = new Oblik[n];
            for (int i = 0; i < n; i++)
            {
                int t = R.Next(1, 3);
                Color boja = Color.FromArgb(R.Next(0, 255), R.Next(0, 255), R.Next(0, 255));
                PointF centar = new PointF(R.Next(0, pictureBox1.Width - 20), R.Next(0, pictureBox1.Height - 20));

                switch(t)
                {
                    case 1:
                        {
                            o[i] = new Krug(boja, centar, R.Next(10, 30));
                            S += o[i].Povrsina;
                            O += o[i].Obim;
                            break;
                        }
                    case 2:
                        {
                            o[i] = new Pravougaonik(boja, centar, R.Next(10, 30), R.Next(10, 30));
                            S += o[i].Povrsina;
                            O += o[i].Obim;
                            break;
                        }
                }
                Text = "Povrsina: " + S + " Obim: " + O;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                o[i].Crtaj(e.Graphics);
            }
        }
    }
}
