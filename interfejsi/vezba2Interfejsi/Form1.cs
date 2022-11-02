using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezba2Interfejsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Proizvod p = new Proizvod("Lenjir", "Suki", 1200);
            int x = p.CompareTo(new Proizvod("Lenjir", "Sara", 1200));
            if (x < 0) Text = "Cena prvog je manja";
            else if (x > 0) Text = "Cena prvog je veca";
            else Text = "Cene su jednake";
        }
    }
}
