using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korisnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Osoba> lista = new List<Osoba>();
        int i = 0;
        Osoba o, max;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            i++;
            if (i == 1)
            {
                max = new Osoba(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
                lista.Add(max);
            }
            else
            {
                o = new Osoba(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
                if (max.CompareTo(o) == -1)
                    max = o;
                lista.Add(o);
            }
            lista.Sort();

            IEnumerator en = lista.GetEnumerator();

            while(en.MoveNext())
            {
                listBox1.Items.Add(en.Current.ToString());
            }

            listBox1.Items.Add("Najstarija osoba je: " + max.ToString());

            textBox1.Text = textBox2.Text = textBox3.Text = "";
            textBox1.Focus();
            Text = i.ToString();
        }
    }
}
