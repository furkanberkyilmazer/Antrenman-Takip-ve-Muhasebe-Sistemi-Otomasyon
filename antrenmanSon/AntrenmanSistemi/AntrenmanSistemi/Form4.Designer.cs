namespace AntrenmanSistemi
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbPaket = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMiha = new System.Windows.Forms.CheckBox();
            this.cbPsiko = new System.Windows.Forms.CheckBox();
            this.cbPt = new System.Windows.Forms.CheckBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtSeans = new System.Windows.Forms.TextBox();
            this.rbPaketDisi = new System.Windows.Forms.RadioButton();
            this.rbPaket = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.txtCepNo = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbPaket.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuzenle.ImageKey = "1397465125_edit_user-.png";
            this.btnDuzenle.ImageList = this.ımageList1;
            this.btnDuzenle.Location = new System.Drawing.Point(490, 22);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(114, 65);
            this.btnDuzenle.TabIndex = 29;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1397465125_edit_user-.png");
            this.ımageList1.Images.SetKeyName(1, "ajanda.png");
            this.ımageList1.Images.SetKeyName(2, "check--user-icon-27676.png");
            this.ımageList1.Images.SetKeyName(3, "139-512.png");
            this.ımageList1.Images.SetKeyName(4, "block_user_remove_admin_cancel_crossed_customer-512.png");
            this.ımageList1.Images.SetKeyName(5, "delete-user-512.png");
            this.ımageList1.Images.SetKeyName(6, "delete-512.png");
            this.ımageList1.Images.SetKeyName(7, "1600.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.gbPaket);
            this.groupBox1.Controls.Add(this.rbPaketDisi);
            this.groupBox1.Controls.Add(this.rbPaket);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbltarih);
            this.groupBox1.Controls.Add(this.txtAdiSoyadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtCepNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(59, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 446);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbPaket
            // 
            this.gbPaket.Controls.Add(this.label6);
            this.gbPaket.Controls.Add(this.label5);
            this.gbPaket.Controls.Add(this.label3);
            this.gbPaket.Controls.Add(this.cbMiha);
            this.gbPaket.Controls.Add(this.cbPsiko);
            this.gbPaket.Controls.Add(this.cbPt);
            this.gbPaket.Controls.Add(this.txtFiyat);
            this.gbPaket.Controls.Add(this.txtSeans);
            this.gbPaket.Enabled = false;
            this.gbPaket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbPaket.Location = new System.Drawing.Point(16, 266);
            this.gbPaket.Name = "gbPaket";
            this.gbPaket.Size = new System.Drawing.Size(391, 152);
            this.gbPaket.TabIndex = 40;
            this.gbPaket.TabStop = false;
            this.gbPaket.Text = "Paket Seçenekleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Seans:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Paket Türü:";
            // 
            // cbMiha
            // 
            this.cbMiha.AutoSize = true;
            this.cbMiha.Location = new System.Drawing.Point(285, 34);
            this.cbMiha.Name = "cbMiha";
            this.cbMiha.Size = new System.Drawing.Size(66, 24);
            this.cbMiha.TabIndex = 39;
            this.cbMiha.Text = "Miha";
            this.cbMiha.UseVisualStyleBackColor = true;
            // 
            // cbPsiko
            // 
            this.cbPsiko.AutoSize = true;
            this.cbPsiko.Location = new System.Drawing.Point(184, 34);
            this.cbPsiko.Name = "cbPsiko";
            this.cbPsiko.Size = new System.Drawing.Size(95, 24);
            this.cbPsiko.TabIndex = 38;
            this.cbPsiko.Text = "Psikolog";
            this.cbPsiko.UseVisualStyleBackColor = true;
            // 
            // cbPt
            // 
            this.cbPt.AutoSize = true;
            this.cbPt.Location = new System.Drawing.Point(129, 34);
            this.cbPt.Name = "cbPt";
            this.cbPt.Size = new System.Drawing.Size(49, 24);
            this.cbPt.TabIndex = 37;
            this.cbPt.Text = "PT";
            this.cbPt.UseVisualStyleBackColor = true;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(90, 105);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 26);
            this.txtFiyat.TabIndex = 36;
            // 
            // txtSeans
            // 
            this.txtSeans.Location = new System.Drawing.Point(90, 70);
            this.txtSeans.Name = "txtSeans";
            this.txtSeans.Size = new System.Drawing.Size(100, 26);
            this.txtSeans.TabIndex = 35;
            // 
            // rbPaketDisi
            // 
            this.rbPaketDisi.AutoSize = true;
            this.rbPaketDisi.Enabled = false;
            this.rbPaketDisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPaketDisi.Location = new System.Drawing.Point(200, 228);
            this.rbPaketDisi.Name = "rbPaketDisi";
            this.rbPaketDisi.Size = new System.Drawing.Size(108, 24);
            this.rbPaketDisi.TabIndex = 39;
            this.rbPaketDisi.Text = "Paket Dışı";
            this.rbPaketDisi.UseVisualStyleBackColor = true;
            this.rbPaketDisi.CheckedChanged += new System.EventHandler(this.rbPaketDisi_CheckedChanged);
            // 
            // rbPaket
            // 
            this.rbPaket.AutoSize = true;
            this.rbPaket.Checked = true;
            this.rbPaket.Enabled = false;
            this.rbPaket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPaket.Location = new System.Drawing.Point(106, 228);
            this.rbPaket.Name = "rbPaket";
            this.rbPaket.Size = new System.Drawing.Size(73, 24);
            this.rbPaket.TabIndex = 38;
            this.rbPaket.TabStop = true;
            this.rbPaket.Text = "Paket";
            this.rbPaket.UseVisualStyleBackColor = true;
            this.rbPaket.CheckedChanged += new System.EventHandler(this.rbPaket_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adres:";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(116, 22);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(0, 20);
            this.lbltarih.TabIndex = 21;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Enabled = false;
            this.txtAdiSoyadi.Location = new System.Drawing.Point(120, 48);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(247, 26);
            this.txtAdiSoyadi.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tel No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Adı Soyadı:";
            // 
            // txtAdres
            // 
            this.txtAdres.Enabled = false;
            this.txtAdres.Location = new System.Drawing.Point(92, 114);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(275, 108);
            this.txtAdres.TabIndex = 19;
            this.txtAdres.Text = "";
            // 
            // txtCepNo
            // 
            this.txtCepNo.Enabled = false;
            this.txtCepNo.Location = new System.Drawing.Point(120, 82);
            this.txtCepNo.Name = "txtCepNo";
            this.txtCepNo.Size = new System.Drawing.Size(247, 26);
            this.txtCepNo.TabIndex = 12;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageKey = "check--user-icon-27676.png";
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(504, 383);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 75);
            this.btnKaydet.TabIndex = 30;
            this.btnKaydet.Text = "Değişiklikleri Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "ajanda.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(490, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 85);
            this.button1.TabIndex = 30;
            this.button1.Text = "Antrenman Geçmişi";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "1600.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(490, 220);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 63);
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AntrenmanSistemi.Properties.Resources.wp9ea8b4c621;
            this.ClientSize = new System.Drawing.Size(613, 470);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antrenman Takip Sistemi - Üye Detay";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPaket.ResumeLayout(false);
            this.gbPaket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.TextBox txtCepNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbPaket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbMiha;
        private System.Windows.Forms.CheckBox cbPsiko;
        private System.Windows.Forms.CheckBox cbPt;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtSeans;
        private System.Windows.Forms.RadioButton rbPaketDisi;
        private System.Windows.Forms.RadioButton rbPaket;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSil;
    }
}