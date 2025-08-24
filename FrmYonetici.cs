using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Otomasyonu
{
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frmAdminGiris = new FrmAdminGiris();
            frmAdminGiris.Show();
            this.Hide();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOdalar = new FrmOdalar();
            frmOdalar.Show();
            
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frmYeniMusteri = new FrmYeniMusteri();
            frmYeniMusteri.Show();

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteriler frmMusteriler = new FrmMusteriler();
            frmMusteriler.Show();

        }

        private void btnKullanıcı_Click(object sender, EventArgs e)
        {
            FrmKullaniciEkle frmKullaniciEkle = new FrmKullaniciEkle();
            frmKullaniciEkle.Show();

        }
    }
}
