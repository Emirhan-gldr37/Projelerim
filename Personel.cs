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
    public partial class Personel : Form
    {
        public Form1 AnaForm;

        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            cmbMeslek.Items.Add("Yönetici");
            cmbMeslek.Items.Add("Teknisyen");
            cmbMeslek.Items.Add("Kasiyer");

            cmbMeslek.SelectedIndex = 0;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            mtxtTelefon.Clear();
            cmbMeslek.SelectedIndex = 0;
            txtFotoYolu.Clear();
            txtEposta.Clear();
            datePersonel.Value = DateTime.Now;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "Fotoğraf Seç";
            dosya.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                txtFotoYolu.Text = dosya.FileName;
                picTek.ImageLocation = dosya.FileName;
            }

        }

        private void btnKayıtekle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = mtxtTelefon.Text;
            string meslek = cmbMeslek.SelectedItem.ToString();
            string posta = txtEposta.Text;
            if (ad == "" || soyad == "" || telefon == "" || posta == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                return;
            }
            VeriEkle();
        }
        private void VeriEkle()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = mtxtTelefon.Text;
            string meslek = cmbMeslek.SelectedItem.ToString();
            string posta = txtEposta.Text;

            using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
            {
                try
                {
                    baglanti.Open();
                    
                    string query = "INSERT INTO Calısanlar (TekAd, TekSoyad, TekTelefon, TekPosta, TekFoto, TekMeslek, TekGiris) VALUES (@Ad, @Soyad, @Telefon, @Posta, @Foto, @Meslek, @Giris)";

                    using (SqlCommand cmd = new SqlCommand(query, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@Telefon", telefon);
                        cmd.Parameters.AddWithValue("@Posta", posta);
                        cmd.Parameters.AddWithValue("@Foto", txtFotoYolu.Text);
                        cmd.Parameters.AddWithValue("@Meslek", meslek);
                        cmd.Parameters.AddWithValue("@Giris", datePersonel.Value.ToString("yyyy-MM-dd"));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kayıt başarıyla eklendi ve ID otomatik atandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void lblAd1_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSoyad_Click(object sender, EventArgs e)
        {

        }
    }
}
