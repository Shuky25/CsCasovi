using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaProizvod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Proizvod> p = new List<Proizvod>();
        private void Form1_Load(object sender, EventArgs e)
        {
            /*Proizvod[] p =
            {
                (Proizvod)(new Knjiga("Stranac", 2500, "Albert Kami")),
                (Proizvod)(new Knjiga("Matematika", 700, "Venne")),
                (Proizvod)(new Pribor("lenjir", 100, "Suki")),
            };*/
            p.Add(new Knjiga("Stranac", 2500, "Albert Kami"));
            p.Add(new Knjiga("Matematika", 700, "Venne"));
            p.Add(new Pribor("lenjir", 100, "Suki"));

            foreach (Proizvod k in p)
            {
                k.Prikaz(listBox1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < p.Count - 1; i++)
            {
                for (int j = i + 1; j < p.Count; j++)
                {
                    Proizvod prom = p[i];
                    p[i] = p[j];
                    p[j] = prom;
                }
            }

            foreach (Proizvod k in p)
            {
                listBox1.Items.Add(k.ToString());
            }
        }
    }
}
