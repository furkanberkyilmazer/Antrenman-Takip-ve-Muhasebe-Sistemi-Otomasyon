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
    public partial class Form9 : Form
    {
        public Form1 frm1;
        public Form2 frm2;
        public Form10 frm10;
        public Form9 frm9;
        public Form11 frm11;
        public Form9()
        {
            InitializeComponent();
            frm10 = new Form10();
            frm11 = new Form11();

            frm11.frm9 = this;
            frm10.frm9 = this;
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        OpenFileDialog duzenle = new OpenFileDialog();
      
        private void btnPazartesi_Click(object sender, EventArgs e)
        {
            btnPazartesi.BackColor = Color.Silver;
            gbPazartesi.Visible = true;
            gbSali.Visible = false;
            gbCarsamba.Visible = false;
            gbPersembe.Visible = false;
            gbCuma.Visible = false;
            gbPazar.Visible = false;


            gbCumartesi.Visible = false;
            btnSali.BackColor = Color.Transparent;
            btnCarsamba.BackColor=Color.Transparent;
            btnPersembe.BackColor = Color.Transparent;
            btnCuma.BackColor = Color.Transparent;
            btnCumartesi.BackColor = Color.Transparent;
            btnPazar.BackColor = Color.Transparent;

            string gg = "Pazartesi";

            try
            {
                bag.Open();
                SqlCommand sorgua = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);
              

                if (sorgua.ExecuteScalar() != null)
                {
                    SqlCommand sorgut = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);
                    string ssorgut = sorgut.ExecuteScalar().ToString();
                    pts0630.BackColor = Color.Red;
                    pts0630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts0630.Text = sorgua.ExecuteScalar().ToString() + "\n" + ssorgut + "\n" + "06:30";

                }
                SqlCommand sorgua2 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
               

                if (sorgua2.ExecuteScalar() != null)
                {
                    SqlCommand sorgut2 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
                    string ssorgut2 = sorgut2.ExecuteScalar().ToString();
                    pts0700.BackColor = Color.Red;
                    pts0700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts0700.Text = sorgua2.ExecuteScalar().ToString() + "\n" + ssorgut2 + "\n" + "07:00";

                }

                SqlCommand sorgua3 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                
                if (sorgua3.ExecuteScalar() != null)
                {
                    SqlCommand sorgut3 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                    string ssorgut3 = sorgut3.ExecuteScalar().ToString();
                    pts0730.BackColor = Color.Red;
                    pts0730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts0730.Text = sorgua3.ExecuteScalar().ToString() + "\n" + ssorgut3 + "\n" + "07:30";

                }

                SqlCommand sorgua4 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
               
                if (sorgua4.ExecuteScalar() != null)
                {
                    SqlCommand sorgut4 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
                    string ssorgut4 = sorgut4.ExecuteScalar().ToString();
                    pts0800.BackColor = Color.Red;
                    pts0800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts0800.Text = sorgua4.ExecuteScalar().ToString() + "\n" + ssorgut4 + "\n" + "08:00";

                }
                SqlCommand sorgua5 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
               

                if (sorgua5.ExecuteScalar() != null)
                {
                    SqlCommand sorgut5 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
                    string ssorgut5 = sorgut5.ExecuteScalar().ToString();
                    pts0830.BackColor = Color.Red;
                    pts0830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts0830.Text = sorgua5.ExecuteScalar().ToString() + "\n" + ssorgut5 + "\n" + "08:30";

                }
                SqlCommand sorgua6 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
               

                if (sorgua6.ExecuteScalar() != null)
                {
                    SqlCommand sorgut6 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
                    string ssorgut6 = sorgut6.ExecuteScalar().ToString();
                    pts0900.BackColor = Color.Red;
                    pts0900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts0900.Text = sorgua6.ExecuteScalar().ToString() + "\n" + ssorgut6 + "\n" + "09:00";

                }
                SqlCommand sorgua7 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
               

                if (sorgua7.ExecuteScalar() != null)
                {
                    SqlCommand sorgut7 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
                    string ssorgut7 = sorgut7.ExecuteScalar().ToString();
                    pts0930.BackColor = Color.Red;
                    pts0930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts0930.Text = sorgua7.ExecuteScalar().ToString() + "\n" + ssorgut7 + "\n" + "09:30";

                }
                SqlCommand sorgua8 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                

                if (sorgua8.ExecuteScalar() != null)
                {
                    SqlCommand sorgut8 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                    string ssorgut8 = sorgut8.ExecuteScalar().ToString();
                    pts1000.BackColor = Color.Red;
                    pts1000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1000.Text = sorgua8.ExecuteScalar().ToString() + "\n" + ssorgut8 + "\n" + "10:00";

                }
                SqlCommand sorgua9 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
             

                if (sorgua9.ExecuteScalar() != null)
                {
                    SqlCommand sorgut9 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
                    string ssorgut9 = sorgut9.ExecuteScalar().ToString();
                    pts1030.BackColor = Color.Red;
                    pts1030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1030.Text = sorgua9.ExecuteScalar().ToString() + "\n" + ssorgut9 + "\n" + "10:30";

                }

                SqlCommand sorgua10 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
              

                if (sorgua10.ExecuteScalar() != null)
                {
                    SqlCommand sorgut10 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
                    string ssorgut10 = sorgut10.ExecuteScalar().ToString();
                    pts1100.BackColor = Color.Red;
                    pts1100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1100.Text = sorgua10.ExecuteScalar().ToString() + "\n" + ssorgut10 + "\n" + "11:00";

                }
                SqlCommand sorgua11 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
               

                if (sorgua11.ExecuteScalar() != null)
                {
                    SqlCommand sorgut11 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
                    string ssorgut11 = sorgut11.ExecuteScalar().ToString();
                    pts1130.BackColor = Color.Red;
                    pts1130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1130.Text = sorgua11.ExecuteScalar().ToString() + "\n" + ssorgut11 + "\n" + "11:30";

                }
                SqlCommand sorgua12 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
              

                if (sorgua12.ExecuteScalar() != null)
                {
                    SqlCommand sorgut12 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
                    string ssorgut12 = sorgut12.ExecuteScalar().ToString();
                    pts1200.BackColor = Color.Red;
                    pts1200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1200.Text = sorgua12.ExecuteScalar().ToString() + "\n" + ssorgut12 + "\n" + "12:00";

                }
                SqlCommand sorgua13 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
               

                if (sorgua13.ExecuteScalar() != null)
                {
                    SqlCommand sorgut13 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
                    string ssorgut13 = sorgut13.ExecuteScalar().ToString();
                    pts1230.BackColor = Color.Red;
                    pts1230.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1230.Text = sorgua13.ExecuteScalar().ToString() + "\n" + ssorgut13 + "\n" + "12:30";

                }
                SqlCommand sorgua14 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
           

                if (sorgua14.ExecuteScalar() != null)
                {
                    SqlCommand sorgut14 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
                    string ssorgut14 = sorgut14.ExecuteScalar().ToString();
                    pts1300.BackColor = Color.Red;
                    pts1300.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1300.Text = sorgua14.ExecuteScalar().ToString() + "\n" + ssorgut14 + "\n" + "13:00";

                }
                SqlCommand sorgua15 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                

                if (sorgua15.ExecuteScalar() != null)
                {
                    SqlCommand sorgut15 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                    string ssorgut15 = sorgut15.ExecuteScalar().ToString();
                    pts1330.BackColor = Color.Red;
                    pts1330.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1330.Text = sorgua15.ExecuteScalar().ToString() + "\n" + ssorgut15 + "\n" + "13:30";

                }
                SqlCommand sorgua16 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
             

                if (sorgua16.ExecuteScalar() != null)
                {
                    SqlCommand sorgut16 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
                    string ssorgut16 = sorgut16.ExecuteScalar().ToString();
                    pts1400.BackColor = Color.Red;
                    pts1400.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1400.Text = sorgua16.ExecuteScalar().ToString() + "\n" + ssorgut16 + "\n" + "14:00";

                }
                SqlCommand sorgua17 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
               

                if (sorgua17.ExecuteScalar() != null)
                {
                    SqlCommand sorgut17 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
                    string ssorgut17 = sorgut17.ExecuteScalar().ToString();
                    pts1430.BackColor = Color.Red;
                    pts1430.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1430.Text = sorgua17.ExecuteScalar().ToString() + "\n" + ssorgut17 + "\n" + "14:30";

                }
                SqlCommand sorgua18 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
              

                if (sorgua18.ExecuteScalar() != null)
                {
                    SqlCommand sorgut18 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
                    string ssorgut18 = sorgut18.ExecuteScalar().ToString();
                    pts1500.BackColor = Color.Red;
                    pts1500.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1500.Text = sorgua18.ExecuteScalar().ToString() + "\n" + ssorgut18 + "\n" + "15:00";

                }
                SqlCommand sorgua19 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
               

                if (sorgua19.ExecuteScalar() != null)
                {
                    SqlCommand sorgut19 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
                    string ssorgut19 = sorgut19.ExecuteScalar().ToString();
                    pts1530.BackColor = Color.Red;
                    pts1530.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1530.Text = sorgua19.ExecuteScalar().ToString() + "\n" + ssorgut19 + "\n" + "15:30";

                }
                SqlCommand sorgua20 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
               

                if (sorgua20.ExecuteScalar() != null)
                {
                    SqlCommand sorgut20 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
                    string ssorgut20 = sorgut20.ExecuteScalar().ToString();
                    pts1600.BackColor = Color.Red;
                    pts1600.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1600.Text = sorgua20.ExecuteScalar().ToString() + "\n" + ssorgut20 + "\n" + "16:00";

                }
                SqlCommand sorgua21 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
               

                if (sorgua21.ExecuteScalar() != null)
                {
                    SqlCommand sorgut21 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
                    string ssorgut21 = sorgut21.ExecuteScalar().ToString();
                    pts1630.BackColor = Color.Red;
                    pts1630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1630.Text = sorgua21.ExecuteScalar().ToString() + "\n" + ssorgut21 + "\n" + "16:30";

                }
                SqlCommand sorgua22 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
           

                if (sorgua22.ExecuteScalar() != null)
                {
                    SqlCommand sorgut22 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
                    string ssorgut22 = sorgut22.ExecuteScalar().ToString();
                    pts1700.BackColor = Color.Red;
                    pts1700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1700.Text = sorgua22.ExecuteScalar().ToString() + "\n" + ssorgut22 + "\n" + "17:00";

                }
                SqlCommand sorgua23 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
             

                if (sorgua23.ExecuteScalar() != null)
                {
                    SqlCommand sorgut23 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
                    string ssorgut23 = sorgut23.ExecuteScalar().ToString();
                    pts1730.BackColor = Color.Red;
                    pts1730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1730.Text = sorgua23.ExecuteScalar().ToString() + "\n" + ssorgut23 + "\n" + "17:30";

                }
                SqlCommand sorgua24 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                

                if (sorgua24.ExecuteScalar() != null)
                {
                    SqlCommand sorgut24 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                    string ssorgut24 = sorgut24.ExecuteScalar().ToString();
                    pts1800.BackColor = Color.Red;
                    pts1800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1800.Text = sorgua24.ExecuteScalar().ToString() + "\n" + ssorgut24 + "\n" + "18:00";

                }
                SqlCommand sorgua25 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
               

                if (sorgua25.ExecuteScalar() != null)
                {
                    SqlCommand sorgut25 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
                    string ssorgut25 = sorgut25.ExecuteScalar().ToString();
                    pts1830.BackColor = Color.Red;
                    pts1830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1830.Text = sorgua25.ExecuteScalar().ToString() + "\n" + ssorgut25 + "\n" + "18:30";

                }
                SqlCommand sorgua26 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
               

                if (sorgua26.ExecuteScalar() != null)
                {
                    SqlCommand sorgut26 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
                    string ssorgut26 = sorgut26.ExecuteScalar().ToString();
                    pts1900.BackColor = Color.Red;
                    pts1900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1900.Text = sorgua26.ExecuteScalar().ToString() + "\n" + ssorgut26 + "\n" + "19:00";

                }
                SqlCommand sorgua27 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                

                if (sorgua27.ExecuteScalar() != null)
                {
                    SqlCommand sorgut27 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                    string ssorgut27 = sorgut27.ExecuteScalar().ToString();
                    pts1930.BackColor = Color.Red;
                    pts1930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts1930.Text = sorgua27.ExecuteScalar().ToString() + "\n" + ssorgut27 + "\n" + "19:30";

                }
                SqlCommand sorgua28 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
             
                if (sorgua28.ExecuteScalar() != null)
                {
                    SqlCommand sorgut28 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
                    string ssorgut28 = sorgut28.ExecuteScalar().ToString();
                    pts2000.BackColor = Color.Red;
                    pts2000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts2000.Text = sorgua28.ExecuteScalar().ToString() + "\n" + ssorgut28 + "\n" + "20:00";

                }
                SqlCommand sorgua29 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
               
                if (sorgua29.ExecuteScalar() != null)
                {
                    SqlCommand sorgut29 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
                    string ssorgut29 = sorgut29.ExecuteScalar().ToString();
                    pts2030.BackColor = Color.Red;
                    pts2030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts2030.Text = sorgua29.ExecuteScalar().ToString() + "\n" + ssorgut29 + "\n" + "20:30";

                }
                SqlCommand sorgua30 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                

                if (sorgua30.ExecuteScalar() != null)
                {
                    SqlCommand sorgut30 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                    string ssorgut30 = sorgut30.ExecuteScalar().ToString();
                    pts2100.BackColor = Color.Red;
                    pts2100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts2100.Text = sorgua30.ExecuteScalar().ToString() + "\n" + ssorgut30 + "\n" + "21:00";

                }

                SqlCommand sorgua31 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
               

                if (sorgua31.ExecuteScalar() != null)
                {
                    SqlCommand sorgut31 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
                    string ssorgut31 = sorgut31.ExecuteScalar().ToString();
                    pts2130.BackColor = Color.Red;
                    pts2130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts2130.Text = sorgua31.ExecuteScalar().ToString() + "\n" + ssorgut31 + "\n" + "21:30";

                }
                SqlCommand sorgua32 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);
              

                if (sorgua32.ExecuteScalar() != null)
                {
                    SqlCommand sorgut32 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);
                    string ssorgut32 = sorgut32.ExecuteScalar().ToString();
                    pts2200.BackColor = Color.Red;
                    pts2200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pts2200.Text = sorgua32.ExecuteScalar().ToString() + "\n" + ssorgut32 + "\n" + "22:00";

                }

                bag.Close();


            }
            catch (Exception ec)
            {
                bag.Close();
                MessageBox.Show(ec.ToString());
            }
                

        }

        private void btnSali_Click(object sender, EventArgs e)
        {
            btnPazartesi.BackColor = Color.Transparent;
            btnCarsamba.BackColor = Color.Transparent;
            btnSali.BackColor = Color.Silver;
            btnPersembe.BackColor = Color.Transparent;
            btnCuma.BackColor = Color.Transparent;
            btnCumartesi.BackColor = Color.Transparent;
            btnPazar.BackColor = Color.Transparent;

            gbPazar.Visible = false;
            gbCumartesi.Visible = false;
            gbCuma.Visible = false;
            gbPersembe.Visible = false;
            gbPazartesi.Visible = false;
            gbCarsamba.Visible = false;
            gbSali.Visible = true;

            string gg = "Salı";
          

            try
            {
                bag.Open();
                SqlCommand sorgua = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);


                if (sorgua.ExecuteScalar() != null)
                {
                    SqlCommand sorgut = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);
                    string ssorgut = sorgut.ExecuteScalar().ToString();
                    s0630.BackColor = Color.Red;
                    s0630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s0630.Text = sorgua.ExecuteScalar().ToString() + "\n" + ssorgut + "\n" + "06:30";

                }
                SqlCommand sorgua2 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);


                if (sorgua2.ExecuteScalar() != null)
                {
                    SqlCommand sorgut2 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
                    string ssorgut2 = sorgut2.ExecuteScalar().ToString();
                    s0700.BackColor = Color.Red;
                    s0700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s0700.Text = sorgua2.ExecuteScalar().ToString() + "\n" + ssorgut2 + "\n" + "07:00";

                }

                SqlCommand sorgua3 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);

                if (sorgua3.ExecuteScalar() != null)
                {
                    SqlCommand sorgut3 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                    string ssorgut3 = sorgut3.ExecuteScalar().ToString();
                    s0730.BackColor = Color.Red;
                    s0730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s0730.Text = sorgua3.ExecuteScalar().ToString() + "\n" + ssorgut3 + "\n" + "07:30";

                }

                SqlCommand sorgua4 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);

                if (sorgua4.ExecuteScalar() != null)
                {
                    SqlCommand sorgut4 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
                    string ssorgut4 = sorgut4.ExecuteScalar().ToString();
                    s0800.BackColor = Color.Red;
                    s0800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s0800.Text = sorgua4.ExecuteScalar().ToString() + "\n" + ssorgut4 + "\n" + "08:00";

                }
                SqlCommand sorgua5 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);


                if (sorgua5.ExecuteScalar() != null)
                {
                    SqlCommand sorgut5 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
                    string ssorgut5 = sorgut5.ExecuteScalar().ToString();
                    s0830.BackColor = Color.Red;
                    s0830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s0830.Text = sorgua5.ExecuteScalar().ToString() + "\n" + ssorgut5 + "\n" + "08:30";

                }
                SqlCommand sorgua6 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);


                if (sorgua6.ExecuteScalar() != null)
                {
                    SqlCommand sorgut6 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
                    string ssorgut6 = sorgut6.ExecuteScalar().ToString();
                    s0900.BackColor = Color.Red;
                    s0900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s0900.Text = sorgua6.ExecuteScalar().ToString() + "\n" + ssorgut6 + "\n" + "09:00";

                }
                SqlCommand sorgua7 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);


                if (sorgua7.ExecuteScalar() != null)
                {
                    SqlCommand sorgut7 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
                    string ssorgut7 = sorgut7.ExecuteScalar().ToString();
                    s0930.BackColor = Color.Red;
                    s0930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s0930.Text = sorgua7.ExecuteScalar().ToString() + "\n" + ssorgut7 + "\n" + "09:30";

                }
                SqlCommand sorgua8 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);


                if (sorgua8.ExecuteScalar() != null)
                {
                    SqlCommand sorgut8 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                    string ssorgut8 = sorgut8.ExecuteScalar().ToString();
                    s1000.BackColor = Color.Red;
                    s1000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1000.Text = sorgua8.ExecuteScalar().ToString() + "\n" + ssorgut8 + "\n" + "10:00";

                }
                SqlCommand sorgua9 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);


                if (sorgua9.ExecuteScalar() != null)
                {
                    SqlCommand sorgut9 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
                    string ssorgut9 = sorgut9.ExecuteScalar().ToString();
                    s1030.BackColor = Color.Red;
                    s1030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1030.Text = sorgua9.ExecuteScalar().ToString() + "\n" + ssorgut9 + "\n" + "10:30";

                }

                SqlCommand sorgua10 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);


                if (sorgua10.ExecuteScalar() != null)
                {
                    SqlCommand sorgut10 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
                    string ssorgut10 = sorgut10.ExecuteScalar().ToString();
                    s1100.BackColor = Color.Red;
                    s1100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1100.Text = sorgua10.ExecuteScalar().ToString() + "\n" + ssorgut10 + "\n" + "11:00";

                }
                SqlCommand sorgua11 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);


                if (sorgua11.ExecuteScalar() != null)
                {
                    SqlCommand sorgut11 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
                    string ssorgut11 = sorgut11.ExecuteScalar().ToString();
                    s1130.BackColor = Color.Red;
                    s1130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1130.Text = sorgua11.ExecuteScalar().ToString() + "\n" + ssorgut11 + "\n" + "11:30";

                }
                SqlCommand sorgua12 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);


                if (sorgua12.ExecuteScalar() != null)
                {
                    SqlCommand sorgut12 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
                    string ssorgut12 = sorgut12.ExecuteScalar().ToString();
                    s1200.BackColor = Color.Red;
                    s1200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1200.Text = sorgua12.ExecuteScalar().ToString() + "\n" + ssorgut12 + "\n" + "12:00";

                }
                SqlCommand sorgua13 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);


                if (sorgua13.ExecuteScalar() != null)
                {
                    SqlCommand sorgut13 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
                    string ssorgut13 = sorgut13.ExecuteScalar().ToString();
                    s1230.BackColor = Color.Red;
                    s1230.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1230.Text = sorgua13.ExecuteScalar().ToString() + "\n" + ssorgut13 + "\n" + "12:30";

                }
                SqlCommand sorgua14 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);


                if (sorgua14.ExecuteScalar() != null)
                {
                    SqlCommand sorgut14 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
                    string ssorgut14 = sorgut14.ExecuteScalar().ToString();
                    s1300.BackColor = Color.Red;
                    s1300.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1300.Text = sorgua14.ExecuteScalar().ToString() + "\n" + ssorgut14 + "\n" + "13:00";

                }
                SqlCommand sorgua15 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);


                if (sorgua15.ExecuteScalar() != null)
                {
                    SqlCommand sorgut15 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                    string ssorgut15 = sorgut15.ExecuteScalar().ToString();
                    s1330.BackColor = Color.Red;
                    s1330.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1330.Text = sorgua15.ExecuteScalar().ToString() + "\n" + ssorgut15 + "\n" + "13:30";

                }
                SqlCommand sorgua16 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);


                if (sorgua16.ExecuteScalar() != null)
                {
                    SqlCommand sorgut16 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
                    string ssorgut16 = sorgut16.ExecuteScalar().ToString();
                    s1400.BackColor = Color.Red;
                    s1400.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1400.Text = sorgua16.ExecuteScalar().ToString() + "\n" + ssorgut16 + "\n" + "14:00";

                }
                SqlCommand sorgua17 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);


                if (sorgua17.ExecuteScalar() != null)
                {
                    SqlCommand sorgut17 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
                    string ssorgut17 = sorgut17.ExecuteScalar().ToString();
                    s1430.BackColor = Color.Red;
                    s1430.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1430.Text = sorgua17.ExecuteScalar().ToString() + "\n" + ssorgut17 + "\n" + "14:30";

                }
                SqlCommand sorgua18 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);


                if (sorgua18.ExecuteScalar() != null)
                {
                    SqlCommand sorgut18 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
                    string ssorgut18 = sorgut18.ExecuteScalar().ToString();
                    s1500.BackColor = Color.Red;
                    s1500.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1500.Text = sorgua18.ExecuteScalar().ToString() + "\n" + ssorgut18 + "\n" + "15:00";

                }
                SqlCommand sorgua19 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);


                if (sorgua19.ExecuteScalar() != null)
                {
                    SqlCommand sorgut19 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
                    string ssorgut19 = sorgut19.ExecuteScalar().ToString();
                    s1530.BackColor = Color.Red;
                    s1530.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1530.Text = sorgua19.ExecuteScalar().ToString() + "\n" + ssorgut19 + "\n" + "15:30";

                }
                SqlCommand sorgua20 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);


                if (sorgua20.ExecuteScalar() != null)
                {
                    SqlCommand sorgut20 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
                    string ssorgut20 = sorgut20.ExecuteScalar().ToString();
                    s1600.BackColor = Color.Red;
                    s1600.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   s1600.Text = sorgua20.ExecuteScalar().ToString() + "\n" + ssorgut20 + "\n" + "16:00";

                }
                SqlCommand sorgua21 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);


                if (sorgua21.ExecuteScalar() != null)
                {
                    SqlCommand sorgut21 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
                    string ssorgut21 = sorgut21.ExecuteScalar().ToString();
                    s1630.BackColor = Color.Red;
                    s1630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1630.Text = sorgua21.ExecuteScalar().ToString() + "\n" + ssorgut21 + "\n" + "16:30";

                }
                SqlCommand sorgua22 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);


                if (sorgua22.ExecuteScalar() != null)
                {
                    SqlCommand sorgut22 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
                    string ssorgut22 = sorgut22.ExecuteScalar().ToString();
                    s1700.BackColor = Color.Red;
                    s1700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1700.Text = sorgua22.ExecuteScalar().ToString() + "\n" + ssorgut22 + "\n" + "17:00";

                }
                SqlCommand sorgua23 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);


                if (sorgua23.ExecuteScalar() != null)
                {
                    SqlCommand sorgut23 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
                    string ssorgut23 = sorgut23.ExecuteScalar().ToString();
                    s1730.BackColor = Color.Red;
                    s1730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1730.Text = sorgua23.ExecuteScalar().ToString() + "\n" + ssorgut23 + "\n" + "17:30";

                }
                SqlCommand sorgua24 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);


                if (sorgua24.ExecuteScalar() != null)
                {
                    SqlCommand sorgut24 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                    string ssorgut24 = sorgut24.ExecuteScalar().ToString();
                    s1800.BackColor = Color.Red;
                    s1800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1800.Text = sorgua24.ExecuteScalar().ToString() + "\n" + ssorgut24 + "\n" + "18:00";

                }
                SqlCommand sorgua25 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);


                if (sorgua25.ExecuteScalar() != null)
                {
                    SqlCommand sorgut25 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
                    string ssorgut25 = sorgut25.ExecuteScalar().ToString();
                    s1830.BackColor = Color.Red;
                    s1830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1830.Text = sorgua25.ExecuteScalar().ToString() + "\n" + ssorgut25 + "\n" + "18:30";

                }
                SqlCommand sorgua26 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);


                if (sorgua26.ExecuteScalar() != null)
                {
                    SqlCommand sorgut26 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
                    string ssorgut26 = sorgut26.ExecuteScalar().ToString();
                    s1900.BackColor = Color.Red;
                    s1900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1900.Text = sorgua26.ExecuteScalar().ToString() + "\n" + ssorgut26 + "\n" + "19:00";

                }
                SqlCommand sorgua27 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);


                if (sorgua27.ExecuteScalar() != null)
                {
                    SqlCommand sorgut27 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                    string ssorgut27 = sorgut27.ExecuteScalar().ToString();
                    s1930.BackColor = Color.Red;
                    s1930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s1930.Text = sorgua27.ExecuteScalar().ToString() + "\n" + ssorgut27 + "\n" + "19:30";

                }
                SqlCommand sorgua28 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);

                if (sorgua28.ExecuteScalar() != null)
                {
                    SqlCommand sorgut28 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
                    string ssorgut28 = sorgut28.ExecuteScalar().ToString();
                    s2000.BackColor = Color.Red;
                    s2000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s2000.Text = sorgua28.ExecuteScalar().ToString() + "\n" + ssorgut28 + "\n" + "20:00";

                }
                SqlCommand sorgua29 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);

                if (sorgua29.ExecuteScalar() != null)
                {
                    SqlCommand sorgut29 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
                    string ssorgut29 = sorgut29.ExecuteScalar().ToString();
                    s2030.BackColor = Color.Red;
                    s2030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s2030.Text = sorgua29.ExecuteScalar().ToString() + "\n" + ssorgut29 + "\n" + "20:30";

                }
                SqlCommand sorgua30 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);


                if (sorgua30.ExecuteScalar() != null)
                {
                    SqlCommand sorgut30 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                    string ssorgut30 = sorgut30.ExecuteScalar().ToString();
                    s2100.BackColor = Color.Red;
                    s2100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s2100.Text = sorgua30.ExecuteScalar().ToString() + "\n" + ssorgut30 + "\n" + "21:00";

                }

                SqlCommand sorgua31 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);


                if (sorgua31.ExecuteScalar() != null)
                {
                    SqlCommand sorgut31 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
                    string ssorgut31 = sorgut31.ExecuteScalar().ToString();
                    s2130.BackColor = Color.Red;
                    s2130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s2130.Text = sorgua31.ExecuteScalar().ToString() + "\n" + ssorgut31 + "\n" + "21:30";

                }
                SqlCommand sorgua32 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);


                if (sorgua32.ExecuteScalar() != null)
                {
                    SqlCommand sorgut32 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);
                    string ssorgut32 = sorgut32.ExecuteScalar().ToString();
                    s2200.BackColor = Color.Red;
                    s2200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    s2200.Text = sorgua32.ExecuteScalar().ToString() + "\n" + ssorgut32 + "\n" + "22:00";

                }

                bag.Close();


            }
            catch (Exception ec)
            {
                bag.Close();
                MessageBox.Show(ec.ToString());
            }
                
        }

        private void btnCarsamba_Click(object sender, EventArgs e)
        {
            btnPazartesi.BackColor = Color.Transparent;
            btnSali.BackColor = Color.Transparent;
            btnCarsamba.BackColor = Color.Silver;
            btnPersembe.BackColor = Color.Transparent;
            btnCuma.BackColor = Color.Transparent;
            btnCumartesi.BackColor = Color.Transparent;
            btnPazar.BackColor = Color.Transparent;

            gbPazar.Visible = false;
            gbCumartesi.Visible = false;
            gbCuma.Visible = false;
            gbPersembe.Visible = false;
            gbPazartesi.Visible = false;
            gbSali.Visible = false;
            gbCarsamba.Visible = true;

            string gg = "Çarşamba";
           

            try
            {
                bag.Open();
                SqlCommand sorgua = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);


                if (sorgua.ExecuteScalar() != null)
                {
                    SqlCommand sorgut = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);
                    string ssorgut = sorgut.ExecuteScalar().ToString();
                    cr0630.BackColor = Color.Red;
                    cr0630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr0630.Text = sorgua.ExecuteScalar().ToString() + "\n" + ssorgut + "\n" + "06:30";

                }
                SqlCommand sorgua2 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);


                if (sorgua2.ExecuteScalar() != null)
                {
                    SqlCommand sorgut2 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
                    string ssorgut2 = sorgut2.ExecuteScalar().ToString();
                   cr0700.BackColor = Color.Red;
                    cr0700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr0700.Text = sorgua2.ExecuteScalar().ToString() + "\n" + ssorgut2 + "\n" + "07:00";

                }

                SqlCommand sorgua3 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);

                if (sorgua3.ExecuteScalar() != null)
                {
                    SqlCommand sorgut3 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                    string ssorgut3 = sorgut3.ExecuteScalar().ToString();
                   cr0730.BackColor = Color.Red;
                   cr0730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr0730.Text = sorgua3.ExecuteScalar().ToString() + "\n" + ssorgut3 + "\n" + "07:30";

                }

                SqlCommand sorgua4 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);

                if (sorgua4.ExecuteScalar() != null)
                {
                    SqlCommand sorgut4 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
                    string ssorgut4 = sorgut4.ExecuteScalar().ToString();
                    cr0800.BackColor = Color.Red;
                    cr0800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr0800.Text = sorgua4.ExecuteScalar().ToString() + "\n" + ssorgut4 + "\n" + "08:00";

                }
                SqlCommand sorgua5 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);


                if (sorgua5.ExecuteScalar() != null)
                {
                    SqlCommand sorgut5 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
                    string ssorgut5 = sorgut5.ExecuteScalar().ToString();
                    cr0830.BackColor = Color.Red;
                    cr0830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr0830.Text = sorgua5.ExecuteScalar().ToString() + "\n" + ssorgut5 + "\n" + "08:30";

                }
                SqlCommand sorgua6 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);


                if (sorgua6.ExecuteScalar() != null)
                {
                    SqlCommand sorgut6 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
                    string ssorgut6 = sorgut6.ExecuteScalar().ToString();
                   cr0900.BackColor = Color.Red;
                    cr0900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr0900.Text = sorgua6.ExecuteScalar().ToString() + "\n" + ssorgut6 + "\n" + "09:00";

                }
                SqlCommand sorgua7 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);


                if (sorgua7.ExecuteScalar() != null)
                {
                    SqlCommand sorgut7 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
                    string ssorgut7 = sorgut7.ExecuteScalar().ToString();
                   cr0930.BackColor = Color.Red;
                    cr0930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr0930.Text = sorgua7.ExecuteScalar().ToString() + "\n" + ssorgut7 + "\n" + "09:30";

                }
                SqlCommand sorgua8 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);


                if (sorgua8.ExecuteScalar() != null)
                {
                    SqlCommand sorgut8 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                    string ssorgut8 = sorgut8.ExecuteScalar().ToString();
                    cr1000.BackColor = Color.Red;
                   cr1000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1000.Text = sorgua8.ExecuteScalar().ToString() + "\n" + ssorgut8 + "\n" + "10:00";

                }
                SqlCommand sorgua9 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);


                if (sorgua9.ExecuteScalar() != null)
                {
                    SqlCommand sorgut9 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
                    string ssorgut9 = sorgut9.ExecuteScalar().ToString();
                    cr1030.BackColor = Color.Red;
                    cr1030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr1030.Text = sorgua9.ExecuteScalar().ToString() + "\n" + ssorgut9 + "\n" + "10:30";

                }

                SqlCommand sorgua10 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);


                if (sorgua10.ExecuteScalar() != null)
                {
                    SqlCommand sorgut10 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
                    string ssorgut10 = sorgut10.ExecuteScalar().ToString();
                    cr1100.BackColor = Color.Red;
                    cr1100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1100.Text = sorgua10.ExecuteScalar().ToString() + "\n" + ssorgut10 + "\n" + "11:00";

                }
                SqlCommand sorgua11 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);


                if (sorgua11.ExecuteScalar() != null)
                {
                    SqlCommand sorgut11 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
                    string ssorgut11 = sorgut11.ExecuteScalar().ToString();
                    cr1130.BackColor = Color.Red;
                    cr1130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr1130.Text = sorgua11.ExecuteScalar().ToString() + "\n" + ssorgut11 + "\n" + "11:30";

                }
                SqlCommand sorgua12 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);


                if (sorgua12.ExecuteScalar() != null)
                {
                    SqlCommand sorgut12 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
                    string ssorgut12 = sorgut12.ExecuteScalar().ToString();
                    cr1200.BackColor = Color.Red;
                    cr1200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1200.Text = sorgua12.ExecuteScalar().ToString() + "\n" + ssorgut12 + "\n" + "12:00";

                }
                SqlCommand sorgua13 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);


                if (sorgua13.ExecuteScalar() != null)
                {
                    SqlCommand sorgut13 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
                    string ssorgut13 = sorgut13.ExecuteScalar().ToString();
                    cr1230.BackColor = Color.Red;
                    cr1230.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1230.Text = sorgua13.ExecuteScalar().ToString() + "\n" + ssorgut13 + "\n" + "12:30";

                }
                SqlCommand sorgua14 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);


                if (sorgua14.ExecuteScalar() != null)
                {
                    SqlCommand sorgut14 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
                    string ssorgut14 = sorgut14.ExecuteScalar().ToString();
                    cr1300.BackColor = Color.Red;
                   cr1300.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1300.Text = sorgua14.ExecuteScalar().ToString() + "\n" + ssorgut14 + "\n" + "13:00";

                }
                SqlCommand sorgua15 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);


                if (sorgua15.ExecuteScalar() != null)
                {
                    SqlCommand sorgut15 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                    string ssorgut15 = sorgut15.ExecuteScalar().ToString();
                    cr1330.BackColor = Color.Red;
                   cr1330.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr1330.Text = sorgua15.ExecuteScalar().ToString() + "\n" + ssorgut15 + "\n" + "13:30";

                }
                SqlCommand sorgua16 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);


                if (sorgua16.ExecuteScalar() != null)
                {
                    SqlCommand sorgut16 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
                    string ssorgut16 = sorgut16.ExecuteScalar().ToString();
                   cr1400.BackColor = Color.Red;
                    cr1400.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1400.Text = sorgua16.ExecuteScalar().ToString() + "\n" + ssorgut16 + "\n" + "14:00";

                }
                SqlCommand sorgua17 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);


                if (sorgua17.ExecuteScalar() != null)
                {
                    SqlCommand sorgut17 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
                    string ssorgut17 = sorgut17.ExecuteScalar().ToString();
                    cr1430.BackColor = Color.Red;
                    cr1430.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1430.Text = sorgua17.ExecuteScalar().ToString() + "\n" + ssorgut17 + "\n" + "14:30";

                }
                SqlCommand sorgua18 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);


                if (sorgua18.ExecuteScalar() != null)
                {
                    SqlCommand sorgut18 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
                    string ssorgut18 = sorgut18.ExecuteScalar().ToString();
                    cr1500.BackColor = Color.Red;
                   cr1500.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr1500.Text = sorgua18.ExecuteScalar().ToString() + "\n" + ssorgut18 + "\n" + "15:00";

                }
                SqlCommand sorgua19 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);


                if (sorgua19.ExecuteScalar() != null)
                {
                    SqlCommand sorgut19 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
                    string ssorgut19 = sorgut19.ExecuteScalar().ToString();
                    cr1530.BackColor = Color.Red;
                    cr1530.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr1530.Text = sorgua19.ExecuteScalar().ToString() + "\n" + ssorgut19 + "\n" + "15:30";

                }
                SqlCommand sorgua20 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);


                if (sorgua20.ExecuteScalar() != null)
                {
                    SqlCommand sorgut20 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
                    string ssorgut20 = sorgut20.ExecuteScalar().ToString();
                    cr1600.BackColor = Color.Red;
                    cr1600.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1600.Text = sorgua20.ExecuteScalar().ToString() + "\n" + ssorgut20 + "\n" + "16:00";

                }
                SqlCommand sorgua21 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);


                if (sorgua21.ExecuteScalar() != null)
                {
                    SqlCommand sorgut21 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
                    string ssorgut21 = sorgut21.ExecuteScalar().ToString();
                    cr1630.BackColor = Color.Red;
                    cr1630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1630.Text = sorgua21.ExecuteScalar().ToString() + "\n" + ssorgut21 + "\n" + "16:30";

                }
                SqlCommand sorgua22 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);


                if (sorgua22.ExecuteScalar() != null)
                {
                    SqlCommand sorgut22 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
                    string ssorgut22 = sorgut22.ExecuteScalar().ToString();
                    cr1700.BackColor = Color.Red;
                   cr1700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr1700.Text = sorgua22.ExecuteScalar().ToString() + "\n" + ssorgut22 + "\n" + "17:00";

                }
                SqlCommand sorgua23 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);


                if (sorgua23.ExecuteScalar() != null)
                {
                    SqlCommand sorgut23 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
                    string ssorgut23 = sorgut23.ExecuteScalar().ToString();
                    cr1730.BackColor = Color.Red;
                    cr1730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1730.Text = sorgua23.ExecuteScalar().ToString() + "\n" + ssorgut23 + "\n" + "17:30";

                }
                SqlCommand sorgua24 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);


                if (sorgua24.ExecuteScalar() != null)
                {
                    SqlCommand sorgut24 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                    string ssorgut24 = sorgut24.ExecuteScalar().ToString();
                    cr1800.BackColor = Color.Red;
                    cr1800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1800.Text = sorgua24.ExecuteScalar().ToString() + "\n" + ssorgut24 + "\n" + "18:00";

                }
                SqlCommand sorgua25 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);


                if (sorgua25.ExecuteScalar() != null)
                {
                    SqlCommand sorgut25 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
                    string ssorgut25 = sorgut25.ExecuteScalar().ToString();
                    cr1830.BackColor = Color.Red;
                    cr1830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1830.Text = sorgua25.ExecuteScalar().ToString() + "\n" + ssorgut25 + "\n" + "18:30";

                }
                SqlCommand sorgua26 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);


                if (sorgua26.ExecuteScalar() != null)
                {
                    SqlCommand sorgut26 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
                    string ssorgut26 = sorgut26.ExecuteScalar().ToString();
                    cr1900.BackColor = Color.Red;
                    cr1900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr1900.Text = sorgua26.ExecuteScalar().ToString() + "\n" + ssorgut26 + "\n" + "19:00";

                }
                SqlCommand sorgua27 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);


                if (sorgua27.ExecuteScalar() != null)
                {
                    SqlCommand sorgut27 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                    string ssorgut27 = sorgut27.ExecuteScalar().ToString();
                    cr1930.BackColor = Color.Red;
                    cr1930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr1930.Text = sorgua27.ExecuteScalar().ToString() + "\n" + ssorgut27 + "\n" + "19:30";

                }
                SqlCommand sorgua28 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);

                if (sorgua28.ExecuteScalar() != null)
                {
                    SqlCommand sorgut28 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
                    string ssorgut28 = sorgut28.ExecuteScalar().ToString();
                  cr2000.BackColor = Color.Red;
                   cr2000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr2000.Text = sorgua28.ExecuteScalar().ToString() + "\n" + ssorgut28 + "\n" + "20:00";

                }
                SqlCommand sorgua29 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);

                if (sorgua29.ExecuteScalar() != null)
                {
                    SqlCommand sorgut29 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
                    string ssorgut29 = sorgut29.ExecuteScalar().ToString();
                    cr2030.BackColor = Color.Red;
                    cr2030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr2030.Text = sorgua29.ExecuteScalar().ToString() + "\n" + ssorgut29 + "\n" + "20:30";

                }
                SqlCommand sorgua30 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);


                if (sorgua30.ExecuteScalar() != null)
                {
                    SqlCommand sorgut30 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                    string ssorgut30 = sorgut30.ExecuteScalar().ToString();
                   cr2100.BackColor = Color.Red;
                   cr2100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   cr2100.Text = sorgua30.ExecuteScalar().ToString() + "\n" + ssorgut30 + "\n" + "21:00";

                }

                SqlCommand sorgua31 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);


                if (sorgua31.ExecuteScalar() != null)
                {
                    SqlCommand sorgut31 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
                    string ssorgut31 = sorgut31.ExecuteScalar().ToString();
                    cr2130.BackColor = Color.Red;
                    cr2130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr2130.Text = sorgua31.ExecuteScalar().ToString() + "\n" + ssorgut31 + "\n" + "21:30";

                }
                SqlCommand sorgua32 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);


                if (sorgua32.ExecuteScalar() != null)
                {
                    SqlCommand sorgut32 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);
                    string ssorgut32 = sorgut32.ExecuteScalar().ToString();
                    cr2200.BackColor = Color.Red;
                    cr2200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    cr2200.Text = sorgua32.ExecuteScalar().ToString() + "\n" + ssorgut32 + "\n" + "22:00";

                }

                bag.Close();


            }
            catch (Exception ec)
            {
                bag.Close();
                MessageBox.Show(ec.ToString());
            }
                
        }

        private void btnPersembe_Click(object sender, EventArgs e)
        {
            btnPazartesi.BackColor = Color.Transparent;
            btnSali.BackColor = Color.Transparent;
            btnCarsamba.BackColor = Color.Transparent;
            btnPersembe.BackColor = Color.Silver;
            btnCuma.BackColor = Color.Transparent;
            btnCumartesi.BackColor = Color.Transparent;
            btnPazar.BackColor = Color.Transparent;

            gbPazar.Visible = false;
            gbCumartesi.Visible = false;
            gbCuma.Visible = false;
            gbCarsamba.Visible = false;
            gbPazartesi.Visible = false;
            gbSali.Visible = false;
            gbPersembe.Visible = true;

            string gg = "Perşembe";
           

            try
            {
                bag.Open();
                SqlCommand sorgua = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);


                if (sorgua.ExecuteScalar() != null)
                {
                    SqlCommand sorgut = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);
                    string ssorgut = sorgut.ExecuteScalar().ToString();
                    p0630.BackColor = Color.Red;
                    p0630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p0630.Text = sorgua.ExecuteScalar().ToString() + "\n" + ssorgut + "\n" + "06:30";

                }
                SqlCommand sorgua2 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);


                if (sorgua2.ExecuteScalar() != null)
                {
                    SqlCommand sorgut2 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
                    string ssorgut2 = sorgut2.ExecuteScalar().ToString();
                    p0700.BackColor = Color.Red;
                    p0700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p0700.Text = sorgua2.ExecuteScalar().ToString() + "\n" + ssorgut2 + "\n" + "07:00";

                }

                SqlCommand sorgua3 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);

                if (sorgua3.ExecuteScalar() != null)
                {
                    SqlCommand sorgut3 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                    string ssorgut3 = sorgut3.ExecuteScalar().ToString();
                    p0730.BackColor = Color.Red;
                    p0730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p0730.Text = sorgua3.ExecuteScalar().ToString() + "\n" + ssorgut3 + "\n" + "07:30";

                }

                SqlCommand sorgua4 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);

                if (sorgua4.ExecuteScalar() != null)
                {
                    SqlCommand sorgut4 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
                    string ssorgut4 = sorgut4.ExecuteScalar().ToString();
                    p0800.BackColor = Color.Red;
                    p0800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p0800.Text = sorgua4.ExecuteScalar().ToString() + "\n" + ssorgut4 + "\n" + "08:00";

                }
                SqlCommand sorgua5 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);


                if (sorgua5.ExecuteScalar() != null)
                {
                    SqlCommand sorgut5 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
                    string ssorgut5 = sorgut5.ExecuteScalar().ToString();
                    p0830.BackColor = Color.Red;
                    p0830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p0830.Text = sorgua5.ExecuteScalar().ToString() + "\n" + ssorgut5 + "\n" + "08:30";

                }
                SqlCommand sorgua6 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);


                if (sorgua6.ExecuteScalar() != null)
                {
                    SqlCommand sorgut6 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
                    string ssorgut6 = sorgut6.ExecuteScalar().ToString();
                    p0900.BackColor = Color.Red;
                    p0900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p0900.Text = sorgua6.ExecuteScalar().ToString() + "\n" + ssorgut6 + "\n" + "09:00";

                }
                SqlCommand sorgua7 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);


                if (sorgua7.ExecuteScalar() != null)
                {
                    SqlCommand sorgut7 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
                    string ssorgut7 = sorgut7.ExecuteScalar().ToString();
                    p0930.BackColor = Color.Red;
                    p0930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p0930.Text = sorgua7.ExecuteScalar().ToString() + "\n" + ssorgut7 + "\n" + "09:30";

                }
                SqlCommand sorgua8 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);


                if (sorgua8.ExecuteScalar() != null)
                {
                    SqlCommand sorgut8 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                    string ssorgut8 = sorgut8.ExecuteScalar().ToString();
                    p1000.BackColor = Color.Red;
                    p1000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1000.Text = sorgua8.ExecuteScalar().ToString() + "\n" + ssorgut8 + "\n" + "10:00";

                }
                SqlCommand sorgua9 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);


                if (sorgua9.ExecuteScalar() != null)
                {
                    SqlCommand sorgut9 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
                    string ssorgut9 = sorgut9.ExecuteScalar().ToString();
                    p1030.BackColor = Color.Red;
                    p1030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1030.Text = sorgua9.ExecuteScalar().ToString() + "\n" + ssorgut9 + "\n" + "10:30";

                }

                SqlCommand sorgua10 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);


                if (sorgua10.ExecuteScalar() != null)
                {
                    SqlCommand sorgut10 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
                    string ssorgut10 = sorgut10.ExecuteScalar().ToString();
                    p1100.BackColor = Color.Red;
                    p1100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1100.Text = sorgua10.ExecuteScalar().ToString() + "\n" + ssorgut10 + "\n" + "11:00";

                }
                SqlCommand sorgua11 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);


                if (sorgua11.ExecuteScalar() != null)
                {
                    SqlCommand sorgut11 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
                    string ssorgut11 = sorgut11.ExecuteScalar().ToString();
                    p1130.BackColor = Color.Red;
                    p1130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1130.Text = sorgua11.ExecuteScalar().ToString() + "\n" + ssorgut11 + "\n" + "11:30";

                }
                SqlCommand sorgua12 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);


                if (sorgua12.ExecuteScalar() != null)
                {
                    SqlCommand sorgut12 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
                    string ssorgut12 = sorgut12.ExecuteScalar().ToString();
                    p1200.BackColor = Color.Red;
                    p1200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1200.Text = sorgua12.ExecuteScalar().ToString() + "\n" + ssorgut12 + "\n" + "12:00";

                }
                SqlCommand sorgua13 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);


                if (sorgua13.ExecuteScalar() != null)
                {
                    SqlCommand sorgut13 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
                    string ssorgut13 = sorgut13.ExecuteScalar().ToString();
                    p1230.BackColor = Color.Red;
                    p1230.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1230.Text = sorgua13.ExecuteScalar().ToString() + "\n" + ssorgut13 + "\n" + "12:30";

                }
                SqlCommand sorgua14 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);


                if (sorgua14.ExecuteScalar() != null)
                {
                    SqlCommand sorgut14 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
                    string ssorgut14 = sorgut14.ExecuteScalar().ToString();
                    p1300.BackColor = Color.Red;
                    p1300.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1300.Text = sorgua14.ExecuteScalar().ToString() + "\n" + ssorgut14 + "\n" + "13:00";

                }
                SqlCommand sorgua15 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);


                if (sorgua15.ExecuteScalar() != null)
                {
                    SqlCommand sorgut15 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                    string ssorgut15 = sorgut15.ExecuteScalar().ToString();
                    p1330.BackColor = Color.Red;
                    p1330.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1330.Text = sorgua15.ExecuteScalar().ToString() + "\n" + ssorgut15 + "\n" + "13:30";

                }
                SqlCommand sorgua16 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);


                if (sorgua16.ExecuteScalar() != null)
                {
                    SqlCommand sorgut16 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
                    string ssorgut16 = sorgut16.ExecuteScalar().ToString();
                    p1400.BackColor = Color.Red;
                    p1400.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1400.Text = sorgua16.ExecuteScalar().ToString() + "\n" + ssorgut16 + "\n" + "14:00";

                }
                SqlCommand sorgua17 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);


                if (sorgua17.ExecuteScalar() != null)
                {
                    SqlCommand sorgut17 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
                    string ssorgut17 = sorgut17.ExecuteScalar().ToString();
                    p1430.BackColor = Color.Red;
                    p1430.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1430.Text = sorgua17.ExecuteScalar().ToString() + "\n" + ssorgut17 + "\n" + "14:30";

                }
                SqlCommand sorgua18 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);


                if (sorgua18.ExecuteScalar() != null)
                {
                    SqlCommand sorgut18 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
                    string ssorgut18 = sorgut18.ExecuteScalar().ToString();
                    p1500.BackColor = Color.Red;
                    p1500.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1500.Text = sorgua18.ExecuteScalar().ToString() + "\n" + ssorgut18 + "\n" + "15:00";

                }
                SqlCommand sorgua19 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);


                if (sorgua19.ExecuteScalar() != null)
                {
                    SqlCommand sorgut19 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
                    string ssorgut19 = sorgut19.ExecuteScalar().ToString();
                    p1530.BackColor = Color.Red;
                    p1530.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1530.Text = sorgua19.ExecuteScalar().ToString() + "\n" + ssorgut19 + "\n" + "15:30";

                }
                SqlCommand sorgua20 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);


                if (sorgua20.ExecuteScalar() != null)
                {
                    SqlCommand sorgut20 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
                    string ssorgut20 = sorgut20.ExecuteScalar().ToString();
                    p1600.BackColor = Color.Red;
                    p1600.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1600.Text = sorgua20.ExecuteScalar().ToString() + "\n" + ssorgut20 + "\n" + "16:00";

                }
                SqlCommand sorgua21 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);


                if (sorgua21.ExecuteScalar() != null)
                {
                    SqlCommand sorgut21 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
                    string ssorgut21 = sorgut21.ExecuteScalar().ToString();
                    p1630.BackColor = Color.Red;
                    p1630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1630.Text = sorgua21.ExecuteScalar().ToString() + "\n" + ssorgut21 + "\n" + "16:30";

                }
                SqlCommand sorgua22 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);


                if (sorgua22.ExecuteScalar() != null)
                {
                    SqlCommand sorgut22 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
                    string ssorgut22 = sorgut22.ExecuteScalar().ToString();
                    p1700.BackColor = Color.Red;
                    p1700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1700.Text = sorgua22.ExecuteScalar().ToString() + "\n" + ssorgut22 + "\n" + "17:00";

                }
                SqlCommand sorgua23 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);


                if (sorgua23.ExecuteScalar() != null)
                {
                    SqlCommand sorgut23 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
                    string ssorgut23 = sorgut23.ExecuteScalar().ToString();
                    p1730.BackColor = Color.Red;
                    p1730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1730.Text = sorgua23.ExecuteScalar().ToString() + "\n" + ssorgut23 + "\n" + "17:30";

                }
                SqlCommand sorgua24 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);


                if (sorgua24.ExecuteScalar() != null)
                {
                    SqlCommand sorgut24 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                    string ssorgut24 = sorgut24.ExecuteScalar().ToString();
                    p1800.BackColor = Color.Red;
                    p1800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1800.Text = sorgua24.ExecuteScalar().ToString() + "\n" + ssorgut24 + "\n" + "18:00";

                }
                SqlCommand sorgua25 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);


                if (sorgua25.ExecuteScalar() != null)
                {
                    SqlCommand sorgut25 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
                    string ssorgut25 = sorgut25.ExecuteScalar().ToString();
                    p1830.BackColor = Color.Red;
                    p1830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1830.Text = sorgua25.ExecuteScalar().ToString() + "\n" + ssorgut25 + "\n" + "18:30";

                }
                SqlCommand sorgua26 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);


                if (sorgua26.ExecuteScalar() != null)
                {
                    SqlCommand sorgut26 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
                    string ssorgut26 = sorgut26.ExecuteScalar().ToString();
                    p1900.BackColor = Color.Red;
                    p1900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1900.Text = sorgua26.ExecuteScalar().ToString() + "\n" + ssorgut26 + "\n" + "19:00";

                }
                SqlCommand sorgua27 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);


                if (sorgua27.ExecuteScalar() != null)
                {
                    SqlCommand sorgut27 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                    string ssorgut27 = sorgut27.ExecuteScalar().ToString();
                    p1930.BackColor = Color.Red;
                    p1930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p1930.Text = sorgua27.ExecuteScalar().ToString() + "\n" + ssorgut27 + "\n" + "19:30";

                }
                SqlCommand sorgua28 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);

                if (sorgua28.ExecuteScalar() != null)
                {
                    SqlCommand sorgut28 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
                    string ssorgut28 = sorgut28.ExecuteScalar().ToString();
                    p2000.BackColor = Color.Red;
                    p2000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p2000.Text = sorgua28.ExecuteScalar().ToString() + "\n" + ssorgut28 + "\n" + "20:00";

                }
                SqlCommand sorgua29 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);

                if (sorgua29.ExecuteScalar() != null)
                {
                    SqlCommand sorgut29 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
                    string ssorgut29 = sorgut29.ExecuteScalar().ToString();
                    p2030.BackColor = Color.Red;
                    p2030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p2030.Text = sorgua29.ExecuteScalar().ToString() + "\n" + ssorgut29 + "\n" + "20:30";

                }
                SqlCommand sorgua30 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);


                if (sorgua30.ExecuteScalar() != null)
                {
                    SqlCommand sorgut30 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                    string ssorgut30 = sorgut30.ExecuteScalar().ToString();
                    p2100.BackColor = Color.Red;
                    p2100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p2100.Text = sorgua30.ExecuteScalar().ToString() + "\n" + ssorgut30 + "\n" + "21:00";

                }

                SqlCommand sorgua31 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);


                if (sorgua31.ExecuteScalar() != null)
                {
                    SqlCommand sorgut31 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
                    string ssorgut31 = sorgut31.ExecuteScalar().ToString();
                    p2130.BackColor = Color.Red;
                    p2130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p2130.Text = sorgua31.ExecuteScalar().ToString() + "\n" + ssorgut31 + "\n" + "21:30";

                }
                SqlCommand sorgua32 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);


                if (sorgua32.ExecuteScalar() != null)
                {
                    SqlCommand sorgut32 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);
                    string ssorgut32 = sorgut32.ExecuteScalar().ToString();
                    p2200.BackColor = Color.Red;
                    p2200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    p2200.Text = sorgua32.ExecuteScalar().ToString() + "\n" + ssorgut32 + "\n" + "22:00";

                }

                bag.Close();


            }
            catch (Exception ec)
            {
                bag.Close();
                MessageBox.Show(ec.ToString());
            }
                
        }

        private void btnCuma_Click(object sender, EventArgs e)
        {
            btnPazartesi.BackColor = Color.Transparent;
            btnSali.BackColor = Color.Transparent;
            btnCarsamba.BackColor = Color.Transparent;
            btnPersembe.BackColor =Color.Transparent ;
            btnCuma.BackColor = Color.Silver;
            btnCumartesi.BackColor = Color.Transparent;
            btnPazar.BackColor = Color.Transparent;

            gbPazar.Visible = false;
            gbCumartesi.Visible = false;
            gbPersembe.Visible =false;
            gbCarsamba.Visible = false;
            gbPazartesi.Visible = false;
            gbSali.Visible = false;
            gbCuma.Visible =true;

            string gg = "Cuma";
            

            try
            {
                bag.Open();
                SqlCommand sorgua = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);


                if (sorgua.ExecuteScalar() != null)
                {
                    SqlCommand sorgut = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);
                    string ssorgut = sorgut.ExecuteScalar().ToString();
                    c0630.BackColor = Color.Red;
                    c0630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c0630.Text = sorgua.ExecuteScalar().ToString() + "\n" + ssorgut + "\n" + "06:30";

                }
                SqlCommand sorgua2 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);


                if (sorgua2.ExecuteScalar() != null)
                {
                    SqlCommand sorgut2 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
                    string ssorgut2 = sorgut2.ExecuteScalar().ToString();
                    c0700.BackColor = Color.Red;
                    c0700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c0700.Text = sorgua2.ExecuteScalar().ToString() + "\n" + ssorgut2 + "\n" + "07:00";

                }

                SqlCommand sorgua3 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);

                if (sorgua3.ExecuteScalar() != null)
                {
                    SqlCommand sorgut3 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                    string ssorgut3 = sorgut3.ExecuteScalar().ToString();
                    c0730.BackColor = Color.Red;
                    c0730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c0730.Text = sorgua3.ExecuteScalar().ToString() + "\n" + ssorgut3 + "\n" + "07:30";

                }

                SqlCommand sorgua4 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);

                if (sorgua4.ExecuteScalar() != null)
                {
                    SqlCommand sorgut4 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
                    string ssorgut4 = sorgut4.ExecuteScalar().ToString();
                    c0800.BackColor = Color.Red;
                    c0800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c0800.Text = sorgua4.ExecuteScalar().ToString() + "\n" + ssorgut4 + "\n" + "08:00";

                }
                SqlCommand sorgua5 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);


                if (sorgua5.ExecuteScalar() != null)
                {
                    SqlCommand sorgut5 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
                    string ssorgut5 = sorgut5.ExecuteScalar().ToString();
                    c0830.BackColor = Color.Red;
                    c0830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c0830.Text = sorgua5.ExecuteScalar().ToString() + "\n" + ssorgut5 + "\n" + "08:30";

                }
                SqlCommand sorgua6 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);


                if (sorgua6.ExecuteScalar() != null)
                {
                    SqlCommand sorgut6 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
                    string ssorgut6 = sorgut6.ExecuteScalar().ToString();
                    c0900.BackColor = Color.Red;
                    c0900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c0900.Text = sorgua6.ExecuteScalar().ToString() + "\n" + ssorgut6 + "\n" + "09:00";

                }
                SqlCommand sorgua7 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);


                if (sorgua7.ExecuteScalar() != null)
                {
                    SqlCommand sorgut7 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
                    string ssorgut7 = sorgut7.ExecuteScalar().ToString();
                    c0930.BackColor = Color.Red;
                    c0930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c0930.Text = sorgua7.ExecuteScalar().ToString() + "\n" + ssorgut7 + "\n" + "09:30";

                }
                SqlCommand sorgua8 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);


                if (sorgua8.ExecuteScalar() != null)
                {
                    SqlCommand sorgut8 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                    string ssorgut8 = sorgut8.ExecuteScalar().ToString();
                    c1000.BackColor = Color.Red;
                    c1000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1000.Text = sorgua8.ExecuteScalar().ToString() + "\n" + ssorgut8 + "\n" + "10:00";

                }
                SqlCommand sorgua9 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);


                if (sorgua9.ExecuteScalar() != null)
                {
                    SqlCommand sorgut9 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
                    string ssorgut9 = sorgut9.ExecuteScalar().ToString();
                    c1030.BackColor = Color.Red;
                    c1030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1030.Text = sorgua9.ExecuteScalar().ToString() + "\n" + ssorgut9 + "\n" + "10:30";

                }

                SqlCommand sorgua10 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);


                if (sorgua10.ExecuteScalar() != null)
                {
                    SqlCommand sorgut10 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
                    string ssorgut10 = sorgut10.ExecuteScalar().ToString();
                    c1100.BackColor = Color.Red;
                    c1100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1100.Text = sorgua10.ExecuteScalar().ToString() + "\n" + ssorgut10 + "\n" + "11:00";

                }
                SqlCommand sorgua11 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);


                if (sorgua11.ExecuteScalar() != null)
                {
                    SqlCommand sorgut11 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
                    string ssorgut11 = sorgut11.ExecuteScalar().ToString();
                    c1130.BackColor = Color.Red;
                    c1130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1130.Text = sorgua11.ExecuteScalar().ToString() + "\n" + ssorgut11 + "\n" + "11:30";

                }
                SqlCommand sorgua12 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);


                if (sorgua12.ExecuteScalar() != null)
                {
                    SqlCommand sorgut12 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
                    string ssorgut12 = sorgut12.ExecuteScalar().ToString();
                    c1200.BackColor = Color.Red;
                    c1200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1200.Text = sorgua12.ExecuteScalar().ToString() + "\n" + ssorgut12 + "\n" + "12:00";

                }
                SqlCommand sorgua13 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);


                if (sorgua13.ExecuteScalar() != null)
                {
                    SqlCommand sorgut13 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
                    string ssorgut13 = sorgut13.ExecuteScalar().ToString();
                    c1230.BackColor = Color.Red;
                    c1230.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1230.Text = sorgua13.ExecuteScalar().ToString() + "\n" + ssorgut13 + "\n" + "12:30";

                }
                SqlCommand sorgua14 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);


                if (sorgua14.ExecuteScalar() != null)
                {
                    SqlCommand sorgut14 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
                    string ssorgut14 = sorgut14.ExecuteScalar().ToString();
                    c1300.BackColor = Color.Red;
                    c1300.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1300.Text = sorgua14.ExecuteScalar().ToString() + "\n" + ssorgut14 + "\n" + "13:00";

                }
                SqlCommand sorgua15 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);


                if (sorgua15.ExecuteScalar() != null)
                {
                    SqlCommand sorgut15 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                    string ssorgut15 = sorgut15.ExecuteScalar().ToString();
                    c1330.BackColor = Color.Red;
                    c1330.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1330.Text = sorgua15.ExecuteScalar().ToString() + "\n" + ssorgut15 + "\n" + "13:30";

                }
                SqlCommand sorgua16 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);


                if (sorgua16.ExecuteScalar() != null)
                {
                    SqlCommand sorgut16 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
                    string ssorgut16 = sorgut16.ExecuteScalar().ToString();
                    c1400.BackColor = Color.Red;
                    c1400.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1400.Text = sorgua16.ExecuteScalar().ToString() + "\n" + ssorgut16 + "\n" + "14:00";

                }
                SqlCommand sorgua17 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);


                if (sorgua17.ExecuteScalar() != null)
                {
                    SqlCommand sorgut17 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
                    string ssorgut17 = sorgut17.ExecuteScalar().ToString();
                    c1430.BackColor = Color.Red;
                    c1430.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1430.Text = sorgua17.ExecuteScalar().ToString() + "\n" + ssorgut17 + "\n" + "14:30";

                }
                SqlCommand sorgua18 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);


                if (sorgua18.ExecuteScalar() != null)
                {
                    SqlCommand sorgut18 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
                    string ssorgut18 = sorgut18.ExecuteScalar().ToString();
                    c1500.BackColor = Color.Red;
                    c1500.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1500.Text = sorgua18.ExecuteScalar().ToString() + "\n" + ssorgut18 + "\n" + "15:00";

                }
                SqlCommand sorgua19 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);


                if (sorgua19.ExecuteScalar() != null)
                {
                    SqlCommand sorgut19 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
                    string ssorgut19 = sorgut19.ExecuteScalar().ToString();
                    c1530.BackColor = Color.Red;
                    c1530.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1530.Text = sorgua19.ExecuteScalar().ToString() + "\n" + ssorgut19 + "\n" + "15:30";

                }
                SqlCommand sorgua20 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);


                if (sorgua20.ExecuteScalar() != null)
                {
                    SqlCommand sorgut20 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
                    string ssorgut20 = sorgut20.ExecuteScalar().ToString();
                    c1600.BackColor = Color.Red;
                    c1600.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1600.Text = sorgua20.ExecuteScalar().ToString() + "\n" + ssorgut20 + "\n" + "16:00";

                }
                SqlCommand sorgua21 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);


                if (sorgua21.ExecuteScalar() != null)
                {
                    SqlCommand sorgut21 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
                    string ssorgut21 = sorgut21.ExecuteScalar().ToString();
                    c1630.BackColor = Color.Red;
                    c1630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1630.Text = sorgua21.ExecuteScalar().ToString() + "\n" + ssorgut21 + "\n" + "16:30";

                }
                SqlCommand sorgua22 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);


                if (sorgua22.ExecuteScalar() != null)
                {
                    SqlCommand sorgut22 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
                    string ssorgut22 = sorgut22.ExecuteScalar().ToString();
                    c1700.BackColor = Color.Red;
                    c1700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1700.Text = sorgua22.ExecuteScalar().ToString() + "\n" + ssorgut22 + "\n" + "17:00";

                }
                SqlCommand sorgua23 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);


                if (sorgua23.ExecuteScalar() != null)
                {
                    SqlCommand sorgut23 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
                    string ssorgut23 = sorgut23.ExecuteScalar().ToString();
                    c1730.BackColor = Color.Red;
                    c1730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1730.Text = sorgua23.ExecuteScalar().ToString() + "\n" + ssorgut23 + "\n" + "17:30";

                }
                SqlCommand sorgua24 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);


                if (sorgua24.ExecuteScalar() != null)
                {
                    SqlCommand sorgut24 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                    string ssorgut24 = sorgut24.ExecuteScalar().ToString();
                    c1800.BackColor = Color.Red;
                    c1800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1800.Text = sorgua24.ExecuteScalar().ToString() + "\n" + ssorgut24 + "\n" + "18:00";

                }
                SqlCommand sorgua25 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);


                if (sorgua25.ExecuteScalar() != null)
                {
                    SqlCommand sorgut25 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
                    string ssorgut25 = sorgut25.ExecuteScalar().ToString();
                    c1830.BackColor = Color.Red;
                    c1830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1830.Text = sorgua25.ExecuteScalar().ToString() + "\n" + ssorgut25 + "\n" + "18:30";

                }
                SqlCommand sorgua26 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);


                if (sorgua26.ExecuteScalar() != null)
                {
                    SqlCommand sorgut26 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
                    string ssorgut26 = sorgut26.ExecuteScalar().ToString();
                    c1900.BackColor = Color.Red;
                    c1900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1900.Text = sorgua26.ExecuteScalar().ToString() + "\n" + ssorgut26 + "\n" + "19:00";

                }
                SqlCommand sorgua27 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);


                if (sorgua27.ExecuteScalar() != null)
                {
                    SqlCommand sorgut27 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                    string ssorgut27 = sorgut27.ExecuteScalar().ToString();
                    c1930.BackColor = Color.Red;
                    c1930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c1930.Text = sorgua27.ExecuteScalar().ToString() + "\n" + ssorgut27 + "\n" + "19:30";

                }
                SqlCommand sorgua28 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);

                if (sorgua28.ExecuteScalar() != null)
                {
                    SqlCommand sorgut28 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
                    string ssorgut28 = sorgut28.ExecuteScalar().ToString();
                    c2000.BackColor = Color.Red;
                    c2000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c2000.Text = sorgua28.ExecuteScalar().ToString() + "\n" + ssorgut28 + "\n" + "20:00";

                }
                SqlCommand sorgua29 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);

                if (sorgua29.ExecuteScalar() != null)
                {
                    SqlCommand sorgut29 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
                    string ssorgut29 = sorgut29.ExecuteScalar().ToString();
                    c2030.BackColor = Color.Red;
                    c2030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c2030.Text = sorgua29.ExecuteScalar().ToString() + "\n" + ssorgut29 + "\n" + "20:30";

                }
                SqlCommand sorgua30 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);


                if (sorgua30.ExecuteScalar() != null)
                {
                    SqlCommand sorgut30 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                    string ssorgut30 = sorgut30.ExecuteScalar().ToString();
                    c2100.BackColor = Color.Red;
                    c2100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c2100.Text = sorgua30.ExecuteScalar().ToString() + "\n" + ssorgut30 + "\n" + "21:00";

                }

                SqlCommand sorgua31 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);


                if (sorgua31.ExecuteScalar() != null)
                {
                    SqlCommand sorgut31 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
                    string ssorgut31 = sorgut31.ExecuteScalar().ToString();
                    c2130.BackColor = Color.Red;
                    c2130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c2130.Text = sorgua31.ExecuteScalar().ToString() + "\n" + ssorgut31 + "\n" + "21:30";

                }
                SqlCommand sorgua32 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);


                if (sorgua32.ExecuteScalar() != null)
                {
                    SqlCommand sorgut32 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);
                    string ssorgut32 = sorgut32.ExecuteScalar().ToString();
                    c2200.BackColor = Color.Red;
                    c2200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    c2200.Text = sorgua32.ExecuteScalar().ToString() + "\n" + ssorgut32 + "\n" + "22:00";

                }

                bag.Close();


            }
            catch (Exception ec)
            {
                bag.Close();
                MessageBox.Show(ec.ToString());
            }
                
        }

        private void btnCumartesi_Click(object sender, EventArgs e)
        {
            btnPazartesi.BackColor = Color.Transparent;
            btnSali.BackColor = Color.Transparent;
            btnCarsamba.BackColor = Color.Transparent;
            btnPersembe.BackColor = Color.Transparent;
            btnCuma.BackColor = Color.Transparent;
            btnCumartesi.BackColor = Color.Silver;
            btnPazar.BackColor = Color.Transparent;

            gbPazar.Visible = false;
            gbCuma.Visible = false;
            gbPersembe.Visible = false;
            gbCarsamba.Visible = false;
            gbPazartesi.Visible = false;
            gbSali.Visible = false;
            gbCumartesi.Visible =true;
            string gg = "Cumartesi";
         

            try
            {
                bag.Open();
                SqlCommand sorgua = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);


                if (sorgua.ExecuteScalar() != null)
                {
                    SqlCommand sorgut = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);
                    string ssorgut = sorgut.ExecuteScalar().ToString();
                    ct0630.BackColor = Color.Red;
                    ct0630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct0630.Text = sorgua.ExecuteScalar().ToString() + "\n" + ssorgut + "\n" + "06:30";

                }
                SqlCommand sorgua2 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);


                if (sorgua2.ExecuteScalar() != null)
                {
                    SqlCommand sorgut2 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
                    string ssorgut2 = sorgut2.ExecuteScalar().ToString();
                    ct0700.BackColor = Color.Red;
                    ct0700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct0700.Text = sorgua2.ExecuteScalar().ToString() + "\n" + ssorgut2 + "\n" + "07:00";

                }

                SqlCommand sorgua3 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);

                if (sorgua3.ExecuteScalar() != null)
                {
                    SqlCommand sorgut3 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                    string ssorgut3 = sorgut3.ExecuteScalar().ToString();
                    ct0730.BackColor = Color.Red;
                    ct0730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct0730.Text = sorgua3.ExecuteScalar().ToString() + "\n" + ssorgut3 + "\n" + "07:30";

                }

                SqlCommand sorgua4 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);

                if (sorgua4.ExecuteScalar() != null)
                {
                    SqlCommand sorgut4 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
                    string ssorgut4 = sorgut4.ExecuteScalar().ToString();
                    ct0800.BackColor = Color.Red;
                    ct0800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct0800.Text = sorgua4.ExecuteScalar().ToString() + "\n" + ssorgut4 + "\n" + "08:00";

                }
                SqlCommand sorgua5 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);


                if (sorgua5.ExecuteScalar() != null)
                {
                    SqlCommand sorgut5 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
                    string ssorgut5 = sorgut5.ExecuteScalar().ToString();
                    ct0830.BackColor = Color.Red;
                    ct0830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct0830.Text = sorgua5.ExecuteScalar().ToString() + "\n" + ssorgut5 + "\n" + "08:30";

                }
                SqlCommand sorgua6 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);


                if (sorgua6.ExecuteScalar() != null)
                {
                    SqlCommand sorgut6 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
                    string ssorgut6 = sorgut6.ExecuteScalar().ToString();
                    ct0900.BackColor = Color.Red;
                    ct0900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct0900.Text = sorgua6.ExecuteScalar().ToString() + "\n" + ssorgut6 + "\n" + "09:00";

                }
                SqlCommand sorgua7 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);


                if (sorgua7.ExecuteScalar() != null)
                {
                    SqlCommand sorgut7 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
                    string ssorgut7 = sorgut7.ExecuteScalar().ToString();
                    ct0930.BackColor = Color.Red;
                    ct0930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct0930.Text = sorgua7.ExecuteScalar().ToString() + "\n" + ssorgut7 + "\n" + "09:30";

                }
                SqlCommand sorgua8 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);


                if (sorgua8.ExecuteScalar() != null)
                {
                    SqlCommand sorgut8 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                    string ssorgut8 = sorgut8.ExecuteScalar().ToString();
                    ct1000.BackColor = Color.Red;
                    ct1000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1000.Text = sorgua8.ExecuteScalar().ToString() + "\n" + ssorgut8 + "\n" + "10:00";

                }
                SqlCommand sorgua9 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);


                if (sorgua9.ExecuteScalar() != null)
                {
                    SqlCommand sorgut9 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
                    string ssorgut9 = sorgut9.ExecuteScalar().ToString();
                    ct1030.BackColor = Color.Red;
                    ct1030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1030.Text = sorgua9.ExecuteScalar().ToString() + "\n" + ssorgut9 + "\n" + "10:30";

                }

                SqlCommand sorgua10 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);


                if (sorgua10.ExecuteScalar() != null)
                {
                    SqlCommand sorgut10 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
                    string ssorgut10 = sorgut10.ExecuteScalar().ToString();
                    ct1100.BackColor = Color.Red;
                    ct1100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1100.Text = sorgua10.ExecuteScalar().ToString() + "\n" + ssorgut10 + "\n" + "11:00";

                }
                SqlCommand sorgua11 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);


                if (sorgua11.ExecuteScalar() != null)
                {
                    SqlCommand sorgut11 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
                    string ssorgut11 = sorgut11.ExecuteScalar().ToString();
                    ct1130.BackColor = Color.Red;
                    ct1130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1130.Text = sorgua11.ExecuteScalar().ToString() + "\n" + ssorgut11 + "\n" + "11:30";

                }
                SqlCommand sorgua12 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);


                if (sorgua12.ExecuteScalar() != null)
                {
                    SqlCommand sorgut12 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
                    string ssorgut12 = sorgut12.ExecuteScalar().ToString();
                    ct1200.BackColor = Color.Red;
                    ct1200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1200.Text = sorgua12.ExecuteScalar().ToString() + "\n" + ssorgut12 + "\n" + "12:00";

                }
                SqlCommand sorgua13 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);


                if (sorgua13.ExecuteScalar() != null)
                {
                    SqlCommand sorgut13 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
                    string ssorgut13 = sorgut13.ExecuteScalar().ToString();
                    ct1230.BackColor = Color.Red;
                    ct1230.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1230.Text = sorgua13.ExecuteScalar().ToString() + "\n" + ssorgut13 + "\n" + "12:30";

                }
                SqlCommand sorgua14 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);


                if (sorgua14.ExecuteScalar() != null)
                {
                    SqlCommand sorgut14 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
                    string ssorgut14 = sorgut14.ExecuteScalar().ToString();
                    ct1300.BackColor = Color.Red;
                    ct1300.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1300.Text = sorgua14.ExecuteScalar().ToString() + "\n" + ssorgut14 + "\n" + "13:00";

                }
                SqlCommand sorgua15 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);


                if (sorgua15.ExecuteScalar() != null)
                {
                    SqlCommand sorgut15 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                    string ssorgut15 = sorgut15.ExecuteScalar().ToString();
                    ct1330.BackColor = Color.Red;
                   ct1330.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1330.Text = sorgua15.ExecuteScalar().ToString() + "\n" + ssorgut15 + "\n" + "13:30";

                }
                SqlCommand sorgua16 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);


                if (sorgua16.ExecuteScalar() != null)
                {
                    SqlCommand sorgut16 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
                    string ssorgut16 = sorgut16.ExecuteScalar().ToString();
                    ct1400.BackColor = Color.Red;
                    ct1400.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1400.Text = sorgua16.ExecuteScalar().ToString() + "\n" + ssorgut16 + "\n" + "14:00";

                }
                SqlCommand sorgua17 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);


                if (sorgua17.ExecuteScalar() != null)
                {
                    SqlCommand sorgut17 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
                    string ssorgut17 = sorgut17.ExecuteScalar().ToString();
                    ct1430.BackColor = Color.Red;
                    ct1430.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1430.Text = sorgua17.ExecuteScalar().ToString() + "\n" + ssorgut17 + "\n" + "14:30";

                }
                SqlCommand sorgua18 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);


                if (sorgua18.ExecuteScalar() != null)
                {
                    SqlCommand sorgut18 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
                    string ssorgut18 = sorgut18.ExecuteScalar().ToString();
                    ct1500.BackColor = Color.Red;
                   ct1500.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1500.Text = sorgua18.ExecuteScalar().ToString() + "\n" + ssorgut18 + "\n" + "15:00";

                }
                SqlCommand sorgua19 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);


                if (sorgua19.ExecuteScalar() != null)
                {
                    SqlCommand sorgut19 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
                    string ssorgut19 = sorgut19.ExecuteScalar().ToString();
                    ct1530.BackColor = Color.Red;
                    ct1530.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1530.Text = sorgua19.ExecuteScalar().ToString() + "\n" + ssorgut19 + "\n" + "15:30";

                }
                SqlCommand sorgua20 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);


                if (sorgua20.ExecuteScalar() != null)
                {
                    SqlCommand sorgut20 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
                    string ssorgut20 = sorgut20.ExecuteScalar().ToString();
                    ct1600.BackColor = Color.Red;
                    ct1600.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1600.Text = sorgua20.ExecuteScalar().ToString() + "\n" + ssorgut20 + "\n" + "16:00";

                }
                SqlCommand sorgua21 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);


                if (sorgua21.ExecuteScalar() != null)
                {
                    SqlCommand sorgut21 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
                    string ssorgut21 = sorgut21.ExecuteScalar().ToString();
                    ct1630.BackColor = Color.Red;
                    ct1630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   ct1630.Text = sorgua21.ExecuteScalar().ToString() + "\n" + ssorgut21 + "\n" + "16:30";

                }
                SqlCommand sorgua22 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);


                if (sorgua22.ExecuteScalar() != null)
                {
                    SqlCommand sorgut22 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
                    string ssorgut22 = sorgut22.ExecuteScalar().ToString();
                    ct1700.BackColor = Color.Red;
                    ct1700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1700.Text = sorgua22.ExecuteScalar().ToString() + "\n" + ssorgut22 + "\n" + "17:00";

                }
                SqlCommand sorgua23 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);


                if (sorgua23.ExecuteScalar() != null)
                {
                    SqlCommand sorgut23 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
                    string ssorgut23 = sorgut23.ExecuteScalar().ToString();
                    ct1730.BackColor = Color.Red;
                    ct1730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1730.Text = sorgua23.ExecuteScalar().ToString() + "\n" + ssorgut23 + "\n" + "17:30";

                }
                SqlCommand sorgua24 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);


                if (sorgua24.ExecuteScalar() != null)
                {
                    SqlCommand sorgut24 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                    string ssorgut24 = sorgut24.ExecuteScalar().ToString();
                    ct1800.BackColor = Color.Red;
                    ct1800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1800.Text = sorgua24.ExecuteScalar().ToString() + "\n" + ssorgut24 + "\n" + "18:00";

                }
                SqlCommand sorgua25 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);


                if (sorgua25.ExecuteScalar() != null)
                {
                    SqlCommand sorgut25 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
                    string ssorgut25 = sorgut25.ExecuteScalar().ToString();
                    ct1830.BackColor = Color.Red;
                    ct1830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                   ct1830.Text = sorgua25.ExecuteScalar().ToString() + "\n" + ssorgut25 + "\n" + "18:30";

                }
                SqlCommand sorgua26 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);


                if (sorgua26.ExecuteScalar() != null)
                {
                    SqlCommand sorgut26 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
                    string ssorgut26 = sorgut26.ExecuteScalar().ToString();
                    ct1900.BackColor = Color.Red;
                    ct1900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1900.Text = sorgua26.ExecuteScalar().ToString() + "\n" + ssorgut26 + "\n" + "19:00";

                }
                SqlCommand sorgua27 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);


                if (sorgua27.ExecuteScalar() != null)
                {
                    SqlCommand sorgut27 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                    string ssorgut27 = sorgut27.ExecuteScalar().ToString();
                    ct1930.BackColor = Color.Red;
                   ct1930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct1930.Text = sorgua27.ExecuteScalar().ToString() + "\n" + ssorgut27 + "\n" + "19:30";

                }
                SqlCommand sorgua28 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);

                if (sorgua28.ExecuteScalar() != null)
                {
                    SqlCommand sorgut28 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
                    string ssorgut28 = sorgut28.ExecuteScalar().ToString();
                    ct2000.BackColor = Color.Red;
                    ct2000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct2000.Text = sorgua28.ExecuteScalar().ToString() + "\n" + ssorgut28 + "\n" + "20:00";

                }
                SqlCommand sorgua29 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);

                if (sorgua29.ExecuteScalar() != null)
                {
                    SqlCommand sorgut29 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
                    string ssorgut29 = sorgut29.ExecuteScalar().ToString();
                    ct2030.BackColor = Color.Red;
                    ct2030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct2030.Text = sorgua29.ExecuteScalar().ToString() + "\n" + ssorgut29 + "\n" + "20:30";

                }
                SqlCommand sorgua30 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);


                if (sorgua30.ExecuteScalar() != null)
                {
                    SqlCommand sorgut30 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                    string ssorgut30 = sorgut30.ExecuteScalar().ToString();
                    ct2100.BackColor = Color.Red;
                    ct2100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct2100.Text = sorgua30.ExecuteScalar().ToString() + "\n" + ssorgut30 + "\n" + "21:00";

                }

                SqlCommand sorgua31 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);


                if (sorgua31.ExecuteScalar() != null)
                {
                    SqlCommand sorgut31 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
                    string ssorgut31 = sorgut31.ExecuteScalar().ToString();
                    ct2130.BackColor = Color.Red;
                    ct2130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct2130.Text = sorgua31.ExecuteScalar().ToString() + "\n" + ssorgut31 + "\n" + "21:30";

                }
                SqlCommand sorgua32 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);


                if (sorgua32.ExecuteScalar() != null)
                {
                    SqlCommand sorgut32 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);
                    string ssorgut32 = sorgut32.ExecuteScalar().ToString();
                    ct2200.BackColor = Color.Red;
                    ct2200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    ct2200.Text = sorgua32.ExecuteScalar().ToString() + "\n" + ssorgut32 + "\n" + "22:00";

                }

                bag.Close();


            }
            catch (Exception ec)
            {
                bag.Close();
                MessageBox.Show(ec.ToString());
            }
                
        }

        private void btnPazar_Click(object sender, EventArgs e)
        {

            btnPazartesi.BackColor = Color.Transparent;
            btnSali.BackColor = Color.Transparent;
            btnCarsamba.BackColor = Color.Transparent;
            btnPersembe.BackColor = Color.Transparent;
            btnCuma.BackColor = Color.Transparent;
            btnCumartesi.BackColor = Color.Transparent;
            btnPazar.BackColor = Color.Silver;
          
            gbCuma.Visible = false;
            gbPersembe.Visible = false;
            gbCarsamba.Visible = false;
            gbPazartesi.Visible = false;
            gbSali.Visible = false;
            gbCumartesi.Visible =false;
            gbPazar.Visible =true;
            string gg = "Pazar";
           

            try
            {
                bag.Open();
                SqlCommand sorgua = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);


                if (sorgua.ExecuteScalar() != null)
                {
                    SqlCommand sorgut = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and (Giris='06:30' or Cikis='06:30')", bag);
                    string ssorgut = sorgut.ExecuteScalar().ToString();
                    pz0630.BackColor = Color.Red;
                    pz0630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz0630.Text = sorgua.ExecuteScalar().ToString() + "\n" + ssorgut + "\n" + "06:30";

                }
                SqlCommand sorgua2 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);


                if (sorgua2.ExecuteScalar() != null)
                {
                    SqlCommand sorgut2 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:00' or Cikis='07:00') or (Giris='06:30' or Cikis='07:30'))", bag);
                    string ssorgut2 = sorgut2.ExecuteScalar().ToString();
                    pz0700.BackColor = Color.Red;
                    pz0700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz0700.Text = sorgua2.ExecuteScalar().ToString() + "\n" + ssorgut2 + "\n" + "07:00";

                }

                SqlCommand sorgua3 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);

                if (sorgua3.ExecuteScalar() != null)
                {
                    SqlCommand sorgut3 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='07:30' or Cikis='07:30') or (Giris='07:00' or Cikis='08:00'))", bag);
                    string ssorgut3 = sorgut3.ExecuteScalar().ToString();
                    pz0730.BackColor = Color.Red;
                    pz0730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz0730.Text = sorgua3.ExecuteScalar().ToString() + "\n" + ssorgut3 + "\n" + "07:30";

                }

                SqlCommand sorgua4 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);

                if (sorgua4.ExecuteScalar() != null)
                {
                    SqlCommand sorgut4 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:00' or Cikis='08:00') or (Giris='07:30' or Cikis='08:30'))", bag);
                    string ssorgut4 = sorgut4.ExecuteScalar().ToString();
                    pz0800.BackColor = Color.Red;
                    pz0800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz0800.Text = sorgua4.ExecuteScalar().ToString() + "\n" + ssorgut4 + "\n" + "08:00";

                }
                SqlCommand sorgua5 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);


                if (sorgua5.ExecuteScalar() != null)
                {
                    SqlCommand sorgut5 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='08:30' or Cikis='08:30') or (Giris='08:00' or Cikis='09:00'))", bag);
                    string ssorgut5 = sorgut5.ExecuteScalar().ToString();
                    pz0830.BackColor = Color.Red;
                    pz0830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz0830.Text = sorgua5.ExecuteScalar().ToString() + "\n" + ssorgut5 + "\n" + "08:30";

                }
                SqlCommand sorgua6 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);


                if (sorgua6.ExecuteScalar() != null)
                {
                    SqlCommand sorgut6 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:00' or Cikis='09:00') or (Giris='08:30' or Cikis='09:30'))", bag);
                    string ssorgut6 = sorgut6.ExecuteScalar().ToString();
                    pz0900.BackColor = Color.Red;
                    pz0900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz0900.Text = sorgua6.ExecuteScalar().ToString() + "\n" + ssorgut6 + "\n" + "09:00";

                }
                SqlCommand sorgua7 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);


                if (sorgua7.ExecuteScalar() != null)
                {
                    SqlCommand sorgut7 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='09:30' or Cikis='09:30') or (Giris='09:00' or Cikis='10:00'))", bag);
                    string ssorgut7 = sorgut7.ExecuteScalar().ToString();
                    pz0930.BackColor = Color.Red;
                    pz0930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz0930.Text = sorgua7.ExecuteScalar().ToString() + "\n" + ssorgut7 + "\n" + "09:30";

                }
                SqlCommand sorgua8 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);


                if (sorgua8.ExecuteScalar() != null)
                {
                    SqlCommand sorgut8 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:00' or Cikis='10:00') or (Giris='09:30' or Cikis='10:30'))", bag);
                    string ssorgut8 = sorgut8.ExecuteScalar().ToString();
                    pz1000.BackColor = Color.Red;
                    pz1000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1000.Text = sorgua8.ExecuteScalar().ToString() + "\n" + ssorgut8 + "\n" + "10:00";

                }
                SqlCommand sorgua9 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);


                if (sorgua9.ExecuteScalar() != null)
                {
                    SqlCommand sorgut9 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='10:30' or Cikis='10:30') or (Giris='10:00' or Cikis='11:00'))", bag);
                    string ssorgut9 = sorgut9.ExecuteScalar().ToString();
                    pz1030.BackColor = Color.Red;
                    pz1030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1030.Text = sorgua9.ExecuteScalar().ToString() + "\n" + ssorgut9 + "\n" + "10:30";

                }

                SqlCommand sorgua10 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);


                if (sorgua10.ExecuteScalar() != null)
                {
                    SqlCommand sorgut10 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:00' or Cikis='11:00') or (Giris='10:30' or Cikis='11:30'))", bag);
                    string ssorgut10 = sorgut10.ExecuteScalar().ToString();
                    pz1100.BackColor = Color.Red;
                    pz1100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1100.Text = sorgua10.ExecuteScalar().ToString() + "\n" + ssorgut10 + "\n" + "11:00";

                }
                SqlCommand sorgua11 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);


                if (sorgua11.ExecuteScalar() != null)
                {
                    SqlCommand sorgut11 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='11:30' or Cikis='11:30') or (Giris='11:00' or Cikis='12:00'))", bag);
                    string ssorgut11 = sorgut11.ExecuteScalar().ToString();
                    pz1130.BackColor = Color.Red;
                    pz1130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1130.Text = sorgua11.ExecuteScalar().ToString() + "\n" + ssorgut11 + "\n" + "11:30";

                }
                SqlCommand sorgua12 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);


                if (sorgua12.ExecuteScalar() != null)
                {
                    SqlCommand sorgut12 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:00' or Cikis='12:00') or (Giris='11:30' or Cikis='12:30'))", bag);
                    string ssorgut12 = sorgut12.ExecuteScalar().ToString();
                    pz1200.BackColor = Color.Red;
                    pz1200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1200.Text = sorgua12.ExecuteScalar().ToString() + "\n" + ssorgut12 + "\n" + "12:00";

                }
                SqlCommand sorgua13 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);


                if (sorgua13.ExecuteScalar() != null)
                {
                    SqlCommand sorgut13 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='12:30' or Cikis='12:30') or (Giris='12:00' or Cikis='13:00'))", bag);
                    string ssorgut13 = sorgut13.ExecuteScalar().ToString();
                    pz1230.BackColor = Color.Red;
                    pz1230.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1230.Text = sorgua13.ExecuteScalar().ToString() + "\n" + ssorgut13 + "\n" + "12:30";

                }
                SqlCommand sorgua14 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);


                if (sorgua14.ExecuteScalar() != null)
                {
                    SqlCommand sorgut14 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:00' or Cikis='13:00') or (Giris='12:30' or Cikis='13:30'))", bag);
                    string ssorgut14 = sorgut14.ExecuteScalar().ToString();
                    pz1300.BackColor = Color.Red;
                    pz1300.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1300.Text = sorgua14.ExecuteScalar().ToString() + "\n" + ssorgut14 + "\n" + "13:00";

                }
                SqlCommand sorgua15 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);


                if (sorgua15.ExecuteScalar() != null)
                {
                    SqlCommand sorgut15 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='13:30' or Cikis='13:30') or (Giris='13:00' or Cikis='14:00'))", bag);
                    string ssorgut15 = sorgut15.ExecuteScalar().ToString();
                    pz1330.BackColor = Color.Red;
                    pz1330.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1330.Text = sorgua15.ExecuteScalar().ToString() + "\n" + ssorgut15 + "\n" + "13:30";

                }
                SqlCommand sorgua16 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);


                if (sorgua16.ExecuteScalar() != null)
                {
                    SqlCommand sorgut16 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:00' or Cikis='14:00') or (Giris='13:30' or Cikis='14:30'))", bag);
                    string ssorgut16 = sorgut16.ExecuteScalar().ToString();
                    pz1400.BackColor = Color.Red;
                    pz1400.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1400.Text = sorgua16.ExecuteScalar().ToString() + "\n" + ssorgut16 + "\n" + "14:00";

                }
                SqlCommand sorgua17 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);


                if (sorgua17.ExecuteScalar() != null)
                {
                    SqlCommand sorgut17 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='14:30' or Cikis='14:30') or (Giris='14:00' or Cikis='15:00'))", bag);
                    string ssorgut17 = sorgut17.ExecuteScalar().ToString();
                    pz1430.BackColor = Color.Red;
                    pz1430.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1430.Text = sorgua17.ExecuteScalar().ToString() + "\n" + ssorgut17 + "\n" + "14:30";

                }
                SqlCommand sorgua18 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);


                if (sorgua18.ExecuteScalar() != null)
                {
                    SqlCommand sorgut18 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:00' or Cikis='15:00') or (Giris='14:30' or Cikis='15:30'))", bag);
                    string ssorgut18 = sorgut18.ExecuteScalar().ToString();
                    pz1500.BackColor = Color.Red;
                    pz1500.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1500.Text = sorgua18.ExecuteScalar().ToString() + "\n" + ssorgut18 + "\n" + "15:00";

                }
                SqlCommand sorgua19 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);


                if (sorgua19.ExecuteScalar() != null)
                {
                    SqlCommand sorgut19 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='15:30' or Cikis='15:30') or (Giris='15:00' or Cikis='16:00'))", bag);
                    string ssorgut19 = sorgut19.ExecuteScalar().ToString();
                    pz1530.BackColor = Color.Red;
                    pz1530.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1530.Text = sorgua19.ExecuteScalar().ToString() + "\n" + ssorgut19 + "\n" + "15:30";

                }
                SqlCommand sorgua20 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);


                if (sorgua20.ExecuteScalar() != null)
                {
                    SqlCommand sorgut20 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:00' or Cikis='16:00') or (Giris='15:30' or Cikis='16:30'))", bag);
                    string ssorgut20 = sorgut20.ExecuteScalar().ToString();
                    pz1600.BackColor = Color.Red;
                    pz1600.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1600.Text = sorgua20.ExecuteScalar().ToString() + "\n" + ssorgut20 + "\n" + "16:00";

                }
                SqlCommand sorgua21 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);


                if (sorgua21.ExecuteScalar() != null)
                {
                    SqlCommand sorgut21 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='16:30' or Cikis='16:30') or (Giris='16:00' or Cikis='17:00'))", bag);
                    string ssorgut21 = sorgut21.ExecuteScalar().ToString();
                    pz1630.BackColor = Color.Red;
                    pz1630.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1630.Text = sorgua21.ExecuteScalar().ToString() + "\n" + ssorgut21 + "\n" + "16:30";

                }
                SqlCommand sorgua22 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);


                if (sorgua22.ExecuteScalar() != null)
                {
                    SqlCommand sorgut22 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:00' or Cikis='17:00') or (Giris='16:30' or Cikis='17:30'))", bag);
                    string ssorgut22 = sorgut22.ExecuteScalar().ToString();
                    pz1700.BackColor = Color.Red;
                    pz1700.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1700.Text = sorgua22.ExecuteScalar().ToString() + "\n" + ssorgut22 + "\n" + "17:00";

                }
                SqlCommand sorgua23 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);


                if (sorgua23.ExecuteScalar() != null)
                {
                    SqlCommand sorgut23 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='17:30' or Cikis='17:30') or (Giris='17:00' or Cikis='18:00'))", bag);
                    string ssorgut23 = sorgut23.ExecuteScalar().ToString();
                    pz1730.BackColor = Color.Red;
                    pz1730.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1730.Text = sorgua23.ExecuteScalar().ToString() + "\n" + ssorgut23 + "\n" + "17:30";

                }
                SqlCommand sorgua24 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);


                if (sorgua24.ExecuteScalar() != null)
                {
                    SqlCommand sorgut24 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:00' or Cikis='18:00') or (Giris='17:30' or Cikis='18:30'))", bag);
                    string ssorgut24 = sorgut24.ExecuteScalar().ToString();
                    pz1800.BackColor = Color.Red;
                    pz1800.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1800.Text = sorgua24.ExecuteScalar().ToString() + "\n" + ssorgut24 + "\n" + "18:00";

                }
                SqlCommand sorgua25 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);


                if (sorgua25.ExecuteScalar() != null)
                {
                    SqlCommand sorgut25 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='18:30' or Cikis='18:30') or (Giris='18:00' or Cikis='19:00'))", bag);
                    string ssorgut25 = sorgut25.ExecuteScalar().ToString();
                    pz1830.BackColor = Color.Red;
                    pz1830.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1830.Text = sorgua25.ExecuteScalar().ToString() + "\n" + ssorgut25 + "\n" + "18:30";

                }
                SqlCommand sorgua26 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);


                if (sorgua26.ExecuteScalar() != null)
                {
                    SqlCommand sorgut26 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:00' or Cikis='19:00') or (Giris='18:30' or Cikis='19:30'))", bag);
                    string ssorgut26 = sorgut26.ExecuteScalar().ToString();
                    pz1900.BackColor = Color.Red;
                    pz1900.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1900.Text = sorgua26.ExecuteScalar().ToString() + "\n" + ssorgut26 + "\n" + "19:00";

                }
                SqlCommand sorgua27 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);


                if (sorgua27.ExecuteScalar() != null)
                {
                    SqlCommand sorgut27 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='19:30' or Cikis='19:30') or (Giris='19:00' or Cikis='20:00'))", bag);
                    string ssorgut27 = sorgut27.ExecuteScalar().ToString();
                    pz1930.BackColor = Color.Red;
                    pz1930.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz1930.Text = sorgua27.ExecuteScalar().ToString() + "\n" + ssorgut27 + "\n" + "19:30";

                }
                SqlCommand sorgua28 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);

                if (sorgua28.ExecuteScalar() != null)
                {
                    SqlCommand sorgut28 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:00' or Cikis='20:00') or (Giris='19:30' or Cikis='20:30'))", bag);
                    string ssorgut28 = sorgut28.ExecuteScalar().ToString();
                    pz2000.BackColor = Color.Red;
                    pz2000.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz2000.Text = sorgua28.ExecuteScalar().ToString() + "\n" + ssorgut28 + "\n" + "20:00";

                }
                SqlCommand sorgua29 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);

                if (sorgua29.ExecuteScalar() != null)
                {
                    SqlCommand sorgut29 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='20:30' or Cikis='20:30') or (Giris='20:00' or Cikis='21:00'))", bag);
                    string ssorgut29 = sorgut29.ExecuteScalar().ToString();
                    pz2030.BackColor = Color.Red;
                    pz2030.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz2030.Text = sorgua29.ExecuteScalar().ToString() + "\n" + ssorgut29 + "\n" + "20:30";

                }
                SqlCommand sorgua30 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);


                if (sorgua30.ExecuteScalar() != null)
                {
                    SqlCommand sorgut30 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:00' or Cikis='21:00') or (Giris='20:30' or Cikis='21:30'))", bag);
                    string ssorgut30 = sorgut30.ExecuteScalar().ToString();
                    pz2100.BackColor = Color.Red;
                    pz2100.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz2100.Text = sorgua30.ExecuteScalar().ToString() + "\n" + ssorgut30 + "\n" + "21:00";

                }

                SqlCommand sorgua31 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);


                if (sorgua31.ExecuteScalar() != null)
                {
                    SqlCommand sorgut31 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='21:30' or Cikis='21:30') or (Giris='21:00' or Cikis='22:00'))", bag);
                    string ssorgut31 = sorgut31.ExecuteScalar().ToString();
                    pz2130.BackColor = Color.Red;
                    pz2130.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz2130.Text = sorgua31.ExecuteScalar().ToString() + "\n" + ssorgut31 + "\n" + "21:30";

                }
                SqlCommand sorgua32 = new SqlCommand("Select AdiSoyadi from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);


                if (sorgua32.ExecuteScalar() != null)
                {
                    SqlCommand sorgut32 = new SqlCommand("Select Tip from Randevu where Gun ='" + gg + "' and ((Giris='22:00' or Cikis='22:00') or (Giris='21:30' or Cikis='22:00'))", bag);
                    string ssorgut32 = sorgut32.ExecuteScalar().ToString();
                    pz2200.BackColor = Color.Red;
                    pz2200.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    pz2200.Text = sorgua32.ExecuteScalar().ToString() + "\n" + ssorgut32 + "\n" + "22:00";

                }

                bag.Close();


            }
            catch (Exception ec)
            {
                bag.Close();
                MessageBox.Show(ec.ToString());
            }
                
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
            gbPazartesi.Enabled = false;
            pts0630.BackColor = Color.GreenYellow;
            pts0630.Text = "06:30";
            pts0630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts0700.BackColor = Color.GreenYellow;
            pts0700.Text = "07:00";
            pts0700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts0730.BackColor = Color.GreenYellow;
            pts0730.Text = "07:30";
            pts0730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts0800.BackColor = Color.GreenYellow;
            pts0800.Text = "08:00";
            pts0800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts0830.BackColor = Color.GreenYellow;
            pts0830.Text = "08:30";
            pts0830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts0900.BackColor = Color.GreenYellow;
            pts0900.Text = "09:00";
            pts0900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts0930.BackColor = Color.GreenYellow;
            pts0930.Text = "09:30";
            pts0930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1000.BackColor = Color.GreenYellow;
            pts1000.Text = "10:00";
            pts1000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1030.BackColor = Color.GreenYellow;
            pts1030.Text = "10:30";
            pts1030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1100.BackColor = Color.GreenYellow;
            pts1100.Text = "11:00";
            pts1100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1130.BackColor = Color.GreenYellow;
            pts1130.Text = "11:30";
            pts1130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1200.BackColor = Color.GreenYellow;
            pts1200.Text = "12:00";
            pts1200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1230.BackColor = Color.GreenYellow;
            pts1230.Text = "12:30";
            pts1230.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1300.BackColor = Color.GreenYellow;
            pts1300.Text = "13:00";
            pts1300.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1330.BackColor = Color.GreenYellow;
            pts1330.Text = "13:30";
            pts1330.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1400.BackColor = Color.GreenYellow;
            pts1400.Text = "14:00";
            pts1400.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1430.BackColor = Color.GreenYellow;
            pts1430.Text = "14:30";
            pts1430.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1500.BackColor = Color.GreenYellow;
            pts1500.Text = "15:00";
            pts1500.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1530.BackColor = Color.GreenYellow;
            pts1530.Text = "15:30";
            pts1530.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1600.BackColor = Color.GreenYellow;
            pts1600.Text = "16:00";
            pts1600.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1630.BackColor = Color.GreenYellow;
            pts1630.Text = "16:30";
            pts1630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1700.BackColor = Color.GreenYellow;
            pts1700.Text = "17:00";
            pts1700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1730.BackColor = Color.GreenYellow;
            pts1730.Text = "17:30";
            pts1730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1800.BackColor = Color.GreenYellow;
            pts1800.Text = "18:00";
            pts1800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1830.BackColor = Color.GreenYellow;
            pts1830.Text = "18:30";
            pts1830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1900.BackColor = Color.GreenYellow;
            pts1900.Text = "19:00";
            pts1900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts1930.BackColor = Color.GreenYellow;
            pts1930.Text = "19:30";
            pts1930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts2000.BackColor = Color.GreenYellow;
            pts2000.Text = "20:00";
            pts2000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts2030.BackColor = Color.GreenYellow;
            pts2030.Text = "20:30";
            pts2030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts2100.BackColor = Color.GreenYellow;
            pts2100.Text = "21:00";
            pts2100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts2130.BackColor = Color.GreenYellow;
            pts2130.Text = "21:30";
            pts2130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pts2200.BackColor = Color.GreenYellow;
            pts2200.Text = "22:00";
            pts2200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);


            gbSali.Enabled = false;
            s0630.BackColor = Color.GreenYellow;
            s0630.Text = "06:30";
            s0630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s0700.BackColor = Color.GreenYellow;
            s0700.Text = "07:00";
            s0700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s0730.BackColor = Color.GreenYellow;
            s0730.Text = "07:30";
            s0730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s0800.BackColor = Color.GreenYellow;
            s0800.Text = "08:00";
            s0800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s0830.BackColor = Color.GreenYellow;
            s0830.Text = "08:30";
            s0830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s0900.BackColor = Color.GreenYellow;
            s0900.Text = "09:00";
           s0900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s0930.BackColor = Color.GreenYellow;
            s0930.Text = "09:30";
            s0930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1000.BackColor = Color.GreenYellow;
            s1000.Text = "10:00";
            s1000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1030.BackColor = Color.GreenYellow;
            s1030.Text = "10:30";
            s1030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1100.BackColor = Color.GreenYellow;
            s1100.Text = "11:00";
            s1100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1130.BackColor = Color.GreenYellow;
            s1130.Text = "11:30";
            s1130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1200.BackColor = Color.GreenYellow;
            s1200.Text = "12:00";
            s1200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1230.BackColor = Color.GreenYellow;
            s1230.Text = "12:30";
            s1230.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1300.BackColor = Color.GreenYellow;
            s1300.Text = "13:00";
            s1300.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1330.BackColor = Color.GreenYellow;
            s1330.Text = "13:30";
            s1330.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1400.BackColor = Color.GreenYellow;
            s1400.Text = "14:00";
            s1400.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1430.BackColor = Color.GreenYellow;
            s1430.Text = "14:30";
            s1430.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1500.BackColor = Color.GreenYellow;
            s1500.Text = "15:00";
            s1500.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1530.BackColor = Color.GreenYellow;
            s1530.Text = "15:30";
            s1530.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1600.BackColor = Color.GreenYellow;
            s1600.Text = "16:00";
            s1600.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1630.BackColor = Color.GreenYellow;
            s1630.Text = "16:30";
            s1630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1700.BackColor = Color.GreenYellow;
            s1700.Text = "17:00";
            s1700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1730.BackColor = Color.GreenYellow;
            s1730.Text = "17:30";
           s1730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1800.BackColor = Color.GreenYellow;
            s1800.Text = "18:00";
            s1800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1830.BackColor = Color.GreenYellow;
            s1830.Text = "18:30";
            s1830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1900.BackColor = Color.GreenYellow;
            s1900.Text = "19:00";
           s1900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s1930.BackColor = Color.GreenYellow;
            s1930.Text = "19:30";
            s1930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s2000.BackColor = Color.GreenYellow;
            s2000.Text = "20:00";
            s2000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s2030.BackColor = Color.GreenYellow;
            s2030.Text = "20:30";
            s2030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s2100.BackColor = Color.GreenYellow;
            s2100.Text = "21:00";
            s2100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s2130.BackColor = Color.GreenYellow;
            s2130.Text = "21:30";
            s2130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            s2200.BackColor = Color.GreenYellow;
            s2200.Text = "22:00";
            s2200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            gbCarsamba.Enabled = false;
            cr0630.BackColor = Color.GreenYellow;
            cr0630.Text = "06:30";
            cr0630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr0700.BackColor = Color.GreenYellow;
            cr0700.Text = "07:00";
            cr0700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr0730.BackColor = Color.GreenYellow;
            cr0730.Text = "07:30";
            cr0730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr0800.BackColor = Color.GreenYellow;
            cr0800.Text = "08:00";
            cr0800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr0830.BackColor = Color.GreenYellow;
            cr0830.Text = "08:30";
            cr0830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr0900.BackColor = Color.GreenYellow;
            cr0900.Text = "09:00";
            cr0900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr0930.BackColor = Color.GreenYellow;
            cr0930.Text = "09:30";
            cr0930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1000.BackColor = Color.GreenYellow;
            cr1000.Text = "10:00";
            cr1000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           cr1030.BackColor = Color.GreenYellow;
            cr1030.Text = "10:30";
            cr1030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1100.BackColor = Color.GreenYellow;
            cr1100.Text = "11:00";
            cr1100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1130.BackColor = Color.GreenYellow;
            cr1130.Text = "11:30";
            cr1130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1200.BackColor = Color.GreenYellow;
            cr1200.Text = "12:00";
            cr1200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1230.BackColor = Color.GreenYellow;
            cr1230.Text = "12:30";
           cr1230.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1300.BackColor = Color.GreenYellow;
           cr1300.Text = "13:00";
            cr1300.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1330.BackColor = Color.GreenYellow;
            cr1330.Text = "13:30";
            cr1330.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1400.BackColor = Color.GreenYellow;
           cr1400.Text = "14:00";
            cr1400.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           cr1430.BackColor = Color.GreenYellow;
            cr1430.Text = "14:30";
            cr1430.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1500.BackColor = Color.GreenYellow;
            cr1500.Text = "15:00";
            cr1500.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1530.BackColor = Color.GreenYellow;
            cr1530.Text = "15:30";
            cr1530.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1600.BackColor = Color.GreenYellow;
           cr1600.Text = "16:00";
            cr1600.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1630.BackColor = Color.GreenYellow;
           cr1630.Text = "16:30";
            cr1630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1700.BackColor = Color.GreenYellow;
            cr1700.Text = "17:00";
            cr1700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1730.BackColor = Color.GreenYellow;
            cr1730.Text = "17:30";
            cr1730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1800.BackColor = Color.GreenYellow;
            cr1800.Text = "18:00";
            cr1800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1830.BackColor = Color.GreenYellow;
            cr1830.Text = "18:30";
            cr1830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1900.BackColor = Color.GreenYellow;
            cr1900.Text = "19:00";
            cr1900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr1930.BackColor = Color.GreenYellow;
            cr1930.Text = "19:30";
            cr1930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr2000.BackColor = Color.GreenYellow;
            cr2000.Text = "20:00";
            cr2000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr2030.BackColor = Color.GreenYellow;
           cr2030.Text = "20:30";
            cr2030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr2100.BackColor = Color.GreenYellow;
            cr2100.Text = "21:00";
            cr2100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr2130.BackColor = Color.GreenYellow;
            cr2130.Text = "21:30";
            cr2130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            cr2200.BackColor = Color.GreenYellow;
            cr2200.Text = "22:00";
            cr2200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            gbPersembe.Enabled = false;
            p0630.BackColor = Color.GreenYellow;
            p0630.Text = "06:30";
            p0630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p0700.BackColor = Color.GreenYellow;
            p0700.Text = "07:00";
            p0700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p0730.BackColor = Color.GreenYellow;
            p0730.Text = "07:30";
            p0730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p0800.BackColor = Color.GreenYellow;
            p0800.Text = "08:00";
            p0800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p0830.BackColor = Color.GreenYellow;
            p0830.Text = "08:30";
            p0830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p0900.BackColor = Color.GreenYellow;
            p0900.Text = "09:00";
            p0900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p0930.BackColor = Color.GreenYellow;
            p0930.Text = "09:30";
            p0930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1000.BackColor = Color.GreenYellow;
            p1000.Text = "10:00";
            p1000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1030.BackColor = Color.GreenYellow;
            p1030.Text = "10:30";
            p1030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1100.BackColor = Color.GreenYellow;
            p1100.Text = "11:00";
            p1100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1130.BackColor = Color.GreenYellow;
            p1130.Text = "11:30";
            p1130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1200.BackColor = Color.GreenYellow;
            p1200.Text = "12:00";
            p1200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1230.BackColor = Color.GreenYellow;
            p1230.Text = "12:30";
            p1230.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1300.BackColor = Color.GreenYellow;
            p1300.Text = "13:00";
            p1300.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1330.BackColor = Color.GreenYellow;
            p1330.Text = "13:30";
            p1330.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1400.BackColor = Color.GreenYellow;
            p1400.Text = "14:00";
            p1400.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1430.BackColor = Color.GreenYellow;
            p1430.Text = "14:30";
            p1430.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1500.BackColor = Color.GreenYellow;
            p1500.Text = "15:00";
            p1500.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1530.BackColor = Color.GreenYellow;
            p1530.Text = "15:30";
            p1530.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1600.BackColor = Color.GreenYellow;
            p1600.Text = "16:00";
            p1600.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1630.BackColor = Color.GreenYellow;
            p1630.Text = "16:30";
            p1630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1700.BackColor = Color.GreenYellow;
            p1700.Text = "17:00";
            p1700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1730.BackColor = Color.GreenYellow;
            p1730.Text = "17:30";
            p1730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1800.BackColor = Color.GreenYellow;
            p1800.Text = "18:00";
            p1800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1830.BackColor = Color.GreenYellow;
            p1830.Text = "18:30";
            p1830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1900.BackColor = Color.GreenYellow;
            p1900.Text = "19:00";
            p1900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p1930.BackColor = Color.GreenYellow;
            p1930.Text = "19:30";
            p1930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p2000.BackColor = Color.GreenYellow;
            p2000.Text = "20:00";
            p2000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p2030.BackColor = Color.GreenYellow;
            p2030.Text = "20:30";
            p2030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p2100.BackColor = Color.GreenYellow;
            p2100.Text = "21:00";
            p2100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p2130.BackColor = Color.GreenYellow;
            p2130.Text = "21:30";
            p2130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            p2200.BackColor = Color.GreenYellow;
            p2200.Text = "22:00";
            p2200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            gbCuma.Enabled = false;
            c0630.BackColor = Color.GreenYellow;
            c0630.Text = "06:30";
            c0630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c0700.BackColor = Color.GreenYellow;
            c0700.Text = "07:00";
            c0700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c0730.BackColor = Color.GreenYellow;
            c0730.Text = "07:30";
            c0730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           c0800.BackColor = Color.GreenYellow;
           c0800.Text = "08:00";
           c0800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           c0830.BackColor = Color.GreenYellow;
            c0830.Text = "08:30";
            c0830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c0900.BackColor = Color.GreenYellow;
            c0900.Text = "09:00";
            c0900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c0930.BackColor = Color.GreenYellow;
            c0930.Text = "09:30";
            c0930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1000.BackColor = Color.GreenYellow;
           c1000.Text = "10:00";
            c1000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           c1030.BackColor = Color.GreenYellow;
           c1030.Text = "10:30";
            c1030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1100.BackColor = Color.GreenYellow;
            c1100.Text = "11:00";
            c1100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1130.BackColor = Color.GreenYellow;
            c1130.Text = "11:30";
            c1130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1200.BackColor = Color.GreenYellow;
            c1200.Text = "12:00";
            c1200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           c1230.BackColor = Color.GreenYellow;
           c1230.Text = "12:30";
            c1230.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1300.BackColor = Color.GreenYellow;
            c1300.Text = "13:00";
            c1300.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1330.BackColor = Color.GreenYellow;
            c1330.Text = "13:30";
            c1330.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1400.BackColor = Color.GreenYellow;
            c1400.Text = "14:00";
            c1400.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1430.BackColor = Color.GreenYellow;
            c1430.Text = "14:30";
            c1430.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           c1500.BackColor = Color.GreenYellow;
            c1500.Text = "15:00";
            c1500.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1530.BackColor = Color.GreenYellow;
            c1530.Text = "15:30";
            c1530.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1600.BackColor = Color.GreenYellow;
            c1600.Text = "16:00";
            c1600.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1630.BackColor = Color.GreenYellow;
            c1630.Text = "16:30";
            c1630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1700.BackColor = Color.GreenYellow;
            c1700.Text = "17:00";
            c1700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           c1730.BackColor = Color.GreenYellow;
            c1730.Text = "17:30";
            c1730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1800.BackColor = Color.GreenYellow;
            c1800.Text = "18:00";
            c1800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1830.BackColor = Color.GreenYellow;
           c1830.Text = "18:30";
            c1830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1900.BackColor = Color.GreenYellow;
            c1900.Text = "19:00";
            c1900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c1930.BackColor = Color.GreenYellow;
           c1930.Text = "19:30";
            c1930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c2000.BackColor = Color.GreenYellow;
            c2000.Text = "20:00";
            c2000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c2030.BackColor = Color.GreenYellow;
            c2030.Text = "20:30";
            c2030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c2100.BackColor = Color.GreenYellow;
            c2100.Text = "21:00";
            c2100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c2130.BackColor = Color.GreenYellow;
            c2130.Text = "21:30";
            c2130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            c2200.BackColor = Color.GreenYellow;
            c2200.Text = "22:00";
            c2200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            gbCumartesi.Enabled = false;
            ct0630.BackColor = Color.GreenYellow;
            ct0630.Text = "06:30";
            ct0630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct0700.BackColor = Color.GreenYellow;
            ct0700.Text = "07:00";
            ct0700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct0730.BackColor = Color.GreenYellow;
            ct0730.Text = "07:30";
            ct0730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           ct0800.BackColor = Color.GreenYellow;
            ct0800.Text = "08:00";
            ct0800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct0830.BackColor = Color.GreenYellow;
            ct0830.Text = "08:30";
            ct0830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct0900.BackColor = Color.GreenYellow;
            ct0900.Text = "09:00";
            ct0900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           ct0930.BackColor = Color.GreenYellow;
            ct0930.Text = "09:30";
            ct0930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1000.BackColor = Color.GreenYellow;
            ct1000.Text = "10:00";
            ct1000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

           ct1030.BackColor = Color.GreenYellow;
            ct1030.Text = "10:30";
            ct1030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1100.BackColor = Color.GreenYellow;
            ct1100.Text = "11:00";
            ct1100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1130.BackColor = Color.GreenYellow;
           ct1130.Text = "11:30";
            ct1130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1200.BackColor = Color.GreenYellow;
            ct1200.Text = "12:00";
            ct1200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1230.BackColor = Color.GreenYellow;
            ct1230.Text = "12:30";
            ct1230.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1300.BackColor = Color.GreenYellow;
            ct1300.Text = "13:00";
            ct1300.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1330.BackColor = Color.GreenYellow;
            ct1330.Text = "13:30";
            ct1330.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1400.BackColor = Color.GreenYellow;
            ct1400.Text = "14:00";
            ct1400.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1430.BackColor = Color.GreenYellow;
            ct1430.Text = "14:30";
            ct1430.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1500.BackColor = Color.GreenYellow;
            ct1500.Text = "15:00";
            ct1500.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1530.BackColor = Color.GreenYellow;
            ct1530.Text = "15:30";
            ct1530.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1600.BackColor = Color.GreenYellow;
            ct1600.Text = "16:00";
            ct1600.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1630.BackColor = Color.GreenYellow;
            ct1630.Text = "16:30";
            ct1630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1700.BackColor = Color.GreenYellow;
            ct1700.Text = "17:00";
            ct1700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
 
            ct1730.BackColor = Color.GreenYellow;
            ct1730.Text = "17:30";
            ct1730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1800.BackColor = Color.GreenYellow;
            ct1800.Text = "18:00";
            ct1800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1830.BackColor = Color.GreenYellow;
            ct1830.Text = "18:30";
            ct1830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1900.BackColor = Color.GreenYellow;
            ct1900.Text = "19:00";
            ct1900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct1930.BackColor = Color.GreenYellow;
            ct1930.Text = "19:30";
            ct1930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct2000.BackColor = Color.GreenYellow;
            ct2000.Text = "20:00";
            ct2000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct2030.BackColor = Color.GreenYellow;
            ct2030.Text = "20:30";
            ct2030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct2100.BackColor = Color.GreenYellow;
            ct2100.Text = "21:00";
            ct2100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct2130.BackColor = Color.GreenYellow;
            ct2130.Text = "21:30";
            ct2130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            ct2200.BackColor = Color.GreenYellow;
            ct2200.Text = "22:00";
            ct2200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            gbPazar.Enabled = false;
            pz0630.BackColor = Color.GreenYellow;
            pz0630.Text = "06:30";
            pz0630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz0700.BackColor = Color.GreenYellow;
            pz0700.Text = "07:00";
            pz0700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz0730.BackColor = Color.GreenYellow;
            pz0730.Text = "07:30";
            pz0730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz0800.BackColor = Color.GreenYellow;
            pz0800.Text = "08:00";
            pz0800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz0830.BackColor = Color.GreenYellow;
            pz0830.Text = "08:30";
            pz0830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz0900.BackColor = Color.GreenYellow;
            pz0900.Text = "09:00";
            pz0900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz0930.BackColor = Color.GreenYellow;
            pz0930.Text = "09:30";
            pz0930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1000.BackColor = Color.GreenYellow;
            pz1000.Text = "10:00";
            pz1000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1030.BackColor = Color.GreenYellow;
            pz1030.Text = "10:30";
            pz1030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1100.BackColor = Color.GreenYellow;
            pz1100.Text = "11:00";
            pz1100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1130.BackColor = Color.GreenYellow;
            pz1130.Text = "11:30";
            pz1130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1200.BackColor = Color.GreenYellow;
            pz1200.Text = "12:00";
            pz1200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1230.BackColor = Color.GreenYellow;
            pz1230.Text = "12:30";
            pz1230.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1300.BackColor = Color.GreenYellow;
            pz1300.Text = "13:00";
            pz1300.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1330.BackColor = Color.GreenYellow;
            pz1330.Text = "13:30";
            pz1330.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1400.BackColor = Color.GreenYellow;
            pz1400.Text = "14:00";
            pz1400.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1430.BackColor = Color.GreenYellow;
            pz1430.Text = "14:30";
            pz1430.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1500.BackColor = Color.GreenYellow;
            pz1500.Text = "15:00";
            pz1500.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1530.BackColor = Color.GreenYellow;
            pz1530.Text = "15:30";
            pz1530.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1600.BackColor = Color.GreenYellow;
            pz1600.Text = "16:00";
            pz1600.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1630.BackColor = Color.GreenYellow;
            pz1630.Text = "16:30";
            pz1630.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1700.BackColor = Color.GreenYellow;
            pz1700.Text = "17:00";
            pz1700.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1730.BackColor = Color.GreenYellow;
            pz1730.Text = "17:30";
            pz1730.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1800.BackColor = Color.GreenYellow;
            pz1800.Text = "18:00";
            pz1800.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1830.BackColor = Color.GreenYellow;
            pz1830.Text = "18:30";
            pz1830.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1900.BackColor = Color.GreenYellow;
            pz1900.Text = "19:00";
            pz1900.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz1930.BackColor = Color.GreenYellow;
            pz1930.Text = "19:30";
            pz1930.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz2000.BackColor = Color.GreenYellow;
            pz2000.Text = "20:00";
            pz2000.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz2030.BackColor = Color.GreenYellow;
            pz2030.Text = "20:30";
            pz2030.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz2100.BackColor = Color.GreenYellow;
            pz2100.Text = "21:00";
            pz2100.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz2130.BackColor = Color.GreenYellow;
            pz2130.Text = "21:30";
            pz2130.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            pz2200.BackColor = Color.GreenYellow;
            pz2200.Text = "22:00";
            pz2200.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            string gun = DateTime.Now.DayOfWeek.ToString();
            if (gun=="Monday")
            {
                btnPazartesi_Click(sender, e);
            }
            else if (gun=="Tuesday")
            {
                 btnSali_Click(sender, e);
            }
            else if (gun == "Tuesday")
            {
                btnSali_Click(sender, e);
            }
            else if (gun == "Wednesday")
            {
                btnCarsamba_Click(sender, e);
            }
            else if (gun == "Thursday")
            {
                btnPersembe_Click(sender, e);
            }
            else if (gun == "Friday")
            {
                btnCuma_Click(sender, e);
            }
            else if (gun == "Saturday")
            {
                btnCumartesi_Click(sender, e);
            }
            else if (gun == "Sunday")
            {
                btnPazar_Click(sender, e);
            }
            
            
        }
        public string gun = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if ( btnPazartesi.BackColor == Color.Silver)
            {
                gun = "Pazartesi";
            }
            else if (btnSali.BackColor == Color.Silver)
            {
                 gun = "Salı";
            }
            else if (btnCarsamba.BackColor == Color.Silver)
            {
                gun = "Çarşamba";
            }
            else if (btnPersembe.BackColor == Color.Silver)
            {
                 gun = "Perşembe";
            }
            else if (btnCuma.BackColor == Color.Silver)
            {
                gun = "Cuma";
            }
            else if (btnCumartesi.BackColor == Color.Silver)
            {
                 gun = "Cumartesi";
            }
            else if (btnPazar.BackColor == Color.Silver)
            {
                 gun = "Pazar";
            }
            frm10.Refresh();
            frm10.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnPazartesi.BackColor == Color.Silver)
            {
                gun = "Pazartesi";
            }
            else if (btnSali.BackColor == Color.Silver)
            {
                gun = "Salı";
            }
            else if (btnCarsamba.BackColor == Color.Silver)
            {
                gun = "Çarşamba";
            }
            else if (btnPersembe.BackColor == Color.Silver)
            {
                gun = "Perşembe";
            }
            else if (btnCuma.BackColor == Color.Silver)
            {
                gun = "Cuma";
            }
            else if (btnCumartesi.BackColor == Color.Silver)
            {
                gun = "Cumartesi";
            }
            else if (btnPazar.BackColor == Color.Silver)
            {
                gun = "Pazar";
            }
            frm11.Refresh();
            frm11.ShowDialog();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Tüm kayıtları SİLMEK istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Delete from Randevu";
                kmt.ExecuteNonQuery();
                MessageBox.Show("Tüm Randevuler SİLİNDİ.");
                bag.Close();
                
                this.Close();
            }
        }

      
    }
}
