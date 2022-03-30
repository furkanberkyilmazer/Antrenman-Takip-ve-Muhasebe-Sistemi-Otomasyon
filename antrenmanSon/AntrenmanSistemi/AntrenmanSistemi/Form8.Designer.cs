namespace AntrenmanSistemi
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.gbguvenlik = new System.Windows.Forms.GroupBox();
            this.lbldurum = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txttsifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkodu = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtkod = new System.Windows.Forms.TextBox();
            this.lblkod = new System.Windows.Forms.Label();
            this.btnonayla = new System.Windows.Forms.Button();
            this.txteskisifre = new System.Windows.Forms.TextBox();
            this.gbguvenlik.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbguvenlik
            // 
            this.gbguvenlik.BackColor = System.Drawing.Color.Transparent;
            this.gbguvenlik.Controls.Add(this.lbldurum);
            this.gbguvenlik.Controls.Add(this.progressBar1);
            this.gbguvenlik.Controls.Add(this.txttsifre);
            this.gbguvenlik.Controls.Add(this.label8);
            this.gbguvenlik.Controls.Add(this.txtsifre);
            this.gbguvenlik.Controls.Add(this.label1);
            this.gbguvenlik.Controls.Add(this.label3);
            this.gbguvenlik.Controls.Add(this.lblkodu);
            this.gbguvenlik.Controls.Add(this.btnguncelle);
            this.gbguvenlik.Controls.Add(this.txtkod);
            this.gbguvenlik.Controls.Add(this.lblkod);
            this.gbguvenlik.Controls.Add(this.btnonayla);
            this.gbguvenlik.Controls.Add(this.txteskisifre);
            this.gbguvenlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbguvenlik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbguvenlik.Location = new System.Drawing.Point(54, 12);
            this.gbguvenlik.Name = "gbguvenlik";
            this.gbguvenlik.Size = new System.Drawing.Size(232, 402);
            this.gbguvenlik.TabIndex = 41;
            this.gbguvenlik.TabStop = false;
            this.gbguvenlik.Text = "Güvenlik";
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.BackColor = System.Drawing.Color.Transparent;
            this.lbldurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldurum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldurum.Location = new System.Drawing.Point(70, 207);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(0, 20);
            this.lbldurum.TabIndex = 95;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 181);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 23);
            this.progressBar1.TabIndex = 94;
            // 
            // txttsifre
            // 
            this.txttsifre.Location = new System.Drawing.Point(102, 135);
            this.txttsifre.Name = "txttsifre";
            this.txttsifre.PasswordChar = '*';
            this.txttsifre.Size = new System.Drawing.Size(104, 26);
            this.txttsifre.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(19, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Şifre Tekrar:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(103, 95);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(103, 26);
            this.txtsifre.TabIndex = 91;
            this.txtsifre.TextChanged += new System.EventHandler(this.txtsifre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(60, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Eski Şifreniz";
            // 
            // lblkodu
            // 
            this.lblkodu.AutoSize = true;
            this.lblkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkodu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblkodu.Location = new System.Drawing.Point(15, 245);
            this.lblkodu.Name = "lblkodu";
            this.lblkodu.Size = new System.Drawing.Size(124, 42);
            this.lblkodu.TabIndex = 36;
            this.lblkodu.Text = "label2";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguncelle.ImageKey = "repeat.png";
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(114, 233);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(96, 54);
            this.btnguncelle.TabIndex = 34;
            this.btnguncelle.Text = "Kodu Değiştir";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "accept.png");
            this.ımageList1.Images.SetKeyName(1, "back.png");
            this.ımageList1.Images.SetKeyName(2, "Comic Icons 3 folder_downloads.png");
            this.ımageList1.Images.SetKeyName(3, "repeat.png");
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(17, 293);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(108, 26);
            this.txtkod.TabIndex = 30;
            this.txtkod.Text = "Kodu Giriniz";
            // 
            // lblkod
            // 
            this.lblkod.AutoSize = true;
            this.lblkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkod.Location = new System.Drawing.Point(24, 247);
            this.lblkod.Name = "lblkod";
            this.lblkod.Size = new System.Drawing.Size(122, 42);
            this.lblkod.TabIndex = 29;
            this.lblkod.Text = "lblkod";
            // 
            // btnonayla
            // 
            this.btnonayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnonayla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnonayla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnonayla.ImageKey = "accept.png";
            this.btnonayla.ImageList = this.ımageList1;
            this.btnonayla.Location = new System.Drawing.Point(5, 340);
            this.btnonayla.Name = "btnonayla";
            this.btnonayla.Size = new System.Drawing.Size(91, 53);
            this.btnonayla.TabIndex = 27;
            this.btnonayla.Text = "Onayla";
            this.btnonayla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnonayla.UseVisualStyleBackColor = true;
            this.btnonayla.Click += new System.EventHandler(this.btnonayla_Click);
            // 
            // txteskisifre
            // 
            this.txteskisifre.Location = new System.Drawing.Point(103, 50);
            this.txteskisifre.Name = "txteskisifre";
            this.txteskisifre.Size = new System.Drawing.Size(108, 26);
            this.txteskisifre.TabIndex = 25;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AntrenmanSistemi.Properties.Resources.wp9ea8b4c62;
            this.ClientSize = new System.Drawing.Size(334, 427);
            this.Controls.Add(this.gbguvenlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antrenman Takip Sistemi - Şifre Değiştir";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.gbguvenlik.ResumeLayout(false);
            this.gbguvenlik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbguvenlik;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.Label lblkod;
        private System.Windows.Forms.Button btnonayla;
        private System.Windows.Forms.TextBox txteskisifre;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txttsifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkodu;
    }
}