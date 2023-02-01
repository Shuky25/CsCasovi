using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaposleniAzuriranje
{
    internal class Radnik
    {
        int id;
        string ime;
        string prezime;
        double plata;
        public Radnik()
        {

        }
        public Radnik(int id, string ime, string prezime, double plata)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.plata = plata;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
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

        public double Plata
        {
                get { return plata; }
                        set
            {
                plata = value;
            }
        }

        public override string ToString()
        {
            return ID + " " + Ime + " " + Prezime + " " + Plata;
        }
    }
}
