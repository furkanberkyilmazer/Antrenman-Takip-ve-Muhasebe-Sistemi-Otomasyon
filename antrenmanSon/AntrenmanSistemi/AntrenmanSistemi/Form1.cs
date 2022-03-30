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
    public partial class Form1 : Form
    {
        public Form1 frm1;
        public Form2 frm2;
        public Form8 frm8;
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm8 = new Form8();

            frm8.frm1 = this;
            frm2.frm1 = this;
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();

        public string kullaniciadi;
        public string sifre;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kulad = new SqlCommand("Select KullaniciAdi from Kullanicilar where KullaniciAdi='" + txtKullaniciAdi.Text + "'", bag);
            SqlCommand asifre = new SqlCommand("Select Sifre from Kullanicilar where KullaniciAdi='" + txtKullaniciAdi.Text + "'", bag);

            try
            {

                kullaniciadi = kulad.ExecuteScalar().ToString();
                sifre = asifre.ExecuteScalar().ToString();

                if (kullaniciadi == txtKullaniciAdi.Text && sifre == txtSifre.Text)
                {


                    frm2.ShowDialog();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre hatalı!");
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı!");
            }
            bag.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm8.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
