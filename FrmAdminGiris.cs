using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Otomasyonu
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-J1DN52A\\SQLEXPRESS;Initial Catalog=VeloraHotel;Integrated Security=True; TrustServerCertificate=True");

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullanici.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            baglan.Open();

            
            SqlCommand cmdYonetici = new SqlCommand("SELECT COUNT(*) FROM YoneticiGirisi WHERE Kullanici=@kul AND Sifre=@sif", baglan);
            cmdYonetici.Parameters.AddWithValue("@kul", kullanici);
            cmdYonetici.Parameters.AddWithValue("@sif", sifre);

            int yoneticiSayisi = (int)cmdYonetici.ExecuteScalar();

            if (yoneticiSayisi > 0)
            {
                MessageBox.Show("Yönetici girişi başarılı!");
                FrmYonetici frmY = new FrmYonetici();
                frmY.Show();
                this.Hide();
                return;
            }

            
            SqlCommand cmdAdmin = new SqlCommand("SELECT COUNT(*) FROM AdminGiris WHERE Kullanici=@kul AND Sifre=@sif", baglan);
            cmdAdmin.Parameters.AddWithValue("@kul", kullanici);
            cmdAdmin.Parameters.AddWithValue("@sif", sifre);

            int adminSayisi = (int)cmdAdmin.ExecuteScalar();

            if (adminSayisi > 0)
            {
              
                FrmAnaSayfa frmA = new FrmAnaSayfa();
                frmA.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
        }
        }
    }

