using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezba1
{
    internal class Osoba
    {
        string ime, prezime;
        int godine;

        public Osoba(string ime, string prezime, int godine)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godine = godine;
        }

        public Osoba()
        {
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public int Godine
        {
            get { return godine; }
            set { godine = value; }
        }

        public void Citaj(StreamReader sr)
        {
            Ime = sr.ReadLine();
            Prezime = sr.ReadLine();
            Godine = Convert.ToInt32(sr.ReadLine());
        }

        public void Pisi(StreamWriter sw)
        {
            sw.WriteLine(Ime);
            sw.WriteLine(Prezime);
            sw.WriteLine(Godine.ToString());
        }

        public bool StarijiOd(Osoba o)
        {
            return this.Godine > o.Godine;
        }
        public bool MladjiOd(Osoba o)
        {
            return this.Godine < o.Godine;
        }
        public bool Jednake(Osoba o)
        {
            return this.Godine == o.Godine;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime + " " + Godine;
        }
    }
}
