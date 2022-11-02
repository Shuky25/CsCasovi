using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TackaKrugValjak
{
    internal class Tacka
    {
        private int x;
        private int y;
        private static int br_objekata = 0;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Tacka()
        {
            X = 0;
            Y = 0;
            br_objekata++;
        }
        
        ~Tacka()
        {
            br_objekata--;
        }

        public Tacka (int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Ispis(ListBox l)
        {
            l.Items.Add("(" + X + ", " + Y + ")");
        }

        public static int Br_Objekata(Form f)
        {
            return br_objekata;
        }
    }
}
