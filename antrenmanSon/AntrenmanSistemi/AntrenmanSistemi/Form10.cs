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
    public partial class Form10 : Form
    {
        public Form9 frm9;
        public Form10()
        {
            InitializeComponent();
            
        }

        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        OpenFileDialog duzenle = new OpenFileDialog();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != null && cbSaat.SelectedItem != null && (rbMiha.Checked == true || rbPT.Checked == true))
            {
                if (rbPT.Checked == true)
                {
                    if (cbSaat.SelectedItem == "06:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "07:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            frm9.Refresh();
                            this.Close();

                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "07:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "08:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "07:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "08:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "08:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "09:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "08:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "09:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "09:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "10:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "09:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "10:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "10:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "11:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "10:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "11:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "11:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "12:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "11:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "12:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "12:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "13:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "12:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "13:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "13:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "14:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "13:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "14:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "14:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "15:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "14:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "09:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "15:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "16:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "15:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "16:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "16:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "17:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "16:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "17:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "17:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "18:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "17:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "18:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "18:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "19:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "18:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "19:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "19:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "20:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "19:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "20:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "20:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "21:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "20:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "21:30" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "21:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='22:00' or Cikis='22:00')  or (Giris='21:30' or Cikis='22:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "22:00" + "','" + frm9.gun + "','" + "PT" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 1 saatlik " + "\n" + " ara bulunmamakta.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "21:30")
                    {


                        lbluyarı.Text = "21:30'a PT antrenmanı koyulamaz.";

                    }
                }
                if (rbMiha.Checked==true)
                {
                    if (cbSaat.SelectedItem == "06:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "07:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();

                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "07:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "07:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "07:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "08:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "08:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "08:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "08:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "09:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "09:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "09:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "09:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "10:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "10:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "10:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "10:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "11:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "11:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "11:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "11:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "12:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "12:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "12:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "12:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "13:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "13:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "13:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "13:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "14:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "14:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "14:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "14:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "15:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "15:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "15:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "15:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "16:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "16:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "16:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "16:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "17:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "17:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "17:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "17:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "18:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "18:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "18:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "18:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "19:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır."; bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "19:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "19:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "19:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "20:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "20:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "20:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "20:30")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "21:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close(); 
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "21:00")
                    {

                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='21:30' or Cikis='21:30')  or (Giris='21:00' or Cikis='22:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "21:30" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı."); frm9.Close();        
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır.";
                            bag.Close();
                        }
                    }
                    else if (cbSaat.SelectedItem == "21:30")
                    {
                        bag.Open();


                        SqlCommand sorgu = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='22:00' or Cikis='22:00')  or (Giris='21:00' or Cikis='22:00'))", bag);
                        if (sorgu.ExecuteScalar() == null)
                        {


                            kmt.Connection = bag;

                            kmt.CommandText = "insert into Randevu (KullaniciId,AdiSoyadi,Giris,Cikis,Gun,Tip) values('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + cbSaat.SelectedItem.ToString() + "','" + "22:00" + "','" + frm9.gun + "','" + "Miha" + "')";
                            kmt.ExecuteNonQuery();
                            kmt.Dispose();
                            bag.Close();
                            MessageBox.Show("Kayıt Başarılı.");
                            frm9.Close();                         
                            this.Close();
                        }
                        else
                        {
                            lbluyarı.Text = cbSaat.SelectedItem.ToString() + " saatinden itibaren 30 dakikalık " + "\n" + " ara bulunmamaktadır.";
                            bag.Close();
                        }

                    }
                }
            }
            else
            {

                lbluyarı.Text = "Alanları Doldurunuz.";
            }
           
        }
        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select Id,AdiSoyadi, Tur  from Uyeler", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
        public void doldur()
        {
            cbSaat.Items.Clear();
            bag.Open();
            SqlCommand sorgu1 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and (Giris='06:30' or Cikis='07:00')", bag);
            SqlCommand sorgu2 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
            SqlCommand sorgu3 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
            SqlCommand sorgu4 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
            SqlCommand sorgu5 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
            SqlCommand sorgu6 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
            SqlCommand sorgu7 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
            SqlCommand sorgu8 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
            SqlCommand sorgu9 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
            SqlCommand sorgu10 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
            SqlCommand sorgu11 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
            SqlCommand sorgu12 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
            SqlCommand sorgu13 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
            SqlCommand sorgu14 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
            SqlCommand sorgu15 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
            SqlCommand sorgu16 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
            SqlCommand sorgu17 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
            SqlCommand sorgu18 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
            SqlCommand sorgu19 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
            SqlCommand sorgu20 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
            SqlCommand sorgu21 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
            SqlCommand sorgu22 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
            SqlCommand sorgu23 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
            SqlCommand sorgu24 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
            SqlCommand sorgu25 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
            SqlCommand sorgu26 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
            SqlCommand sorgu27 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
            SqlCommand sorgu28 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
            SqlCommand sorgu29 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
            SqlCommand sorgu30 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
            SqlCommand sorgu31 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
            SqlCommand sorgu32 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + frm9.gun + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);

            if (sorgu1.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("06:30");
            }
            if (sorgu2.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("07:00");
            }
            if (sorgu3.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("07:30");
            }
            if (sorgu4.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("08:00");
            }
            if (sorgu5.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("08:30");
            }
            if (sorgu6.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("09:00");
            }
            if (sorgu7.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("09:30");
            }
            if (sorgu8.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("10:00");
            }
            if (sorgu9.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("10:30");
            }
            if (sorgu10.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("11:00");
            }
            if (sorgu11.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("11:30");
            }
            if (sorgu12.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("12:00");
            }
            if (sorgu13.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("12:30");
            }
            if (sorgu14.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("13:00");
            }
            if (sorgu15.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("13:30");
            }
            if (sorgu16.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("14:00");
            }
            if (sorgu17.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("14:30");
            }
            if (sorgu18.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("15:00");
            }
            if (sorgu19.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("15:30");
            }
            if (sorgu20.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("16:00");
            }
            if (sorgu21.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("16:30");
            }
            if (sorgu22.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("17:00");
            }
            if (sorgu23.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("17:30");
            }
            if (sorgu24.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("18:00");
            }
            if (sorgu25.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("18:30");
            }
            if (sorgu26.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("19:00");
            }
            if (sorgu27.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("19:30");
            }
            if (sorgu28.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("20:00");
            }
            if (sorgu29.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("20:30");
            }
            if (sorgu30.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("21:00");
            }
            if (sorgu31.ExecuteScalar() == null)
            {
                cbSaat.Items.Add("21:30");
            }


            bag.Close();

        }
        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                cbSaat.Text = "";
                this.Refresh();
                lblGun.Text = frm9.gun;
                rbPT.Enabled = false;
                rbMiha.Enabled = false;

                listele();
                dataGridView1.Columns[0].HeaderText = "Üye No";
                dataGridView1.Columns[1].HeaderText = "Üye Adı Soyadı";
                dataGridView1.Columns[2].HeaderText = "Paket";

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                lbluyarı.Text = "";
                doldur();



            }
            catch (Exception)
            {



            }


        }



        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                rbPT.Checked = false;
                rbMiha.Checked = false;
                lbluyarı.Text = "";
                string paket = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (paket == "Paket Dışı")
                {
                    rbPT.Enabled = true;
                    rbMiha.Enabled = true;
                }
                else if (paket == "PT, Miha")
                {

                    rbPT.Enabled = true;
                    rbMiha.Enabled = true;
                }
                else if (paket == "PT, Miha, Psikolog")
                {

                    rbPT.Enabled = true;
                    rbMiha.Enabled = true;
                }
                else if (paket == "PT, Psikolog")
                {

                    rbPT.Enabled = true;
                    rbMiha.Enabled = false;
                }
                else if (paket == "PT")
                {

                    rbPT.Enabled = true;
                    rbMiha.Enabled = false;
                }
                else if (paket == "Miha, Psikolog")
                {
                    rbPT.Enabled = false;
                    rbMiha.Enabled = true;
                }
                else if (paket == "Miha")
                {
                    rbPT.Enabled = false;
                    rbMiha.Enabled = true;

                }
                else
                {

                    rbPT.Enabled = false;
                    rbMiha.Enabled = false;
                }



            }
            catch (Exception)
            {
                rbPT.Enabled = true;
                rbMiha.Enabled = true;

            }

        }

        private void rbPT_CheckedChanged(object sender, EventArgs e)
        {
            lbluyarı.Text = "Yaklaşık 1 saatlik antrenman";
        }

        private void rbMiha_CheckedChanged(object sender, EventArgs e)
        {
            lbluyarı.Text = "Yaklaşık 30 dakikalık antrenman";
        }


    }
}
