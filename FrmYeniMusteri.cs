using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Pansiyon_Otomasyonu
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J1DN52A\\SQLEXPRESS;Initial Catalog=VeloraHotel;Integrated Security=True; TrustServerCertificate=True");

        private void BtnOda101_Click(object sender, EventArgs e)
        {

            OdaButon_Click(sender, e);
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            OdaButon_Click(sender, e);
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            OdaButon_Click(sender, e);
        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {
            OdaButon_Click(sender, e);
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            OdaButon_Click(sender, e);
        }

        private void BtnOda203_Click(object sender, EventArgs e)
        {
            OdaButon_Click(sender, e);
        }

        private void BtnOda301_Click(object sender, EventArgs e)
        {
            OdaButon_Click(sender, e);
        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            OdaButon_Click(sender, e);
        }

        private void BtnOda303_Click(object sender, EventArgs e)
        {
            OdaButon_Click(sender, e);
        }

        private void OdaButon_Click(object sender, EventArgs e)
        {

            if (sender is Button btn)
            {
                txtOda.Text = btn.Text;

                // Toggle: kırmızıysa yeşil, değilse kırmızı
                btn.BackColor = (btn.BackColor == Color.Red) ? Color.Green : Color.Red;
            }

        }
        


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                    string sql = @"INSERT INTO MüsteriEkle
                                   (Adi, Soyadi, Cinsiyet, Telefon, TC, OdaNo, Ucret, GirisTarihi, CikisTarihi)
                                   VALUES
                                   (@Adi, @Soyadi, @Cinsiyet, @Telefon, @TC, @OdaNo, @Ucret, @GirisTarihi, @CikisTarihi)";

                    using (SqlCommand komut = new SqlCommand(sql, baglanti))
                    {
                        
                        komut.Parameters.AddWithValue("@Adi", TxtAdi.Text.Trim());
                        komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text.Trim());
                        komut.Parameters.AddWithValue("@Cinsiyet", CmbCinsiyet.Text);
                        komut.Parameters.AddWithValue("@Telefon", MskTelefon.Text.Trim());
                        komut.Parameters.AddWithValue("@TC", TxtTC.Text.Trim());
                        komut.Parameters.AddWithValue("@OdaNo", txtOda.Text.Trim());
                        komut.Parameters.AddWithValue("@Ucret", decimal.Parse(TxtUcret.Text.Trim()));
                        komut.Parameters.AddWithValue("@GirisTarihi", DtpGirişTarihi.Value);
                        komut.Parameters.AddWithValue("@CikisTarihi", DtpCikisTarihi.Value);

                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Müşteri başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxtUcret_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT Fiyat FROM Odalar WHERE OdaNo = @OdaNo", baglanti);
            cmd.Parameters.AddWithValue("@OdaNo", Convert.ToInt32(txtOda.Text));
            int gecelikUcret = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();

            DateTime girisTarihi = DtpGirişTarihi.Value.Date;
            DateTime cikisTarihi = DtpCikisTarihi.Value.Date;

            int gunSayisi = (cikisTarihi - girisTarihi).Days;

            // Minimum 1 gün
            if (gunSayisi <= 0)
                gunSayisi = 1;

            int toplamUcret = gunSayisi * gecelikUcret;
            TxtUcret.Text = toplamUcret.ToString();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {

            List<Button> odaButonlari = new List<Button>
    {
        BtnOda101, BtnOda102, BtnOda103,
        BtnOda201, BtnOda202, BtnOda203,
        BtnOda301, BtnOda302, BtnOda303
    };

            foreach (var btn in odaButonlari)
                btn.Click += OdaButon_Click; // 


            foreach (var btn in odaButonlari)
                btn.Click += OdaButon_Click;

            // DB’den dolu odaları çek
            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "SELECT DISTINCT OdaNo FROM MüsteriEkle WHERE GETDATE() BETWEEN GirisTarihi AND CikisTarihi",
                baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            HashSet<string> doluOdalar = new HashSet<string>();
            while (oku.Read())
                doluOdalar.Add(oku["OdaNo"].ToString());

            oku.Close();
            baglanti.Close();

            // Renkleri set et
            foreach (var btn in odaButonlari)
                btn.BackColor = doluOdalar.Contains(btn.Text) ? Color.Red : Color.Green;
        }
        }
    }

//Data Source=DESKTOP-J1DN52A\SQLEXPRESS;Initial Catalog=VeloraHotel;Integrated Security=True;Trust Server Certificate=True