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
    public partial class Form4 : Form
    {
        public Form2 frm2;
        public Form5 frm5;
        public Form6 frm6;
        public Form4()
        {
            InitializeComponent();

            frm5 = new Form5();
            frm6 = new Form6();
          
            frm6.frm4 = this;

           
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        SqlCommand kmt = new SqlCommand();
        public string paket="";
        public int adet = 0;
        public int id; 
        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {

                txtAdiSoyadi.Enabled = false;
                txtAdres.Enabled = false;
                txtCepNo.Enabled = false;


                  btnSil.Enabled = true;
            button1.Enabled = true;
            cbPt.Checked = false;
            cbMiha.Checked = false;
            cbPsiko.Checked = false;
            txtAdiSoyadi.Text = "";
            txtAdres.Text = "";
            txtFiyat.Text = "";
            txtCepNo.Text = "";
            txtSeans.Text = "";
            btnKaydet.Visible = false;
            btnDuzenle.Enabled = true;

            this.Text = "Antrenman Takip Sistemi - " + frm2.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Form4 frm4 = new Form4();
            frm4.Refresh();
           id = int.Parse(frm2.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            bag.Open();
            SqlCommand adis = new SqlCommand("Select AdiSoyadi from Uyeler where Id ='" + id + "'", bag);
            SqlCommand telno = new SqlCommand("Select TelNo from Uyeler where Id ='" + id + "'", bag);
            SqlCommand adres = new SqlCommand("Select Adres from Uyeler where Id ='" + id + "'", bag);
            SqlCommand seyans = new SqlCommand("Select Seyans from Uyeler where Id ='" + id + "'", bag);
            SqlCommand fiyat = new SqlCommand("Select Fiyat from Uyeler where Id ='" + id + "'", bag);
            SqlCommand tur = new SqlCommand("Select Tur from Uyeler where Id ='" + id + "'", bag);
            SqlCommand tarih = new SqlCommand("Select KayitTarihi from Uyeler where Id ='" + id + "'", bag);

            string adisoyadi = adis.ExecuteScalar().ToString();
            string no = telno.ExecuteScalar().ToString();
            string adresi = adres.ExecuteScalar().ToString();
            string seyansi = seyans.ExecuteScalar().ToString();       
            string fiyati = fiyat.ExecuteScalar().ToString();
            if (int.Parse(seyansi) <= 0 && int.Parse(fiyati) > 0)
            {
                MessageBox.Show("Seanslar son buldu fakat, " + fiyati.ToString() + " TL ödeme bulunmakta.");
            }
            if (int.Parse(seyansi) == 1)
            {
                MessageBox.Show("Son Seans.");
            }
            if (int.Parse(seyansi) <= 0 && int.Parse(fiyati) <= 0)
            {
          
                MessageBox.Show("Seans ve Ödeme Bulunmamaktadır.");
            
            }
            else
            {
                if (int.Parse(seyansi) <= 0)
                {
                    MessageBox.Show("Ödeme Bulunmamaktadır.");
                }

                if (int.Parse(fiyati) <= 0)
                {
                    MessageBox.Show("Ödeme Bulunmamaktadır.");
                }

            }
           

            string turu = tur.ExecuteScalar().ToString();
            string tarihi = tarih.ExecuteScalar().ToString();

            txtAdiSoyadi.Text = adisoyadi;
            txtCepNo.Text = no;
            txtAdres.Text = adresi;
            txtSeans.Text = seyansi;
            txtFiyat.Text = fiyati;
            if (turu=="Paket Dışı")
            {
                rbPaketDisi.Checked = true;
                cbPt.Checked = false;
                cbMiha.Checked = false;
                cbPsiko.Checked = false;
                gbPaket.Enabled = false;
            }
            else
            {
                rbPaket.Checked = true;
                gbPaket.Enabled = true; 
                if (turu=="PT, Miha, Psikolog")
                {
                    cbPt.Checked = true;
                    cbMiha.Checked = true;
                    cbPsiko.Checked = true;

                }
                else if (turu == "PT, Miha")
                {
                    cbPt.Checked = true;
                    cbMiha.Checked = true;
                    
                }
                else if (turu == "PT, Psikolog")
                {
                    cbPt.Checked = true;                    
                    cbPsiko.Checked = true;
                }
                else if (turu == "PT")
                {
                    cbPt.Checked = true; 
                }
                else if (turu == "Miha")
                {
                    cbMiha.Checked = true;
                }
                else if (turu == "Miha, Psikolog")
                {
                   
                    cbMiha.Checked = true;
                    cbPsiko.Checked = true;
                }
                else if (turu == "Psikolog")
                {
                    cbPsiko.Checked = true;
                }
                else
                {
                    cbPt.Checked = false;
                    cbMiha.Checked = false;
                    cbPsiko.Checked = false;
                }
               
            }
            lbltarih.Text = "Kayit Tarihi = " + tarihi;
            bag.Close();
            gbPaket.Enabled = false;
            }
            catch (Exception ed)
            {


                MessageBox.Show(ed.ToString());
            }

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            bag.Open();
            id = int.Parse(frm2.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            SqlCommand tur = new SqlCommand("Select Tur from Uyeler where Id ='" + id + "'", bag);
            string turu = tur.ExecuteScalar().ToString();
            if (turu == "Paket Dışı")
            {
                rbPaketDisi.Checked = true;
                cbPt.Checked = false;
                cbMiha.Checked = false;
                cbPsiko.Checked = false;
                gbPaket.Enabled = false;
            }
            else
            {
                rbPaket.Checked = true;
                gbPaket.Enabled = true;
                if (turu == "PT, Miha, Psikolog")
                {
                    cbPt.Checked = true;
                    cbMiha.Checked = true;
                    cbPsiko.Checked = true;

                }
                else if (turu == "PT, Miha")
                {
                    cbPt.Checked = true;
                    cbMiha.Checked = true;

                }
                else if (turu == "PT, Psikolog")
                {
                    cbPt.Checked = true;
                    cbPsiko.Checked = true;
                }
                else if (turu == "PT")
                {
                    cbPt.Checked = true;
                }
                else if (turu == "Miha")
                {
                    cbMiha.Checked = true;
                }
                else if (turu == "Miha, Psikolog")
                {

                    cbMiha.Checked = true;
                    cbPsiko.Checked = true;
                }
                else if (turu == "Psikolog")
                {
                    cbPsiko.Checked = true;
                }
                else
                {
                    cbPt.Checked = false;
                    cbMiha.Checked = false;
                    cbPsiko.Checked = false;
                }
            }
            txtAdiSoyadi.Enabled = true;
            txtCepNo.Enabled = true;
            txtFiyat.Enabled = true;
         
            txtAdres.Enabled = true;
            txtSeans.Enabled = true;

            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            button1.Enabled = false;
            btnKaydet.Visible = true;
            rbPaket.Enabled = true;
            rbPaketDisi.Enabled = true;
            bag.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            paket = "";
            adet = 0;

            if (txtAdiSoyadi.Text.Trim() != "" && txtFiyat.Text.Trim() != "" && txtSeans.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtCepNo.Text.Trim() != "" && (rbPaket.Checked == true || rbPaketDisi.Checked == true))
            {
                if (rbPaketDisi.Checked)
                {

                    
                        bag.Open();
                        kmt.Connection = bag;

                        kmt.CommandText = "update Uyeler set AdiSoyadi='" + txtAdiSoyadi.Text + "',TelNo='" + txtCepNo.Text + "',Adres='" + txtAdres.Text + "',Seyans='" + 0 + "',Fiyat='" + 0 + "',Tur='" + "Paket Dışı" + "' where Id='" + frm2.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                        kmt.ExecuteNonQuery();
                        bag.Close();
                        frm2.listele();



                        MessageBox.Show("İşlem Tamamlandı");
                        txtAdiSoyadi.Enabled = false;
                        txtCepNo.Enabled = false;
                        txtFiyat.Enabled = false;

                        txtAdres.Enabled = false;
                        txtSeans.Enabled = false;

                        btnDuzenle.Enabled = true;

                        btnKaydet.Visible = false;
                        rbPaketDisi.Enabled = false;
                        rbPaket.Enabled = false;
                        gbPaket.Enabled = false;
                    
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
                    if (txtAdiSoyadi.Text.Trim() != "" && txtFiyat.Text.Trim() != "" && txtSeans.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtCepNo.Text.Trim() != "")
                    {
                        bag.Open();
                        kmt.Connection = bag;
                        if (paket == "")
                        {
                            kmt.CommandText = "update Uyeler set AdiSoyadi='" + txtAdiSoyadi.Text + "',TelNo='" + txtCepNo.Text + "',Adres='" + txtAdres.Text + "',Seyans='" + 0 + "',Fiyat='" + 0 + "',Tur='" + "Paket Dışı" + "' where Id='" + frm2.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                        }
                        else
                        {
                            kmt.CommandText = "update Uyeler set AdiSoyadi='" + txtAdiSoyadi.Text + "',TelNo='" + txtCepNo.Text + "',Adres='" + txtAdres.Text + "',Seyans='" + int.Parse(txtSeans.Text) + "',Fiyat='" + int.Parse(txtFiyat.Text) + "',Tur='" + paket + "' where Id='" + frm2.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                        }



                    }
                    else
                    {
                        MessageBox.Show("Boş alan bırakmayınız.");
                    } 
                    kmt.ExecuteNonQuery();
                bag.Close();
                frm2.listele();



                MessageBox.Show("İşlem Tamamlandı");
                txtAdiSoyadi.Enabled = false;
                txtCepNo.Enabled = false;
                txtFiyat.Enabled = false;

                txtAdres.Enabled = false;
                txtSeans.Enabled = false;

                btnDuzenle.Enabled = true;

                btnKaydet.Visible = false;
                rbPaketDisi.Enabled = false;
                rbPaket.Enabled = false;
                gbPaket.Enabled = false;
                this.Close();

                }


            }
            else
            {
                MessageBox.Show("Boş Alan Bırakılamaz");
            }
           
            this.Close();
        }

        private void btnEksilt_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bag.Open();
             SqlCommand durum = new SqlCommand("Select  Gun, Ay , Yil ,Ucret,Seans from UyelerDetay where UyeId ='" + id + "'", bag);
             try
             {
                string durumu = durum.ExecuteScalar().ToString();
            
            if (durumu!="")
            {
              
                 frm6.ShowDialog();
            }
            else
            {
                MessageBox.Show("Antrenman Geçmişi bulunmamaktadır.");
            }
             }
             catch (Exception)
             {

                 MessageBox.Show("Antrenman Geçmişine Ulaşılamadı.");
             }
            
            bag.Close();
        }

        private void rbPaket_CheckedChanged(object sender, EventArgs e)
        {
            gbPaket.Enabled = true;
        }

        private void rbPaketDisi_CheckedChanged(object sender, EventArgs e)
        {
            gbPaket.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            string ad = frm2.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult cevap;
            cevap = MessageBox.Show(ad+" isimli üyeyi SİLMEK istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Delete from Uyeler where Id='" + id + "'";
                kmt.ExecuteNonQuery();
                MessageBox.Show("Üye SİLİNDİ.");
                bag.Close();
                frm2.listele();
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
