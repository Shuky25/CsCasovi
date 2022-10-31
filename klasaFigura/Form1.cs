using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaFigura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Pen olovka = new Pen(Color.Black, 1);
        Pen p = new Pen(Color.LightGray, 1);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbDuzina.Text == "" || tbSirina.Text == "")
                {
                    Exception ex = new Exception("Polje mora biti popunjeno");
                    throw ex;
                }
                else
                {
                    pictureBox1.Refresh();
                    int duzina = Convert.ToInt32(tbDuzina.Text);
                    int sirina = Convert.ToInt32(tbSirina.Text);

                    Pravougaonik P = new Pravougaonik(0, 0, sirina, duzina);
                    labPovrsinaP.Text =  P.Povrsina().ToString("0.00");

                    float x = (pictureBox1.Width / 2) - (duzina / 2);
                    float y = pictureBox1.Height / 2 - (sirina / 2);
                    g = pictureBox1.CreateGraphics();
                    g.DrawRectangle(olovka, x, y, duzina, sirina);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbDuzina.Text == "" || tbSirina.Text == "" || tbVisina.Text == "")
                {
                    Exception ex = new Exception("Polje mora biti popunjeno");
                    throw ex;
                }
                else
                {
                    pictureBox1.Refresh();
                    int duzina = Convert.ToInt32(tbDuzina.Text);
                    int sirina = Convert.ToInt32(tbSirina.Text);
                    int visina = Convert.ToInt32(tbVisina.Text);

                    Kvadar K = new Kvadar(0, 0, 0, sirina, duzina, visina);
                    labPovrsinaK.Text = K.Povrsina().ToString("0.00");
                    labZapreminaK.Text = K.Zapremina().ToString("0.00");

                    float x = (pictureBox1.Width / 2) - (duzina / 2);
                    float y = (pictureBox1.Height / 2) - (sirina / 2);
                    float x1 = x + duzina / 4;
                    float y1 = y - sirina / 4;
                    g = pictureBox1.CreateGraphics();
                    g.DrawLine(olovka, x, y, x1, y1);
                    g.DrawLine(p, x1, y1, x1, y1 + visina);
                    g.DrawLine(p, x1, y1 + visina, x1 + duzina, y1 + visina);
                    g.DrawLine(p, x1, y1 + visina, x, y + visina);

                    g.DrawLine(olovka, x, y, x + duzina, y);
                    g.DrawLine(olovka, x1, y1, x1 + duzina, y1);
                    g.DrawLine(olovka, x + duzina, y, x1 + duzina, y1);

                    g.DrawLine(olovka, x + duzina, y, x + duzina, y + visina);
                    g.DrawLine(olovka, x1 + duzina, y1, x1 + duzina, y1 + visina);
                    g.DrawLine(olovka, x + duzina, y + visina, x1 + duzina, y1 + visina);

                    g.DrawLine(olovka, x + duzina, y + visina, x, y + visina);
                    g.DrawLine(olovka, x, y + visina, x, y);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
