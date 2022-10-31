using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatakListe
{
    internal class Lista<T>
    {
        List<T> l = new List<T>();

        public void Ubaci(T x)
        {
            l.Add(x);
        }

        public void Ispis(ListBox lb, ComboBox cb)
        {
            lb.Items.Clear();
            cb.Items.Clear();
            foreach (T x in l)
                lb.Items.Add(x);
            foreach (T x in l)
                cb.Items.Add(x);
        }

        public void Obrni()
        {
            try
            {
                l.Reverse();
            }
            catch
            {
                MessageBox.Show("Nema elemenata u listi");
            }
        }

        public void ObrniOd(int index, int broj)
        {
            try
            {
                l.Reverse(index, broj);
            }
            catch
            {
                MessageBox.Show("Nema elemenata u listi");
            }
        }

        public void Dodaj(int index, T x)
        {
            try
            {
                l.Insert(index, x);
            }
            catch
            {
                MessageBox.Show("Vrednosti su van opsega");
            }
        }

        public void Sortiraj()
        {
            try
            {

                l.Sort();
            }
            catch
            {
                MessageBox.Show("Lista nema elemenata");
            }
        }

        public void IspisiNiz(ListBox lb)
        {
            try
            {
                lb.Items.Clear();
                T[] niz = new T[l.Count];
                niz = l.ToArray();
                foreach (T x in niz)
                    lb.Items.Add(x.ToString());
            }
            catch
            {
                MessageBox.Show("Lista nema elemenata");
            }
        }

        public void Brisi()
        {
            l.Clear();
        }

        public void NovaLista(int index, int br)
        {
            try
            {
                List<T> lista1 = new List<T>();
                for (int i = index; i < br; i++)
                    lista1.Add(l[index]);
            }
            catch
            {
                MessageBox.Show("Lista nema elemenata");
            }
        }

        public bool NalaziSe(ComboBox cb)
        {
            if (l.Contains((T)cb.SelectedItem))
                return true;
            else
                return false;
        }
    }
}
