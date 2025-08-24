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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Pansiyon_Otomasyonu
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J1DN52A\\SQLEXPRESS;Initial Catalog=VeloraHotel;Integrated Security=True; TrustServerCertificate=True");

        private void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM MüsteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = @"UPDATE MüsteriEkle 
               SET Adi=@Adi, Soyadi=@Soyadi, Cinsiyet=@Cinsiyet, 
                   Telefon=@Telefon, TC=@TC, OdaNo=@OdaNo, Ucret=@Ucret, 
                   GirisTarihi=@GirisTarihi, CikisTarihi=@CikisTarihi 
               WHERE Musteriid=@Musteriid";

            using (SqlCommand komut = new SqlCommand(sql, baglanti))
            {
                komut.Parameters.AddWithValue("@Adi", txtAdi.Text);
                komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@Telefon", mskTelefon.Text);
                komut.Parameters.AddWithValue("@TC", txtTC.Text);
                komut.Parameters.AddWithValue("@OdaNo", txtOdaNo.Text);
                komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
                komut.Parameters.AddWithValue("@GirisTarihi", dtpGirisTarihi.Value); 
                komut.Parameters.AddWithValue("@CikisTarihi", dtpCikisTarihi.Value); 
                komut.Parameters.AddWithValue("@Musteriid", id);

                komut.ExecuteNonQuery();
            }

            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Silmek için bir kayıt seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int musteriId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string odaNo = listView1.SelectedItems[0].SubItems[1].Text.Trim(); 

            DialogResult onay = MessageBox.Show($"Oda {odaNo} kaydını silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;

            try
            {
                baglanti.Open();

               
                SqlCommand cmd = new SqlCommand("DELETE FROM MüsteriEkle WHERE Musteriid = @Musteriid", baglanti);
                cmd.Parameters.AddWithValue("@Musteriid", musteriId);
                int sonuc = cmd.ExecuteNonQuery();

                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show($"Oda {odaNo} kaydı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    listView1.Items.Remove(listView1.SelectedItems[0]);

                    foreach (System.Windows.Forms.Button btn in this.Controls.OfType<System.Windows.Forms.Button>())
                    {
                        if (btn.Text == odaNo)
                        {
                            btn.BackColor = Color.Green;
                            btn.Enabled = true;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Silinecek kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtTC.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            TxtSoyadi.Clear();
            cmbCinsiyet.Text = "";
            mskTelefon.Clear();
            txtTC.Clear();
            txtOdaNo.Clear();
            txtUcret.Clear();
            dtpGirisTarihi.Text = "";
            dtpCikisTarihi.Text = "";


        }
    }
}
