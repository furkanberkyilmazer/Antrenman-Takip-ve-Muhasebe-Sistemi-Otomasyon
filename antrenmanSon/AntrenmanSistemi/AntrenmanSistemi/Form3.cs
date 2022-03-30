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
    public partial class Form3 : Form
    {
        public Form2 frm2;
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        SqlCommand kmt = new SqlCommand();
        public string paket;
        public int adet = 0;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            paket = "";
            adet = 0;
            try
            {
                if (rbPaketDisi.Checked)
                {

                    if (paket == "")
                    {
                        bag.Open();
                        kmt.Connection = bag;

                        kmt.CommandText = "insert into Uyeler (AdiSoyadi,TelNo,Adres,Seyans,Fiyat,Tur,KayitTarihi) values('" + txtAdiSoyadi.Text + "','" + txtCepNo.Text + "','" + txtAdres.Text + "','" + 0 + "','" + 0 + "','" + "Paket Dışı" + "','" + DateTime.Now.ToString() + "')";
                        kmt.ExecuteNonQuery();
                        kmt.Dispose();
                        bag.Close();
                        frm2.listele();
                        MessageBox.Show("Kayıt Başarılı.");
                        this.Close();
                    }

                }
                else
                {
                    if (cbPt.Checked == true)
                    {
                        if (adet == 0)
                        {
                            paket += "PT";
                        }
                        else
                        {
                            paket += ", PT";
                        }
                        adet++;
                    }
                    if (cbMiha.Checked == true)
                    {
                        if (adet == 0)
                        {
                            paket += "Miha";
                        }
                        else
                        {
                            paket += ", Miha";
                        }
                        adet++;
                    }
                    if (cbPsiko.Checked == true)
                    {
                        if (adet == 0)
                        {
                            paket += "Psikolog";
                        }
                        else
                        {
                            paket += ", Psikolog";
                        }
                        adet++;
                    }
                    if (txtAdiSoyadi.Text.Trim() != "" && txtFiyat.Text.Trim() != "" && txtSeans.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtCepNo.Text.Trim() != "" && txtFiyat.Text != "0")
                    {
                        bag.Open();
                        kmt.Connection = bag;
                        if (paket == "")
                        {
                            kmt.CommandText = "insert into Uyeler (AdiSoyadi,TelNo,Adres,Seyans,Fiyat,Tur,KayitTarihi) values('" + txtAdiSoyadi.Text + "','" + txtCepNo.Text + "','" + txtAdres.Text + "','" + 0 + "','" + 0 + "','" + "Paket Dışı" + "','" + DateTime.Now.ToString() + "')";
                            MessageBox.Show("Paket seçilmediği için PAKET DIŞI kayıt yapılıcak.");
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();

                            frm2.listele();
                            MessageBox.Show("Kayıt Başarılı.");
                            this.Close();
                        }
                        else
                        {
                            if (cbPesin.Checked == true)
                            {
                                kmt.CommandText = "insert into Uyeler (AdiSoyadi,TelNo,Adres,Seyans,Fiyat,Tur,KayitTarihi) values('" + txtAdiSoyadi.Text + "','" + txtCepNo.Text + "','" + txtAdres.Text + "','" + int.Parse(txtSeans.Text) + "','" + 0 + "','" + paket + "','" + DateTime.Now.ToString() + "')";
                                kmt.ExecuteNonQuery();
                                kmt.Dispose();
                                bag.Close();

                                bag.Open();
                                SqlCommand cmd = new SqlCommand("Select Id from Uyeler where AdiSoyadi ='" + txtAdiSoyadi.Text +"' and Adres='"+txtAdres.Text+ "'", bag);
                                int id2 = int.Parse(cmd.ExecuteScalar().ToString());

                                kmt.CommandText = "insert into UyelerDetay (UyeAdiSoyadi,UyeId,Gun,Ay,Yil,Ucret,Seans) values('" + txtAdiSoyadi.Text + "','" + id2 + "','" + DateTime.Now.Day.ToString() + "','" + DateTime.Now.Month.ToString() + "','" + DateTime.Now.Year.ToString() + "','" + txtFiyat.Text + "','" + "Peşinat" + "')";
                                kmt.ExecuteNonQuery();
                                kmt.Dispose();
                                bag.Close();
                                frm2.listele();
                                MessageBox.Show("Kayıt Başarılı.");
                                this.Close();
                            }
                            else
                            {
                                kmt.CommandText = "insert into Uyeler (AdiSoyadi,TelNo,Adres,Seyans,Fiyat,Tur,KayitTarihi) values('" + txtAdiSoyadi.Text + "','" + txtCepNo.Text + "','" + txtAdres.Text + "','" + int.Parse(txtSeans.Text) + "','" + int.Parse(txtFiyat.Text) + "','" + paket + "','" + DateTime.Now.ToString() + "')";
                                kmt.ExecuteNonQuery();
                                kmt.Dispose();
                                bag.Close();
                                frm2.listele();
                               
                                MessageBox.Show("Kayıt Başarılı.");
                                this.Close();
                            }
                            
                           
                        }

                      
                    }
                    else
                    {
                        MessageBox.Show("Boş alan bırakmayınız.");
                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Bilgi Girişi");
                bag.Close();

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            paket = "";
            adet = 0;
            radioButton1.Checked = true;
            txtAdiSoyadi.Clear();
            txtAdres.Text = "";
            txtCepNo.Clear();
            txtFiyat.Clear();
            txtSeans.Clear();
            cbPesin.Checked = false;
            cbPt.Checked = false;
            cbMiha.Checked = false;
            cbPsiko.Checked = false;
           
         
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbPaket.Enabled = true;
        }

        private void rbPaketDisi_CheckedChanged(object sender, EventArgs e)
        {
            gbPaket.Enabled = false;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
