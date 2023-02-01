using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zaposleniAzuriranje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Radnik> lista  = new List<Radnik>();
        SqlConnection konekcija;
        SqlCommand komanda;
        DataTable dt;
        SqlDataAdapter da;
        void Konekcija()
        {
            konekcija = new SqlConnection();
            konekcija.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Radnici;Integrated Security=True;";
            komanda = new SqlCommand();
            komanda.Connection = konekcija;
            dt = new DataTable();
            da = new SqlDataAdapter();
        }

        bool Postoji()
        {
            bool postoji = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (Convert.ToInt32(tbIdbr.Text) == lista[i].ID)
                {
                    postoji = true;
                    break;
                }
            }
            return postoji;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "SELECT * FROM radnici";
            da.SelectCommand = komanda;
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
                if (!cbBrod.Items.Contains(dt.Rows[i][4]))
                    cbBrod.Items.Add(dt.Rows[i][4]);
                if (!comboBox2.Items.Contains(dt.Rows[i][5]))
                    comboBox2.Items.Add(dt.Rows[i][5]);

            }
            konekcija.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "INSERT INTO radnici(idbr,ime,prezime,plata,brod,idos) VALUES(@idbr,@ime,@prezime,@plata,@brod,@idos)";
            komanda.Parameters.AddWithValue("@idbr", tbIdbr.Text);
            komanda.Parameters.AddWithValue("@ime", tbIme.Text);
            komanda.Parameters.AddWithValue("@prezime", tbPrezime.Text);
            komanda.Parameters.AddWithValue("@plata", tbPlata.Text);
            //komanda.Parameters.AddWithValue("@brod", cbBrod.Text);
            komanda.Parameters.AddWithValue("@idos", comboBox2.Text);
            if (cbBrod.Text == "-")
                komanda.Parameters.AddWithValue("@brod", DBNull.Value);
            else
                komanda.Parameters.AddWithValue("@brod", cbBrod.Text);
            //komanda.Parameters.AddWithValue("@idos", comboBox2.Text);
            try
            {
                if (Postoji() == false)
                {
                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Podatak dodat u bazu");

                }
                else
                {
                    MessageBox.Show("Podatak vec postoji u bazi");
                    tbIdbr.Text = "";
                    tbIdbr.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Greska");
                tbIdbr.Text = "";
                tbIdbr.Focus();

            }
            finally
            {
                konekcija.Close();
            }
            Form1_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            komanda.CommandText = "UPDATE radnici SET ime=@ime, prezime=@prezime,plata=@plata, brod=@brod, idos=@idos WHERE idbr=@idbr";
            komanda.Parameters.AddWithValue("@ime", tbIme.Text);
            komanda.Parameters.AddWithValue("@prezime", tbPrezime.Text);
            komanda.Parameters.AddWithValue("@plata", tbPlata.Text);
            komanda.Parameters.AddWithValue("@brod", cbBrod.Text);
            komanda.Parameters.AddWithValue("@idos", comboBox2.Text);
            komanda.Parameters.AddWithValue("@idbr", tbIdbr.Text);

            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                MessageBox.Show("Podatak izmenjen u bazi");
                Form1_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Greska");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            komanda.CommandText = "DELETE FROM radnici WHERE idbr=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                konekcija.Open();
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Da li ste sigurni da zelite da izbrisete ovog radnika", "UPOZORENJE", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Radnik izbrisan iz baze");

                }
                else if (dr == DialogResult.No) return;
                else
                    return;

            }
            catch
            {
                MessageBox.Show("Greska");

            }
            Form1_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbIdbr.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbIme.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbPrezime.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPlata.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbBrod.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
