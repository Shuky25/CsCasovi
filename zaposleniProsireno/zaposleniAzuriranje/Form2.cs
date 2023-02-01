using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace zaposleniAzuriranje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Radnik> lista = new List<Radnik>();
        SqlCommand cmd, cmd1, cmd2;
        SqlConnection konekcija;
        DataTable dt;
        SqlDataAdapter da;

        private void button2_Click(object sender, EventArgs e)
        {
            Konekcija();
            string select1 = @"SELECT COUNT(*)";
            string from1 = "FROM ((radnici INNER JOIN odeljenja ON radnici.brod=odeljenja.brod) INNER JOIN osiguranja ON radnici.idos=osiguranja.idos)";
            string where1 = "WHERE odeljenja.brod=@brod";
            cmd2.Parameters.AddWithValue("@brod", comboBox1.Text);
            cmd2.CommandText = select1 + " " + from1 + " " + where1;
            try
            {
                konekcija.Open();
                int i = Convert.ToInt32(cmd2.ExecuteScalar());
                textBox1.Text = i.ToString();
            }
            catch
            {
                MessageBox.Show("Greska");
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Konekcija();
            cbBrod.Items.Clear();
            cbIdos.Items.Clear();
            cmd.CommandText = "SELECT * FROM radnici";
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Radnik r;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                r = new Radnik();
                r.ID = Convert.ToInt32(dt.Rows[i][0]);
                r.Ime = Convert.ToString(dt.Rows[i][1]);
                r.Prezime = Convert.ToString(dt.Rows[i][2]);
                r.Plata = Convert.ToDouble(dt.Rows[i][3]);
                lista.Add(r);
                if (!comboBox1.Items.Contains(dt.Rows[i][4]) && dt.Rows[i][4] != DBNull.Value)
                    comboBox1.Items.Add(dt.Rows[i][4]);
                if (!cbBrod.Items.Contains(dt.Rows[i][4]) && dt.Rows[i][4] != DBNull.Value)
                    cbBrod.Items.Add(dt.Rows[i][4]);
                if (!cbIdos.Items.Contains(dt.Rows[i][5]) && dt.Rows[i][5] != DBNull.Value)
                    cbIdos.Items.Add(dt.Rows[i][5]);

            }
            comboBox1.Items.Add("-");
            konekcija.Close();
        }

        void Konekcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Radnici;Integrated Security=True;";
            cmd = new SqlCommand();
            cmd1 = new SqlCommand();
            cmd2 = new SqlCommand();
            cmd.Connection = cmd1.Connection = cmd2.Connection = konekcija;
            dt = new DataTable();
            da = new SqlDataAdapter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*dataGridView1.DataSource = null;
            string select = "SELECT radnici.idbr, radnici.ime, radnici.prezime, radnici.plata, radnici.odljenje, odeljenja.naziv, odeljenja.mesto, osiguranje.naziv";
            string from = "FROM ((radnici INNER JOIN odeljenja ON radnici.brod = odeljenja.brod)INNER JOIN osiguranja ON radnici.idos = osiguranja.idos)";
            string where = "WHERE (odeljenja.brod=@brod AND radnici.plata>@plata)";

            cmd1.Parameters.AddWithValue("@brod@", cbBrod.Text);
            cmd1.Parameters.AddWithValue("@plata", tbPlata.Text);
            cmd1.CommandText = select + " " + from + " " + where;*/
            dataGridView1.DataSource = null;
            Konekcija();
            konekcija.Open();
            //string select = "SELECT  radnici.idbr,radnici.ime,radnici.prezime, radnici.plata, odeljenja.naziv, odeljenja.mesto,osiguranja.naziv";
            string from = "FROM ((radnici INNER JOIN odeljenja ON radnici.brod=odeljenja.brod) INNER JOIN osiguranja ON radnici.idos=osiguranja.idos)";
            string where = "WHERE (odeljenja.brod=@brod AND radnici.plata>@plata)";
            //cmd1.Parameters.AddWithValue("@brod", cbBrod.Text);
            //cmd1.Parameters.AddWithValue("@plata", tbPlata.Text);
            string select = "SELECT odeljenja.naziv, COUNT(radnici.brod)";
            //string from = "FROM ((radnici INNER JOIN odeljenja ON radnici.brod=odeljenja.brod) INNER JOIN osiguranja ON radnici.idos=osiguranja.idos)";
            string group = "GROUP BY odeljenja.naziv";
            string having = "HAVING COUNT(radnici.brod)>=2";
            cmd1.CommandText = select + " " + from + " " + group + " " + having;
            //cmd1.CommandText = select + " " + from + " " + group + " " + " " + having;
            da.SelectCommand = cmd1;
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
