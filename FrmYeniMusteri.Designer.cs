namespace Pansiyon_Otomasyonu
{
    partial class FrmYeniMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniMusteri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirişTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.txtOda = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnOda303 = new System.Windows.Forms.Button();
            this.BtnOda302 = new System.Windows.Forms.Button();
            this.BtnOda301 = new System.Windows.Forms.Button();
            this.BtnOda203 = new System.Windows.Forms.Button();
            this.BtnOda202 = new System.Windows.Forms.Button();
            this.BtnOda201 = new System.Windows.Forms.Button();
            this.BtnOda103 = new System.Windows.Forms.Button();
            this.BtnOda102 = new System.Windows.Forms.Button();
            this.BtnOda101 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.DtpGirişTarihi);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.txtOda);
            this.groupBox1.Controls.Add(this.TxtTC);
            this.groupBox1.Controls.Add(this.MskTelefon);
            this.groupBox1.Controls.Add(this.CmbCinsiyet);
            this.groupBox1.Controls.Add(this.TxtSoyadi);
            this.groupBox1.Controls.Add(this.TxtAdi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(557, 490);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri ";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(233, 414);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(196, 37);
            this.BtnKaydet.TabIndex = 36;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Location = new System.Drawing.Point(194, 368);
            this.DtpCikisTarihi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(279, 22);
            this.DtpCikisTarihi.TabIndex = 35;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirişTarihi
            // 
            this.DtpGirişTarihi.Location = new System.Drawing.Point(194, 328);
            this.DtpGirişTarihi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpGirişTarihi.Name = "DtpGirişTarihi";
            this.DtpGirişTarihi.Size = new System.Drawing.Size(279, 22);
            this.DtpGirişTarihi.TabIndex = 34;
            // 
            // TxtUcret
            // 
            this.TxtUcret.Enabled = false;
            this.TxtUcret.Location = new System.Drawing.Point(194, 287);
            this.TxtUcret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(279, 22);
            this.TxtUcret.TabIndex = 33;
            this.TxtUcret.TextChanged += new System.EventHandler(this.TxtUcret_TextChanged);
            // 
            // txtOda
            // 
            this.txtOda.Enabled = false;
            this.txtOda.Location = new System.Drawing.Point(194, 251);
            this.txtOda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOda.Name = "txtOda";
            this.txtOda.Size = new System.Drawing.Size(279, 22);
            this.txtOda.TabIndex = 32;
            // 
            // TxtTC
            // 
            this.TxtTC.Location = new System.Drawing.Point(194, 210);
            this.TxtTC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTC.MaxLength = 11;
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(279, 22);
            this.TxtTC.TabIndex = 31;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(194, 171);
            this.MskTelefon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(279, 22);
            this.MskTelefon.TabIndex = 30;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(194, 129);
            this.CmbCinsiyet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(279, 24);
            this.CmbCinsiyet.TabIndex = 29;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Location = new System.Drawing.Point(194, 91);
            this.TxtSoyadi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(279, 22);
            this.TxtSoyadi.TabIndex = 28;
            // 
            // TxtAdi
            // 
            this.TxtAdi.Location = new System.Drawing.Point(194, 45);
            this.TxtAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(279, 22);
            this.TxtAdi.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(82, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Telefon :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(28, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "T.C  Kimlik No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(28, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Oda Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(89, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ücret :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giriş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 368);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Çıkış Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cinsiyet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adı :";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button11.Location = new System.Drawing.Point(1105, 522);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(64, 40);
            this.button11.TabIndex = 21;
            this.button11.Text = "Boş";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(1023, 522);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 40);
            this.button12.TabIndex = 22;
            this.button12.Text = "Dolu";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.BtnOda303);
            this.groupBox2.Controls.Add(this.BtnOda302);
            this.groupBox2.Controls.Add(this.BtnOda301);
            this.groupBox2.Controls.Add(this.BtnOda203);
            this.groupBox2.Controls.Add(this.BtnOda202);
            this.groupBox2.Controls.Add(this.BtnOda201);
            this.groupBox2.Controls.Add(this.BtnOda103);
            this.groupBox2.Controls.Add(this.BtnOda102);
            this.groupBox2.Controls.Add(this.BtnOda101);
            this.groupBox2.Location = new System.Drawing.Point(621, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 490);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BtnOda303
            // 
            this.BtnOda303.BackColor = System.Drawing.Color.Green;
            this.BtnOda303.Location = new System.Drawing.Point(250, 241);
            this.BtnOda303.Name = "BtnOda303";
            this.BtnOda303.Size = new System.Drawing.Size(64, 64);
            this.BtnOda303.TabIndex = 8;
            this.BtnOda303.Text = "303";
            this.BtnOda303.UseVisualStyleBackColor = false;
            this.BtnOda303.Click += new System.EventHandler(this.BtnOda303_Click);
            // 
            // BtnOda302
            // 
            this.BtnOda302.BackColor = System.Drawing.Color.Green;
            this.BtnOda302.Location = new System.Drawing.Point(140, 241);
            this.BtnOda302.Name = "BtnOda302";
            this.BtnOda302.Size = new System.Drawing.Size(64, 64);
            this.BtnOda302.TabIndex = 7;
            this.BtnOda302.Text = "302";
            this.BtnOda302.UseVisualStyleBackColor = false;
            this.BtnOda302.Click += new System.EventHandler(this.BtnOda302_Click);
            // 
            // BtnOda301
            // 
            this.BtnOda301.BackColor = System.Drawing.Color.Green;
            this.BtnOda301.Location = new System.Drawing.Point(40, 241);
            this.BtnOda301.Name = "BtnOda301";
            this.BtnOda301.Size = new System.Drawing.Size(64, 64);
            this.BtnOda301.TabIndex = 6;
            this.BtnOda301.Text = "301";
            this.BtnOda301.UseVisualStyleBackColor = false;
            this.BtnOda301.Click += new System.EventHandler(this.BtnOda301_Click);
            // 
            // BtnOda203
            // 
            this.BtnOda203.BackColor = System.Drawing.Color.Green;
            this.BtnOda203.Location = new System.Drawing.Point(250, 153);
            this.BtnOda203.Name = "BtnOda203";
            this.BtnOda203.Size = new System.Drawing.Size(64, 64);
            this.BtnOda203.TabIndex = 5;
            this.BtnOda203.Text = "203";
            this.BtnOda203.UseVisualStyleBackColor = false;
            this.BtnOda203.Click += new System.EventHandler(this.BtnOda203_Click);
            // 
            // BtnOda202
            // 
            this.BtnOda202.BackColor = System.Drawing.Color.Green;
            this.BtnOda202.Location = new System.Drawing.Point(140, 153);
            this.BtnOda202.Name = "BtnOda202";
            this.BtnOda202.Size = new System.Drawing.Size(64, 64);
            this.BtnOda202.TabIndex = 4;
            this.BtnOda202.Text = "202";
            this.BtnOda202.UseVisualStyleBackColor = false;
            this.BtnOda202.Click += new System.EventHandler(this.BtnOda202_Click);
            // 
            // BtnOda201
            // 
            this.BtnOda201.BackColor = System.Drawing.Color.Green;
            this.BtnOda201.Location = new System.Drawing.Point(40, 153);
            this.BtnOda201.Name = "BtnOda201";
            this.BtnOda201.Size = new System.Drawing.Size(64, 64);
            this.BtnOda201.TabIndex = 3;
            this.BtnOda201.Text = "201";
            this.BtnOda201.UseVisualStyleBackColor = false;
            this.BtnOda201.Click += new System.EventHandler(this.BtnOda201_Click);
            // 
            // BtnOda103
            // 
            this.BtnOda103.BackColor = System.Drawing.Color.Green;
            this.BtnOda103.Location = new System.Drawing.Point(250, 48);
            this.BtnOda103.Name = "BtnOda103";
            this.BtnOda103.Size = new System.Drawing.Size(64, 64);
            this.BtnOda103.TabIndex = 2;
            this.BtnOda103.Text = "103";
            this.BtnOda103.UseVisualStyleBackColor = false;
            this.BtnOda103.Click += new System.EventHandler(this.BtnOda103_Click);
            // 
            // BtnOda102
            // 
            this.BtnOda102.BackColor = System.Drawing.Color.Green;
            this.BtnOda102.Location = new System.Drawing.Point(140, 48);
            this.BtnOda102.Name = "BtnOda102";
            this.BtnOda102.Size = new System.Drawing.Size(64, 64);
            this.BtnOda102.TabIndex = 1;
            this.BtnOda102.Text = "102";
            this.BtnOda102.UseVisualStyleBackColor = false;
            this.BtnOda102.Click += new System.EventHandler(this.BtnOda102_Click);
            // 
            // BtnOda101
            // 
            this.BtnOda101.BackColor = System.Drawing.Color.Green;
            this.BtnOda101.Location = new System.Drawing.Point(40, 48);
            this.BtnOda101.Name = "BtnOda101";
            this.BtnOda101.Size = new System.Drawing.Size(64, 64);
            this.BtnOda101.TabIndex = 0;
            this.BtnOda101.Text = "101";
            this.BtnOda101.UseVisualStyleBackColor = false;
            this.BtnOda101.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1244, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmYeniMusteri";
            this.Text = "FrmYeniMusteri";
            this.Load += new System.EventHandler(this.FrmYeniMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirişTarihi;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.TextBox txtOda;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOda303;
        private System.Windows.Forms.Button BtnOda302;
        private System.Windows.Forms.Button BtnOda301;
        private System.Windows.Forms.Button BtnOda203;
        private System.Windows.Forms.Button BtnOda202;
        private System.Windows.Forms.Button BtnOda201;
        private System.Windows.Forms.Button BtnOda103;
        private System.Windows.Forms.Button BtnOda102;
        private System.Windows.Forms.Button BtnOda101;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}