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

namespace TESET._3
{
    public partial class Servis : Form
    {
        public Servis()
        {
            InitializeComponent();
        }

        private void btnKayıtekle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
            {
                try
                {
                    baglanti.Open();

                    string query = "INSERT INTO Servis (ServisTarihi, ArızaAciklama, CihazAd, MüsteriAd, MüsteriSoyad, MüsteriTelefon) VALUES (@ServisTarihi, @ArızaAciklama, @CihazAd, @MüsteriAd, @MüsteriSoyad, @MüsteriTelefon)";

                    using (SqlCommand cmd = new SqlCommand(query, baglanti))
                    {

                        cmd.Parameters.AddWithValue("@ServisTarihi", dateServis.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@ArızaAciklama", cmbArıza.Text);
                        cmd.Parameters.AddWithValue("@CihazAd", txtCihaz.Text);
                        cmd.Parameters.AddWithValue("@MüsteriAd", txtAd.Text);
                        cmd.Parameters.AddWithValue("@MüsteriSoyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@MüsteriTelefon", mtxtTelefon.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kayıt başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Servis_Load(object sender, EventArgs e)
        {
            cmbArıza.SelectedIndex = -1;
            cmbArıza.Items.Add("Donanımsal");
            cmbArıza.Items.Add("Yazılımsal");
            cmbArıza.Items.Add("İkiside");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtCihaz.Clear();
            mtxtTelefon.Clear();
            cmbArıza.SelectedIndex = -1;
            dateServis.Value = DateTime.Now;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
