using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voziloKlasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vozilo[] v =
            {
                (Vozilo)(new Automobil("Golf5", "VolksWagen", "KV-052-XS", 2005, 5)),
                (Vozilo)(new Automobil("Maverick", "Ford", "KV-036-AA", 2003, 5)),
                (Vozilo)(new Automobil("M3", "BMW", "KV-SUKI-VS", 2010, 3)),
                (Vozilo)(new Kamion("FH16", "Volvo", "BG-011-AA", 2018, 4, 2, 50)),
                (Vozilo)(new Kamion("Scilaner", "Scania", "BG-011-AA", 2012, 3, 2, 40)),
                (Vozilo)(new Autobus("IK-312M", "Neoplan", "KV-123-AA", 2015, 59))
            };

            for (int i = 0; i < v.Length-1; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[j].StarijeOd(v[i]))
                    {
                        Vozilo prom = v[i];
                        v[i] = v[j];
                        v[j] = prom;
                    }
                }
            }

            foreach (Vozilo K in v)
            {
                lbVozilo.Items.Add(K.Ispis());
            }

                foreach (Vozilo K in v)
            {
                if (K is Automobil)
                    lbAuto.Items.Add("AUTOMOBIL: " + K.Ispis());
                if (K is Kamion)
                    lbKamion.Items.Add("KAMION: " + K.Ispis());
                if (K is Autobus)
                    lbAutobus.Items.Add("AUTOBUS: " + K.Ispis());
            }
        }
    }
}
