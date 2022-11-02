using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generickistek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stek<string> stek = new Stek<string>();
        string data;
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            data = tbElement.Text;
            stek.Dodaj(data, comboBox1);
            tbElement.Text = "";
            tbElement.Focus();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            try
            {
                stek.Ispis(listBox1);
            }
            catch
            {
                MessageBox.Show("Nema vise elemenata u steku", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVrh_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(stek.Vrh(), "Na vrhu", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Nema vise elemenata u steku", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            try
            {
                stek.Ukloni();
            }
            catch
            {
                MessageBox.Show("Nema vise elemenata u steku", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNiz_Click(object sender, EventArgs e)
        {
            
            try
            {
                stek.Prebaci(listBox2);
            }
            catch
            {
                MessageBox.Show("Nema vise elemenata u steku", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            
            try
            {
                stek.Izbrisi();
            }
            catch
            {
                MessageBox.Show("Nema vise elemenata u steku", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stek.NalaziSe(comboBox1))
                MessageBox.Show("Element se nalazi u steku", "Da li se nalazi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Element se ne nalazi u steku", "Da li se nalazi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
