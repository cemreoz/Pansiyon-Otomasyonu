namespace Pansiyon_Otomasyonu
{
    partial class FrmYonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYonetici));
            this.btnKullanıcı = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKullanıcı
            // 
            this.btnKullanıcı.Location = new System.Drawing.Point(182, 322);
            this.btnKullanıcı.Name = "btnKullanıcı";
            this.btnKullanıcı.Size = new System.Drawing.Size(141, 116);
            this.btnKullanıcı.TabIndex = 19;
            this.btnKullanıcı.Text = "Yeni Kullanıcı Ekle";
            this.btnKullanıcı.UseVisualStyleBackColor = true;
            this.btnKullanıcı.Click += new System.EventHandler(this.btnKullanıcı_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Location = new System.Drawing.Point(83, 159);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(141, 116);
            this.btnMusteri.TabIndex = 18;
            this.btnMusteri.Text = "Müşteriler";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Location = new System.Drawing.Point(288, 159);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(141, 116);
            this.btnYeniMusteri.TabIndex = 17;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(83, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(141, 116);
            this.btnAdmin.TabIndex = 16;
            this.btnAdmin.Text = "Admin Giriş";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.Location = new System.Drawing.Point(288, 12);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(141, 116);
            this.btnOdalar.TabIndex = 15;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(605, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(804, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKullanıcı);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnOdalar);
            this.Name = "FrmYonetici";
            this.Text = "FrmYonetici";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullanıcı;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}