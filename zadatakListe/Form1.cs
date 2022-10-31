using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatakListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista<string> l = new Lista<string>();
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            l.Ubaci(tbElement.Text);
            btnIspisi_Click(sender, e);
            tbElement.Text = "";
            tbElement.Focus();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            l.Ispis(lbLista, comboBox1);
        }

        private void btnObrni_Click(object sender, EventArgs e)
        {
            l.Obrni();
            btnIspisi_Click(sender, e);
        }

        private void btnObIzbor_Click(object sender, EventArgs e)
        {
            l.ObrniOd(Convert.ToInt32(tbIndex.Text), Convert.ToInt32(tbBroj.Text));
            btnIspisi_Click(sender, e);
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            l.Dodaj(Convert.ToInt32(tbIndex.Text), tbBroj.Text);
            btnIspisi_Click(sender, e);
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            l.Sortiraj();
            btnIspisi_Click(sender, e);
        }

        private void btnIspisNiz_Click(object sender, EventArgs e)
        {
            l.IspisiNiz(lbNiz);
            btnIspisi_Click(sender, e);
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            l.Brisi();
        }

        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            l.NovaLista(Convert.ToInt32(tbIndex.Text), Convert.ToInt32(tbBroj.Text));
            btnIspisi_Click(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (l.NalaziSe(comboBox1))
                labNalazi.Text = "Element se nalazi u listi";
            else
                labNalazi.Text = "Element se ne nalazi u listi";
        }
    }
}
