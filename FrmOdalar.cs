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
using System.Data.Sql;
using System.Data.SqlClient;




namespace Pansiyon_Otomasyonu
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-J1DN52A\\SQLEXPRESS;Initial Catalog=VeloraHotel;Integrated Security=True; TrustServerCertificate=True");


        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            var odalar = new Dictionary<int, Button>
{
    {101, BtnOda101},
    {102, BtnOda102},
    {103, BtnOda103},
    {201, BtnOda201},
    {202, BtnOda202},
    {203, BtnOda203},
    {301, BtnOda301},
    {302, BtnOda302},
    {303, BtnOda303},
};

            baglan.Open();

            foreach (var oda in odalar)
            {
                string sorgu = "SELECT COUNT(*) FROM MüsteriEkle WHERE OdaNo = @OdaNo AND CikisTarihi >= GETDATE()";
                SqlCommand cmd = new SqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@OdaNo", oda.Key);

                int sonuc = (int)cmd.ExecuteScalar();

                if (sonuc > 0)
                {
                    oda.Value.BackColor = Color.Red;
                    oda.Value.Enabled = false;
                }
                else
                {
                    oda.Value.BackColor = Color.Green;
                    oda.Value.Enabled = true;
                }
            }

            baglan.Close();

        }

        
        private IEnumerable<Control> GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                yield return c;
                foreach (var child in GetAllControls(c))
                    yield return child;
            }
        }
    }

    }

