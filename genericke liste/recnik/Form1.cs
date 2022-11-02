using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Recnik<string> sifre = new Recnik<string>();
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            sifre.Dodaj(tbKljuc.Text, tbVrednost.Text);
            tbKljuc.Text = "";
            tbVrednost.Text = "";
            tbKljuc.Focus();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            sifre.Ispisi(lbPar, cbKljuc, cbVrednost);
        }

        private void btnIspisiPar_Click(object sender, EventArgs e)
        {
            sifre.IspisiPar(cbKljuc, lbPar);
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            sifre.Promeni(cbKljuc, tbVrednost.Text);
        }

        private void btnObrisiPar_Click(object sender, EventArgs e)
        {
            sifre.ObrisiPar(cbKljuc);
        }
    }
}
