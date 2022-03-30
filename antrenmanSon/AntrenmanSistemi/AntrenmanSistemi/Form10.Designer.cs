namespace AntrenmanSistemi
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbSaat = new System.Windows.Forms.ComboBox();
            this.rbPT = new System.Windows.Forms.RadioButton();
            this.rbMiha = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGun = new System.Windows.Forms.Label();
            this.lbluyarı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageKey = "accept.png";
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(475, 233);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 63);
            this.btnKaydet.TabIndex = 0;
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
            // 
            // cbSaat
            // 
            this.cbSaat.FormattingEnabled = true;
            this.cbSaat.Location = new System.Drawing.Point(525, 65);
            this.cbSaat.Name = "cbSaat";
            this.cbSaat.Size = new System.Drawing.Size(57, 21);
            this.cbSaat.TabIndex = 2;
            // 
            // rbPT
            // 
            this.rbPT.AutoSize = true;
            this.rbPT.BackColor = System.Drawing.Color.Transparent;
            this.rbPT.Enabled = false;
            this.rbPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPT.Location = new System.Drawing.Point(458, 124);
            this.rbPT.Name = "rbPT";
            this.rbPT.Size = new System.Drawing.Size(44, 24);
            this.rbPT.TabIndex = 4;
            this.rbPT.TabStop = true;
            this.rbPT.Text = "Pt";
            this.rbPT.UseVisualStyleBackColor = false;
            this.rbPT.CheckedChanged += new System.EventHandler(this.rbPT_CheckedChanged);
            // 
            // rbMiha
            // 
            this.rbMiha.AutoSize = true;
            this.rbMiha.BackColor = System.Drawing.Color.Transparent;
            this.rbMiha.Enabled = false;
            this.rbMiha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMiha.Location = new System.Drawing.Point(517, 124);
            this.rbMiha.Name = "rbMiha";
            this.rbMiha.Size = new System.Drawing.Size(65, 24);
            this.rbMiha.TabIndex = 5;
            this.rbMiha.TabStop = true;
            this.rbMiha.Text = "Miha";
            this.rbMiha.UseVisualStyleBackColor = false;
            this.rbMiha.CheckedChanged += new System.EventHandler(this.rbMiha_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(337, 284);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.Location = new System.Drawing.Point(407, 26);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(43, 20);
            this.lblGun.TabIndex = 14;
            this.lblGun.Text = "Gün";
            // 
            // lbluyarı
            // 
            this.lbluyarı.AutoSize = true;
            this.lbluyarı.BackColor = System.Drawing.Color.Transparent;
            this.lbluyarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluyarı.ForeColor = System.Drawing.Color.Red;
            this.lbluyarı.Location = new System.Drawing.Point(371, 165);
            this.lbluyarı.Name = "lbluyarı";
            this.lbluyarı.Size = new System.Drawing.Size(45, 16);
            this.lbluyarı.TabIndex = 15;
            this.lbluyarı.Text = "Uyarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(407, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Saat seçiniz:";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AntrenmanSistemi.Properties.Resources.wp9ea8b4c61;
            this.ClientSize = new System.Drawing.Size(659, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbluyarı);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbMiha);
            this.Controls.Add(this.rbPT);
            this.Controls.Add(this.cbSaat);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antrenman Takip Sistemi - Randevu Ekle";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbSaat;
        private System.Windows.Forms.RadioButton rbPT;
        private System.Windows.Forms.RadioButton rbMiha;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lbluyarı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}