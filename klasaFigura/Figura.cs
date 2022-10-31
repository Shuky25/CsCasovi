using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaFigura
{
    abstract public class Figura
    {
        protected string ime;
        public void postaviIme(string ime)
        {
            this.ime = ime;
        }
        abstract public double Povrsina();
    }
}
