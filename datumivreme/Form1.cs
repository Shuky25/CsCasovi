﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datumivreme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }
        DateTime dt;
        private void button1_Click(object sender, EventArgs e)
        {
            dt = dateTimePicker1.Value;
            maskedTextBox2.Text = dt.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = Convert.ToDateTime(maskedTextBox2.Text);
        }
    }
}
