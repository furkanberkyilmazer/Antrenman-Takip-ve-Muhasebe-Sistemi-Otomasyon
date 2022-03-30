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
    public partial class Form6 : Form
    {
        public Form4 frm4;
        public Form6()
        {
            
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        OpenFileDialog duzenle = new OpenFileDialog();
        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select  Gun, Ay , Yil ,Ucret,Seans from UyelerDetay where UyeId ='" + frm4.id + "'", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
                 bag.Open();
            SqlCommand adis = new SqlCommand("Select AdiSoyadi from Uyeler where Id ='" + frm4.id + "'", bag);
            string adisoyadi = adis.ExecuteScalar().ToString(); 
            bag.Close();
           
            this.Text = "Antrenman Takip Sistemi - " + adisoyadi + " isimli üyenin antrenman geçmişi";
            listele();
            dataGridView1.Columns[0].HeaderText = "Gün";
            dataGridView1.Columns[1].HeaderText = "Ay";
            dataGridView1.Columns[2].HeaderText = "Yıl";
            dataGridView1.Columns[3].HeaderText = "Ücret";
            dataGridView1.Columns[4].HeaderText = "Seans";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public static string temizle(string metin)
        {
            string ifade = metin;
            ifade = ifade.Replace("'", "");
            ifade = ifade.Replace("+", "");
            ifade = ifade.Replace("-", "");
            ifade = ifade.Replace("*", "");
            ifade = ifade.Replace("/", "");
            ifade = ifade.Replace("?", "");
            ifade = ifade.Replace("0", "");
           
            return ifade;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string gun = txtGun.Text;
            string ay = txtAy.Text;
            string yil = txtYil.Text;
            try
            {
                if (txtGun.Text == "" && txtAy.Text == "")
                {
                    tablo.Clear();
                    SqlDataAdapter adtr3 = new SqlDataAdapter("Select  Gun, Ay , Yil ,Ucret,Seans from UyelerDetay where UyeId ='" + frm4.id + "' and Yil ='" + yil + "'", bag);
                    adtr3.Fill(tablo);

                    dataGridView1.DataSource = tablo;
                    dataGridView1.Columns[0].HeaderText = "Gün";
                    dataGridView1.Columns[1].HeaderText = "Ay";
                    dataGridView1.Columns[2].HeaderText = "Yıl";
                    dataGridView1.Columns[3].HeaderText = "Ücret";
                    dataGridView1.Columns[4].HeaderText = "Seans";
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Bu tarihe ait bilgi bulunamadı.");
                        listele();

                    }
                    else
                    {
                        MessageBox.Show("Bu tarihe ait " + dataGridView1.RowCount + " adet bilgi bulundu");

                    }
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                else if (txtGun.Text == "")
                {
                    if (ay == "01" || ay == "02" || ay == "03" || ay == "04" || ay == "05" || ay == "06" || ay == "07" || ay == "08" || ay == "09")
                    {
                        ay = temizle(ay);
                    }



                    tablo.Clear();
                    SqlDataAdapter adtr = new SqlDataAdapter("Select  Gun, Ay , Yil ,Ucret,Seans from UyelerDetay where UyeId ='" + frm4.id + "' and Ay ='" + ay + "' and Yil ='" + yil + "'", bag);
                    adtr.Fill(tablo);

                    dataGridView1.DataSource = tablo;
                    dataGridView1.Columns[0].HeaderText = "Gün";
                    dataGridView1.Columns[1].HeaderText = "Ay";
                    dataGridView1.Columns[2].HeaderText = "Yıl";
                    dataGridView1.Columns[3].HeaderText = "Ücret";
                    dataGridView1.Columns[4].HeaderText = "Seans";
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Bu tarihe ait bilgi bulunamadı.");
                        listele();

                    }
                    else
                    {
                        MessageBox.Show("Bu tarihe ait " + dataGridView1.RowCount + " adet bilgi bulundu");

                    }
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                }
               
                else
                {
                    if (gun == "01" || gun == "02" || gun == "03" || gun == "04" || gun == "05" || gun == "06" || gun == "07" || gun == "08" || gun == "09")
                    {
                        gun = temizle(gun);
                    }
                    if (ay == "01" || ay == "02" || ay == "03" || ay == "04" || ay == "05" || ay == "06" || ay == "07" || ay == "08" || ay == "09")
                    {
                        ay = temizle(ay);
                    }



                    tablo.Clear();
                    SqlDataAdapter adtr2 = new SqlDataAdapter("Select  Gun, Ay , Yil ,Ucret,Seans from UyelerDetay where UyeId ='" + frm4.id + "' and Gun ='" + gun + "' and Ay ='" + ay + "' and Yil ='" + yil + "'", bag);
                    adtr2.Fill(tablo);

                    dataGridView1.DataSource = tablo;
                    dataGridView1.Columns[0].HeaderText = "Gün";
                    dataGridView1.Columns[1].HeaderText = "Ay";
                    dataGridView1.Columns[2].HeaderText = "Yıl";
                    dataGridView1.Columns[3].HeaderText = "Ücret";
                    dataGridView1.Columns[4].HeaderText = "Seans";
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Bu tarihe ait bilgi bulunamadı.");
                        listele();

                    }
                    else
                    {
                        MessageBox.Show("Bu tarihe ait " + dataGridView1.RowCount + " adet bilgi bulundu");

                    }
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                }



            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Karakter Kullanımı.");
            }


        }

    }
}
