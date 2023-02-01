using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.TodayDate = DateTime.Today;
            maskedTextBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar2.SelectionEnd = Convert.ToDateTime(maskedTextBox1.Text);
        }
    }
}
