using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generickaklasa
{
    internal class Test<T>
    {
        private T a;
        public Test() { }
        public Test(T x)
        {
            a = x;
        }
        public void prikaziVrednost(TextBox tb)
        {
            tb.Text = a.ToString();
        }
        public void prikaziTip(TextBox tb)
        {
            tb.Text = typeof(T).ToString();
        }
    }
}
