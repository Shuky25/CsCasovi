using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfejsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface IOsoba
        {
            int Broj { get; set; }
            void Dodeli(int broj, string ime, string prezime);
            string Prikazi();
        }

        public class Student : IOsoba
        {
            int broj;
            string ime, prezime;
            public int Broj
            {
                get { return broj; }
                set { broj = value; }
            }

            public void Dodeli(int broj, string ime, string prezime)
            {
                this.broj = broj;
                this.ime = ime;
                this.prezime = prezime;
            }

            public string Prikazi()
            {
                return broj.ToString()+" "+ime+" "+prezime;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Dodeli(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
            textBox4.Text = s.Prikazi();

            if(s is IOsoba)
            {
                Text = "To je to!";
            }
        }
    }
}
