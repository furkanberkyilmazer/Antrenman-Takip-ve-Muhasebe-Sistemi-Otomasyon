namespace AntrenmanSistemi
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtCepNo = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.lbltarih = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbPaketDisi = new System.Windows.Forms.RadioButton();
            this.gbPaket = new System.Windows.Forms.GroupBox();
            this.cbPesin = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMiha = new System.Windows.Forms.CheckBox();
            this.cbPsiko = new System.Windows.Forms.CheckBox();
            this.cbPt = new System.Windows.Forms.CheckBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtSeans = new System.Windows.Forms.TextBox();
            this.btngeri = new System.Windows.Forms.Button();
            this.gbPaket.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(139, 103);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(255, 108);
            this.txtAdres.TabIndex = 20;
            this.txtAdres.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageKey = "user_accept.png";
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(179, 421);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 51);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "accept.png");
            this.ımageList1.Images.SetKeyName(1, "user_accept.png");
            this.ımageList1.Images.SetKeyName(2, "back.png");
            // 
            // txtCepNo
            // 
            this.txtCepNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCepNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCepNo.HideSelection = false;
            this.txtCepNo.Location = new System.Drawing.Point(139, 67);
            this.txtCepNo.Name = "txtCepNo";
            this.txtCepNo.Size = new System.Drawing.Size(100, 26);
            this.txtCepNo.TabIndex = 13;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdiSoyadi.Location = new System.Drawing.Point(139, 34);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(100, 26);
            this.txtAdiSoyadi.TabIndex = 12;
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(81, 11);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(0, 13);
            this.lbltarih.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(68, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(68, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tel No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Adı Soyadı:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.Location = new System.Drawing.Point(139, 228);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 24);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Paket";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbPaketDisi
            // 
            this.rbPaketDisi.AutoSize = true;
            this.rbPaketDisi.BackColor = System.Drawing.Color.Transparent;
            this.rbPaketDisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPaketDisi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPaketDisi.Location = new System.Drawing.Point(233, 228);
            this.rbPaketDisi.Name = "rbPaketDisi";
            this.rbPaketDisi.Size = new System.Drawing.Size(108, 24);
            this.rbPaketDisi.TabIndex = 36;
            this.rbPaketDisi.Text = "Paket Dışı";
            this.rbPaketDisi.UseVisualStyleBackColor = false;
            this.rbPaketDisi.CheckedChanged += new System.EventHandler(this.rbPaketDisi_CheckedChanged);
            // 
            // gbPaket
            // 
            this.gbPaket.BackColor = System.Drawing.Color.Transparent;
            this.gbPaket.Controls.Add(this.cbPesin);
            this.gbPaket.Controls.Add(this.label6);
            this.gbPaket.Controls.Add(this.label5);
            this.gbPaket.Controls.Add(this.label3);
            this.gbPaket.Controls.Add(this.cbMiha);
            this.gbPaket.Controls.Add(this.cbPsiko);
            this.gbPaket.Controls.Add(this.cbPt);
            this.gbPaket.Controls.Add(this.txtFiyat);
            this.gbPaket.Controls.Add(this.txtSeans);
            this.gbPaket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbPaket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbPaket.Location = new System.Drawing.Point(66, 258);
            this.gbPaket.Name = "gbPaket";
            this.gbPaket.Size = new System.Drawing.Size(391, 152);
            this.gbPaket.TabIndex = 37;
            this.gbPaket.TabStop = false;
            this.gbPaket.Text = "Paket Seçenekleri";
            // 
            // cbPesin
            // 
            this.cbPesin.AutoSize = true;
            this.cbPesin.Location = new System.Drawing.Point(236, 105);
            this.cbPesin.Name = "cbPesin";
            this.cbPesin.Size = new System.Drawing.Size(134, 24);
            this.cbPesin.TabIndex = 43;
            this.cbPesin.Text = "Peşin Ödendi";
            this.cbPesin.UseVisualStyleBackColor = true;
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
            this.label5.Location = new System.Drawing.Point(30, 73);
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
            this.txtFiyat.Location = new System.Drawing.Point(104, 102);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 26);
            this.txtFiyat.TabIndex = 36;
            // 
            // txtSeans
            // 
            this.txtSeans.Location = new System.Drawing.Point(104, 70);
            this.txtSeans.Name = "txtSeans";
            this.txtSeans.Size = new System.Drawing.Size(100, 26);
            this.txtSeans.TabIndex = 35;
            // 
            // btngeri
            // 
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ImageKey = "back.png";
            this.btngeri.ImageList = this.ımageList1;
            this.btngeri.Location = new System.Drawing.Point(405, 432);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(52, 40);
            this.btngeri.TabIndex = 100;
            this.btngeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AntrenmanSistemi.Properties.Resources.wp9ea8b4c63;
            this.ClientSize = new System.Drawing.Size(469, 484);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.gbPaket);
            this.Controls.Add(this.rbPaketDisi);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtCepNo);
            this.Controls.Add(this.txtAdiSoyadi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antrenman Takip Sistemi - Üye Kayıt";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbPaket.ResumeLayout(false);
            this.gbPaket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtCepNo;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbPaketDisi;
        private System.Windows.Forms.GroupBox gbPaket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbMiha;
        private System.Windows.Forms.CheckBox cbPsiko;
        private System.Windows.Forms.CheckBox cbPt;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtSeans;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.CheckBox cbPesin;
    }
}