using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recnik
{
    internal class Recnik<T>
    {
        Dictionary<T, T> recnik = new Dictionary<T, T>();

        public void Dodaj(T sifra, T vrednost)
        {
            try
            {
                recnik.Add(sifra, vrednost);
            }
            catch
            {
                MessageBox.Show("Kljuc postoji");
            }
        }

        public void Ispisi(ListBox lb, ComboBox cb1, ComboBox cb2)
        {
            lb.Items.Clear();
            cb1.Items.Clear();
            cb2.Items.Clear();

            foreach (KeyValuePair<T, T> c in recnik)
                lb.Items.Add(c);
            foreach (KeyValuePair<T, T> c in recnik)
                cb1.Items.Add(c.Key);
            foreach (KeyValuePair<T, T> c in recnik)
                cb2.Items.Add(c.Value);
        }

        public void Promeni(ComboBox cb, T vrednost)
        {
            recnik[(T)cb.SelectedItem] = vrednost;
        }

        public void IspisiPar(ComboBox cb, ListBox lb)
        {
            lb.Items.Clear();
            T vrednost;
            if (recnik.TryGetValue((T)cb.SelectedItem, out vrednost))
                lb.Items.Add((T)cb.SelectedItem + " " + vrednost);
        }

        public void ObrisiPar(ComboBox cb)
        {
            recnik.Remove((T)cb.SelectedItem);
        }
    }
}
