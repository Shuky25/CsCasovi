using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace generickazadatak2
{
    internal class Tacka<T>
    {
        private T x;
        private T y;

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public Tacka()
        {

        }

        public Tacka(T x, T y)
        {
            X = x;
            Y = y;
        }

        public string Ispis()
        {
            return "(" + X.ToString() + ", " + y.ToString() + ")";
        }
    }
}
