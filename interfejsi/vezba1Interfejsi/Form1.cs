using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezba1Interfejsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface IRacunarske_operacije
        {
            int Saberi();
            int Oduzmi();
            int Pomnozi();
            int Podeli();
            int A
            { get; set; }
            int B
            { get; set; }
        }

        public class Brojevi : IRacunarske_operacije
        {
            private int a, b;
            public int A
            {
                get { return a; }
                set { a = value; }
            }
            public int B
            {
                get { return b; }
                set { b = value; }
            }
            public int Saberi()
            {
                return A + B;
            }

            public int Oduzmi()
            {
                return A - B;
            }

            public int Pomnozi()
            {
                return A * B;
            }

            public int Podeli()
            {
                return A / B;
            }
        }
        Brojevi b = new Brojevi();

        private void btnPlus_Click(object sender, EventArgs e)
        {
            b.A = Convert.ToInt32(tbPrvi.Text);
            b.B = Convert.ToInt32(tbDrugi.Text);
            tbRes.Text = b.Saberi().ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            b.A = Convert.ToInt32(tbPrvi.Text);
            b.B = Convert.ToInt32(tbDrugi.Text);
            tbRes.Text = b.Oduzmi().ToString();
        }

        private void btnPuta_Click(object sender, EventArgs e)
        {
            b.A = Convert.ToInt32(tbPrvi.Text);
            b.B = Convert.ToInt32(tbDrugi.Text);
            tbRes.Text = b.Pomnozi().ToString();
        }

        private void btnPodeljeno_Click(object sender, EventArgs e)
        {
            try
            {
                if(b.B <= 0)
                {
                    Exception ex = new Exception("Deljenje nulom nema smisla");
                    throw ex;
                }
                else
                {
                    b.A = Convert.ToInt32(tbPrvi.Text);
                    b.B = Convert.ToInt32(tbDrugi.Text);
                    tbRes.Text = b.Podeli().ToString("#.##");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
