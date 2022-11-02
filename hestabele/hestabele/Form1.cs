using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace hestabele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable tabela = new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tabela.Add(tbKljuc.Text, tbVrednost.Text);
                tbKljuc.Text = tbVrednost.Text = "";
                tbVrednost.Focus();
            }catch
            {
                MessageBox.Show("Ne mozete uneti dva ista kljuca");
                tbKljuc.Text = "";
                tbKljuc.Focus();
            }// ima metoda ContainsKey(); - da li sadrzi kljuc?
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string n in tabela.Values)
                lbIspis.Items.Add(n);
            foreach (string n in tabela.Keys)
                comboBox1.Items.Add(n);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = (string)tabela[comboBox1.SelectedItem];
            //MessageBox.Show((string)comboBox1.SelectedItem);
        }
    }
}
