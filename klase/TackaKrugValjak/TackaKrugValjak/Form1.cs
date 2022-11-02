using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TackaKrugValjak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            /*Tacka T = new Tacka();
            T.X = Convert.ToInt32(tbX.Text);
            T.Y = Convert.ToInt32(tbY.Text);
            T.Ispis(listBox1);
            Text = Tacka.Br_Objekata(this).ToString();*/
            Valjak V = new Valjak();
            V.X = Convert.ToInt32(tbX.Text);
            V.Y = Convert.ToInt32(tbY.Text);
            V.Poluprecnik = Convert.ToInt32(tbR.Text);
            V.Visina = Convert.ToInt32(tbH.Text);
            listBox1.Items.Add("Povrsina valjka je: " + V.Povrsina().ToString("0.00"));
            listBox1.Items.Add("Zapremina valjka je: " + V.Zapremina().ToString("0.00"));
        }
    }
}
