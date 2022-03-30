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
    public partial class Form5 : Form
    {
        public Form2 frm2;

        public Form5()
        {
            InitializeComponent();

        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        SqlCommand kmt = new SqlCommand();

        private void Form5_Load(object sender, EventArgs e)
        {
            lblUyarı.Text = "";
            txtOrtFiyat.Text = "";
            txtSeans.Text = "";
            int id = int.Parse(frm2.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            bag.Open();
            SqlCommand seyans = new SqlCommand("Select Seyans from Uyeler where Id ='" + id + "'", bag);
            SqlCommand fiyat = new SqlCommand("Select Fiyat from Uyeler where Id ='" + id + "'", bag);
            SqlCommand tur = new SqlCommand("Select Tur from Uyeler where Id ='" + id + "'", bag);
            string seyansi = seyans.ExecuteScalar().ToString();
            string fiyati = fiyat.ExecuteScalar().ToString();
            string turu = tur.ExecuteScalar().ToString();
            if (turu == "Paket Dışı")
            {
                txtSeans.Text = "Tek Seans";
                lblUyarı.Text = "Tek Seans Ücreti Giriniz.";

            }
            else
            {
                if (int.Parse(seyansi) == 1)
                {
                    MessageBox.Show("Son Seans.");
                }


                if (int.Parse(seyansi) <= 0 && int.Parse(fiyati) <= 0)
                {
                    txtOrtFiyat.Text = int.Parse(fiyati).ToString();
                    txtSeans.Text = double.Parse(seyansi).ToString();
                    MessageBox.Show("Seans ve ödeme bulunmamakta.");

                }
                else
                {
                    if (int.Parse(seyansi) <= 0 && int.Parse(fiyati) > 0)
                    {
                        txtOrtFiyat.Text = double.Parse(fiyati).ToString();
                        txtSeans.Text = double.Parse(seyansi).ToString();
                        MessageBox.Show("Seans bulunmamakta fakat " + txtOrtFiyat.Text + " ödeme gözükmekte.");

                    }
                    else
                    {
                        if (int.Parse(fiyati) <= 0 && int.Parse(seyansi) > 0)
                        {
                            MessageBox.Show("Ödeme Bulunmamaktadır.");
                            txtSeans.Text = double.Parse(seyansi).ToString();

                        }
                        else
                        {
                            int ortfiyat = int.Parse(fiyati) / int.Parse(seyansi);
                           

                            if (ortfiyat <= 0.00 && int.Parse(fiyati) <= 0)
                            {
                                txtOrtFiyat.Text = "Ödeme Bulunmuyor.";
                            }
                            else
                            {
                                txtOrtFiyat.Text = ortfiyat.ToString();
                            }

                            if (int.Parse(seyansi) <= 0)
                            {
                                txtSeans.Text = "Seans bulunmuyor.";
                            }
                            else
                            {
                                txtSeans.Text = seyansi;
                            }
                        }


                    }

                }



            }

            bag.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(frm2.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string ad = frm2.dataGridView1.CurrentRow.Cells[1].Value.ToString();

                bag.Open();
                SqlCommand fiyat = new SqlCommand("Select Fiyat from Uyeler where Id ='" + id + "'", bag);
                string fiyati = fiyat.ExecuteScalar().ToString();
                SqlCommand tur = new SqlCommand("Select Tur from Uyeler where Id ='" + id + "'", bag);

                string turu = tur.ExecuteScalar().ToString();
                if (turu == "Paket Dışı")
                {
                    if (txtOrtFiyat.Text == "")
                    {
                        MessageBox.Show("Hatalı Bilgi Girişi.");
                    }
                    else
                    {

                        kmt.Connection = bag;
                        kmt.CommandText = "insert into UyelerDetay (UyeId,Gun,Ay,Yil,Ucret,Seans,UyeAdiSoyadi) values('" + id + "','" + DateTime.Now.Day + "','" + DateTime.Now.Month +
                            "','" + DateTime.Now.Year + "','" + double.Parse(txtOrtFiyat.Text) + "','" + 0 + "','" + ad + "')";
                        kmt.ExecuteNonQuery();
                        MessageBox.Show("Seans Gerçekleştirildi.");
                        kmt.Dispose();
                        bag.Close();
                        this.Close();
                    }
                }
                else
                {

                    string ortfiyat = txtOrtFiyat.Text;
                    if (((double.Parse(fiyati)) - (double.Parse(ortfiyat))) < 0)
                    {
                        MessageBox.Show("Fazla Ücret Girdiniz.");
                        bag.Close();

                    }
                    else
                    {

                        if (double.Parse(ortfiyat) <= 0 && double.Parse(txtSeans.Text) <= 0)
                        {
                            MessageBox.Show("Seans ve ücret bilgisi giriniz.");
                            bag.Close();
                        }
                        else
                        {
                            kmt.Connection = bag;
                            if (int.Parse(txtSeans.Text) <= 0)
                            {

                                kmt.CommandText = "insert into UyelerDetay (UyeId,Gun,Ay,Yil,Ucret,Seans,UyeAdiSoyadi) values('" + id + "','" + DateTime.Now.Day + "','" + DateTime.Now.Month +
                                    "','" + DateTime.Now.Year + "','" + double.Parse(ortfiyat) + "','" + int.Parse(txtSeans.Text) + "','" + ad + "')";
                                kmt.ExecuteNonQuery();
                                kmt.Dispose();

                                kmt.CommandText = "update Uyeler set Seyans='" + int.Parse(txtSeans.Text) + "',Fiyat='" + ((double.Parse(fiyati)) - (double.Parse(txtOrtFiyat.Text))) + "' where Id='" + id + "'";
                            }
                            else
                            {
                                kmt.CommandText = "insert into UyelerDetay (UyeId,Gun,Ay,Yil,Ucret,Seans,UyeAdiSoyadi) values('" + id + "','" + DateTime.Now.Day + "','" + DateTime.Now.Month +
                                   "','" + DateTime.Now.Year + "','" + double.Parse(ortfiyat) + "','" + int.Parse(txtSeans.Text) + "','" + ad + "')";
                                kmt.ExecuteNonQuery();
                                kmt.Dispose();
                                kmt.CommandText = "update Uyeler set Seyans='" + (int.Parse(txtSeans.Text) - 1) + "',Fiyat='" + ((double.Parse(fiyati)) - (double.Parse(ortfiyat))) + "' where Id='" + id + "'";
                            }

                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Seans Başarıyla Gerçekleştirildi.");


                            frm2.listele();

                            this.Close();

                        }



                    }


                }

            }
            catch (Exception)
            {
                
                MessageBox.Show("Hatalı Bilgi Girişi.");
                bag.Close();
                
            }
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtOrtFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeans_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
