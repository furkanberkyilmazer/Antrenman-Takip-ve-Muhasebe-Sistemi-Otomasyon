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
    public partial class Form8 : Form
    {
        public Form1 frm1;
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        SqlCommand kmt = new SqlCommand();
        Random rnd = new Random();
        int rastsayi;
        DataTable tablo = new DataTable();
        private void Form8_Load(object sender, EventArgs e)
        {
            rastsayi = rnd.Next(1000, 9999);

            lblkodu.Text = rastsayi.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            rastsayi = rnd.Next(1000, 9999);
            lblkodu.Text = rastsayi.ToString();
        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            if (txtsifre.TextLength < 3)
            {
                progressBar1.Value = 10;
                lbldurum.Text = "Çok Düşük";
                lbldurum.ForeColor = Color.Red;
                btnonayla.Enabled = false;
            }
            if (txtsifre.TextLength >= 4 && txtsifre.TextLength < 7)
            {
                progressBar1.Value = 30;
                lbldurum.Text = "Düşük";
                lbldurum.ForeColor = Color.OrangeRed;
                btnonayla.Enabled = true;
            }
            if (txtsifre.TextLength >= 7 && txtsifre.TextLength < 10)
            {
                progressBar1.Value = 50;
                lbldurum.Text = "Orta";
                lbldurum.ForeColor = Color.Yellow;
                btnonayla.Enabled = true;
            }
            if (txtsifre.TextLength >= 10 && txtsifre.TextLength < 13)
            {
                progressBar1.Value = 80;
                lbldurum.Text = "Güçlü";
                lbldurum.ForeColor = Color.YellowGreen;
                btnonayla.Enabled = true;
            }
            if (txtsifre.TextLength >= 13)
            {
                progressBar1.Value = 100;
                lbldurum.Text = "Çok Güçlü";
                lbldurum.ForeColor = Color.Green;
                btnonayla.Enabled = true;

            }
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            if (txtkod.Text != rastsayi.ToString())
            {
                MessageBox.Show("Kod Hatalı");
                rastsayi = rnd.Next(1000, 9999);
                lblkod.Text = rastsayi.ToString();
                txtkod.Clear();
                txteskisifre.Clear();
            }
            else
            {
                if (txtsifre.Text == txttsifre.Text)
                {
                    string kullaniciadi;
                    bag.Open();
                    SqlCommand adi = new SqlCommand("Select AdiSoyadi from Kullanicilar where Sifre='" + txteskisifre.Text + "'", bag);
                    try
                    {
                        kullaniciadi = adi.ExecuteScalar().ToString();
                        if (txteskisifre.Text != "" && txtsifre.Text != "" && txttsifre.Text != "")
                        {
                            try
                            {
                                if (kullaniciadi == "")
                                {
                                    MessageBox.Show("Eski Şifre Hatalı.");
                                }
                                else
                                {

                                    kmt.Connection = bag;

                                    kmt.CommandText = "update Kullanicilar set Sifre='" + txtsifre.Text + "' where Sifre='" + txteskisifre.Text + "'";
                                    kmt.ExecuteNonQuery();
                                    bag.Close();
                                    MessageBox.Show("Şifre değiştirildi.");
                                    this.Close();
                                }
                            }
                            catch (Exception)
                            {
                                rastsayi = rnd.Next(1000, 9999);
                                lblkod.Text = rastsayi.ToString();
                                txtkod.Clear();
                                txteskisifre.Clear();
                                bag.Close();
                                MessageBox.Show("Hatalı veri girişi.");
                            }
                        }
                        else
                        {
                            rastsayi = rnd.Next(1000, 9999);
                            lblkod.Text = rastsayi.ToString();
                            txtkod.Clear();
                            txteskisifre.Clear();
                            MessageBox.Show("boşlukları doldurunuz");
                        }

                    }
                    catch (Exception)
                    {
                        rastsayi = rnd.Next(1000, 9999);
                        lblkod.Text = rastsayi.ToString();
                        txtkod.Clear();
                        txteskisifre.Clear();
                        bag.Close();
                        MessageBox.Show("Şifre herhangi bir kullanıcıyla eşleşmedi.");
                    }


                }
                else
                {
                    MessageBox.Show("Şifreler Uymuyor");
                }
            }
        }
    }
}
