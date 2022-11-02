using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void tbDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Osoba o = new Osoba(tbIme.Text, tbPrezime.Text, Convert.ToInt32(tbGodine.Text));
                StreamWriter sw = new StreamWriter("spisak.txt", true);
                o.Pisi(sw);
                sw.Close();
                tbIme.Clear();
                tbIme.Focus();
                tbPrezime.Clear();
                tbGodine.Clear();
            }catch(Exception)
            {
                MessageBox.Show("GRESKA");
            }
        }

        private void tbIspis_Click(object sender, EventArgs e)
        {
            Osoba o, max;
            lbIspis.Items.Clear();
            StreamReader sr = new StreamReader("spisak.txt");
            max = new Osoba();
            max.Citaj(sr);
            lbIspis.Items.Add(max.ToString());
            while (!sr.EndOfStream)
            {
                o = new Osoba();
                o.Citaj(sr);
                lbIspis.Items.Add(o.ToString());
                if (o.StarijiOd(max)) max = o;
            }
            textBox1.Text = max.ToString();
            sr.Close();
        }
    }
}
