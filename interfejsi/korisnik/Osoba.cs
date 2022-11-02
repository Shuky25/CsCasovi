using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korisnik
{
    internal class Osoba:IComparable<Osoba>
    {
        string ime, prezime;
        int godine;

        public Osoba(string ime, string prezime, int godine)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godine = godine;
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

        public int CompareTo(Osoba osoba)
        {
            if (this.Godine > osoba.Godine) return 1;
            else if (this.Godine < osoba.Godine) return -1;
            else return 0;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime + " " + Godine;
        }


    }
}
