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
    public partial class Form7 : Form
    {
        public Form2 frm2;
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        OpenFileDialog duzenle = new OpenFileDialog();
      
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
        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                 txtAy.Text = DateTime.Now.Month.ToString();
            txtYil.Text = DateTime.Now.Year.ToString();
            string gun = txtGun.Text;
            string ay = txtAy.Text;
            string yil = txtYil.Text;

            if (ay == "01" || ay == "02" || ay == "03" || ay == "04" || ay == "05" || ay == "06" || ay == "07" || ay == "08" || ay == "09")
            {
                ay = temizle(ay);
            }

         
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select UyeAdiSoyadi, Gun, Ay ,  Yil , Ucret, Seans   from UyelerDetay  where Ay ='" + ay + "' and Yil ='" + yil +"'", bag);
            adtr.Fill(tablo);

            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[1].HeaderText = "Gün";
            dataGridView1.Columns[2].HeaderText = "Ay";
            dataGridView1.Columns[3].HeaderText = "Yıl";
            dataGridView1.Columns[4].HeaderText = "Ücret";
            dataGridView1.Columns[5].HeaderText = "Seans";
            if (dataGridView1.RowCount == 0)
            {
                lbldurum.Text = "Bu tarihe ait bilgi bulunamadı.";
            
            }
            else
            {
                bag.Open();
                SqlCommand top = new SqlCommand("Select SUM(Ucret) from UyelerDetay where Ay ='" + ay + "' and Yil ='" + yil + "'", bag);
                string kazanc = top.ExecuteScalar().ToString();
                bag.Close();
                lbldurum.Text="Bu tarihe ait " + dataGridView1.RowCount + " adet bilgi bulundu."+"\n"+"Toplam kazanç "+kazanc+" TL ";

            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.ToString());
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string gun = txtGun.Text;
            string ay = txtAy.Text;
            string yil = txtYil.Text;
            if (txtGun.Text == "" && txtAy.Text == "")
            {
               


                tablo.Clear();
                SqlDataAdapter adtr = new SqlDataAdapter("Select UyeAdiSoyadi, Gun, Ay , Yil , Ucret, Seans  from UyelerDetay where Yil ='" + yil + "'", bag);
                adtr.Fill(tablo);

                dataGridView1.DataSource = tablo;
                dataGridView1.Columns[0].HeaderText = "Adı Soyadı";
                dataGridView1.Columns[1].HeaderText = "Gün";
                dataGridView1.Columns[2].HeaderText = "Ay";
                dataGridView1.Columns[3].HeaderText = "Yıl";
                dataGridView1.Columns[4].HeaderText = "Ücret";
                dataGridView1.Columns[5].HeaderText = "Seans";
                if (dataGridView1.RowCount == 0)
                {
                    lbldurum.Text = "Bu tarihe ait bilgi bulunamadı.";

                }
                else
                {
                    bag.Open();
                    SqlCommand top = new SqlCommand("Select SUM(Ucret) from UyelerDetay where Yil ='" + yil + "'", bag);
                    string kazanc = top.ExecuteScalar().ToString();
                    bag.Close();
                    lbldurum.Text = "Bu tarihe ait " + dataGridView1.RowCount + " adet bilgi bulundu." + "\n" + "Toplam kazanç " + kazanc + " TL ";

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
                SqlDataAdapter adtr = new SqlDataAdapter("Select UyeAdiSoyadi, Gun, Ay , Yil , Ucret, Seans   from UyelerDetay where Ay ='" + ay + "' and Yil ='" + yil + "'", bag);
                adtr.Fill(tablo);

                dataGridView1.DataSource = tablo;
                dataGridView1.Columns[0].HeaderText = "Adı Soyadı";
                dataGridView1.Columns[1].HeaderText = "Gün";
                dataGridView1.Columns[2].HeaderText = "Ay";
                dataGridView1.Columns[3].HeaderText = "Yıl";
                dataGridView1.Columns[4].HeaderText = "Ücret";
                dataGridView1.Columns[5].HeaderText = "Seans";
                if (dataGridView1.RowCount == 0)
                {
                    lbldurum.Text = "Bu tarihe ait bilgi bulunamadı.";

                }
                else
                {
                    bag.Open();
                    SqlCommand top = new SqlCommand("Select SUM(Ucret) from UyelerDetay where Ay ='" + ay + "' and Yil ='" + yil + "'", bag);
                    string kazanc = top.ExecuteScalar().ToString();
                    bag.Close();
                    lbldurum.Text = "Bu tarihe ait " + dataGridView1.RowCount + " adet bilgi bulundu." + "\n" + "Toplam kazanç " + kazanc + " TL ";

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
                SqlDataAdapter adtr = new SqlDataAdapter("Select UyeAdiSoyadi, Gun, Ay , Yil , Ucret, Seans   from UyelerDetay  where Gun ='" + gun + "' and Ay ='" + ay + "' and Yil ='" + yil + "'", bag);
                adtr.Fill(tablo);

                dataGridView1.DataSource = tablo;
                dataGridView1.Columns[0].HeaderText = "Adı Soyadı";
                dataGridView1.Columns[1].HeaderText = "Gün";
                dataGridView1.Columns[2].HeaderText = "Ay";
                dataGridView1.Columns[3].HeaderText = "Yıl";
                dataGridView1.Columns[4].HeaderText = "Ücret";
                dataGridView1.Columns[5].HeaderText = "Seans";
                if (dataGridView1.RowCount == 0)
                {
                    lbldurum.Text = "Bu tarihe ait bilgi bulunamadı.";

                }
                else
                {
                    bag.Open();
                    SqlCommand top = new SqlCommand("Select SUM(Ucret) from UyelerDetay where Gun ='" + gun + "' and Ay ='" + ay + "' and Yil ='" + yil + "'", bag);
                    string kazanc = top.ExecuteScalar().ToString();
                    bag.Close();
                    lbldurum.Text = "Bu tarihe ait " + dataGridView1.RowCount + " adet bilgi bulundu." + "\n" + "Toplam kazanç " + kazanc + " TL ";

                }
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }


        }
    }
}
