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
namespace AntrenmanSistemi
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form7 frm7;
        public Form9 frm9;

        public Form2()
        {
            InitializeComponent();
            frm3 = new Form3();
            frm5 = new Form5();
            frm4 = new Form4();
            frm7 = new Form7();
            frm9 = new Form9();

            frm7.frm2 = this;
            frm5.frm2 = this;
            frm4.frm2 = this;
            frm3.frm2 = this;
            frm9.frm2 = this;
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        OpenFileDialog duzenle = new OpenFileDialog();
        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select Id , AdiSoyadi, Tur , Seyans ,Fiyat from Uyeler", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[0].HeaderText = "Üye Numarası";
            dataGridView1.Columns[1].HeaderText = "Üye Adı Soyadı";
            dataGridView1.Columns[2].HeaderText = "Paket";
            dataGridView1.Columns[3].HeaderText = "Seyans";
            dataGridView1.Columns[4].HeaderText = "Fiyat";



            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frm3.ShowDialog();
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Üye Seçiniz.");
            }
            else
            {
                frm4.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Üye Seçiniz.");
            }
            else
            {
               
                frm5.ShowDialog();
            }
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            frm7.ShowDialog();
        }

        
        private void btnProgram_Click(object sender, EventArgs e)
        {
            frm9.ShowDialog();
        }
    }
}
