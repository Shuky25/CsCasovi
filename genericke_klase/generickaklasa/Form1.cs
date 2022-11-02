using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generickaklasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnInt_Click(object sender, EventArgs e)
        {
            Test<int> a = new Test<int>(Convert.ToInt32(textBox1.Text));
            a.prikaziVrednost(textBox2);
            a.prikaziTip(textBox3);
        }

        private void btnStr_Click(object sender, EventArgs e)
        {
            Test<string> a = new Test<string>(textBox1.Text);
            a.prikaziVrednost(textBox2);
            a.prikaziTip(textBox3);
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            Test<double> a = new Test<double>(Convert.ToDouble(textBox1.Text));
            a.prikaziVrednost(textBox2);
            a.prikaziTip(textBox3);
        }
    }
}
