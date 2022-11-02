using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generickistek
{
    internal class Stek<T>
    {
        Stack<T> stek = new Stack<T>();

        public void Dodaj(T a, ComboBox cb)
        {
            stek.Push(a);
            cb.Items.Add(a);
        }

        public void Ispis(ListBox lb)
        {
            lb.Items.Clear();
            foreach (T n in stek)
                lb.Items.Add(n);
        }

        public T Vrh()
        {
            return stek.Peek();
        }

        public void Ukloni()
        {
            stek.Pop();
        }

        public void Prebaci(ListBox lb)
        {
            stek.ToArray();
            Ispis(lb);
        }

        public void Izbrisi()
        {
            stek.Clear();
        }

        public bool NalaziSe(ComboBox cb)
        {
            if (stek.Contains((T)cb.SelectedItem))
                return true;
            else
                return false;
        }
    }
}
