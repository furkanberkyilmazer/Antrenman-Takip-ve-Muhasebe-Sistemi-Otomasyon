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
    public partial class Form11 : Form
    {
        public Form9 frm9;
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=antrenman;Integrated Security=True");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        OpenFileDialog duzenle = new OpenFileDialog();
        public void listele()
        {
            string gun = frm9.gun;
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select AdiSoyadi,Giris,Cikis from Randevu where Gun='"+gun+"'", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
        private void Form11_Load(object sender, EventArgs e)
        {
            listele();
            this.Text="Antrenman Takip Sistemi - Randevu Sil -" + frm9.gun;
            if (dataGridView1.RowCount<=0)
            {
                MessageBox.Show("Bugüne ait randevu bulunmamktadır.");
                this.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult cevap;
                    cevap = MessageBox.Show("Randevuyu Silmek istediğinizden Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        bag.Open();
                        kmt.Connection = bag;
                        kmt.CommandText = "Delete from Randevu where Giris='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' and Cikis='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "' and Gun= '" + frm9.gun + "'";
                        kmt.ExecuteNonQuery();
                        MessageBox.Show("Randevu Silindi");
                        bag.Close();
                        frm9.Close();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Randevu Seçiniz.");
                }
            
            
        }
    }
}
