using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Otomasyonu
{
    public partial class FrmKullaniciEkle : Form
    {
        public FrmKullaniciEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-J1DN52A\\SQLEXPRESS;Initial Catalog=VeloraHotel;Integrated Security=True; TrustServerCertificate=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullanici.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string secim = CmbRol.SelectedItem?.ToString(); // Admin veya Yönetici seçimi

            if (string.IsNullOrWhiteSpace(kullanici) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(secim))
            {
                MessageBox.Show("Lütfen rol seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tablo adını düzelt: YöneticiGirisi
            string tabloAdi = (secim == "Admin") ? "AdminGiris" : "YoneticiGirisi";

            try
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand(
                    $"INSERT INTO {tabloAdi} (Kullanici, Sifre) VALUES (@kul, @sif)",
                    baglan
                );
                cmd.Parameters.AddWithValue("@kul", kullanici);
                cmd.Parameters.AddWithValue("@sif", sifre);

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show($"{secim} başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKullanici.Clear();
                    txtSifre.Clear();
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }
  
