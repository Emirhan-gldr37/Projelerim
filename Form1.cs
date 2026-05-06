using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;

namespace TESET._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayıtEkle_Click_1(object sender, EventArgs e)
        {
            Personel frm = new Personel();
            frm.AnaForm = this;
            frm.ShowDialog();
        }

        private void VerileriListele()
        {

            using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
            {
                try
                {
                    baglanti.Open();
                    string query = "SELECT * FROM Calısanlar";

                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataCalisan.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler listelenirken hata oluştu: " + ex.Message);
                }
                dataCalisan.Columns["TekID"].HeaderText = "Personel ID";
                dataCalisan.Columns["TekAd"].HeaderText = "Adı";
                dataCalisan.Columns["TekSoyad"].HeaderText = "Soyadı";
                dataCalisan.Columns["TekTelefon"].HeaderText = "Telefon";
                dataCalisan.Columns["TekPosta"].HeaderText = "E-Posta";
                dataCalisan.Columns["TekFoto"].HeaderText = "Fotoğraf Yolu";
                dataCalisan.Columns["TekMeslek"].HeaderText = "Meslek";
                dataCalisan.Columns["TekGiris"].HeaderText = "Giriş Tarihi";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
            {
                try
                {
                    baglanti.Open();
                    string query = "SELECT * FROM  Parca";

                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataEnvanter.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler listelenirken hata oluştu: " + ex.Message);
                }
                dataEnvanter.Columns["ParcaId"].HeaderText = "Parça ID";
                dataEnvanter.Columns["ParcaAd"].HeaderText = "Parça Adı";
                dataEnvanter.Columns["ParcaAdet"].HeaderText = "Parça Adet";
                dataEnvanter.Columns["ParcaFiyat"].HeaderText = "Parça Fiyatı";
                dataEnvanter.Columns["ParcaTürü"].HeaderText = "Parça Türü";
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {

            if (dataCalisan.SelectedRows.Count > 0)
            {

                DialogResult secim = MessageBox.Show("Seçili personeli silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (secim == DialogResult.Yes)
                {

                    int secilenId = Convert.ToInt32(dataCalisan.SelectedRows[0].Cells["TekID"].Value);


                    using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
                    {
                        try
                        {
                            baglanti.Open();
                            string query = "DELETE FROM Calısanlar WHERE TekID = @TekID";

                            using (SqlCommand cmd = new SqlCommand(query, baglanti))
                            {
                                cmd.Parameters.AddWithValue("@TekID", secilenId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            VerileriListele();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataCalisan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataCalisan.Rows[e.RowIndex];

                txtAd.Text = row.Cells["TekAd"].Value?.ToString();
                txtSoyad.Text = row.Cells["TekSoyad"].Value?.ToString();
                txtTel.Text = row.Cells["TekTelefon"].Value?.ToString();
                txtPosta.Text = row.Cells["TekPosta"].Value?.ToString();
                txtMeslek.Text = row.Cells["TekMeslek"].Value?.ToString();
                txtDate.Text = row.Cells["TekGiris"].Value?.ToString();

                if (e.RowIndex >= 0)
                {

                    string fotoYolu = dataCalisan.Rows[e.RowIndex].Cells[5].Value.ToString();

                    if (fotoYolu != "")
                    {
                        picCalisan.ImageLocation = fotoYolu;
                    }
                    else
                    {
                        picCalisan.Image = null;
                    }

                }
            }
        }

        private void VerileriListeleServis()
        {

            using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
            {
                try
                {
                    baglanti.Open();
                    string query = "SELECT * FROM Servis";

                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataServis.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler listelenirken hata oluştu: " + ex.Message);
                }
                dataServis.Columns["ServisID"].HeaderText = "Servis ID";
                dataServis.Columns["ServisTarihi"].HeaderText = "Servis Tarihi";
                dataServis.Columns["ArızaAciklama"].HeaderText = "Arıza Açıklaması";
                dataServis.Columns["CihazAd"].HeaderText = "Cihaz Adı";
                dataServis.Columns["MüsteriAd"].HeaderText = "Müşteri Adı";
                dataServis.Columns["MüsteriSoyad"].HeaderText = "Müşteri Soyadı";
                dataServis.Columns["MüsteriTelefon"].HeaderText = "Müşteri Telefon";
            }
        }

        private void btnGüncelServis_Click(object sender, EventArgs e)
        {
            VerileriListeleServis();
        }

        private void btnSilServis_Click(object sender, EventArgs e)
        {
            if (dataServis.SelectedRows.Count > 0)
            {

                DialogResult secim = MessageBox.Show("Seçili İşlemi Silmek İstediğinize Emin Misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (secim == DialogResult.Yes)
                {

                    int secilenId = Convert.ToInt32(dataServis.SelectedRows[0].Cells["ServisID"].Value);


                    using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
                    {
                        try
                        {
                            baglanti.Open();
                            string query = "DELETE FROM Servis WHERE ServisId = @ServisID";

                            using (SqlCommand cmd = new SqlCommand(query, baglanti))
                            {
                                cmd.Parameters.AddWithValue("@ServisID", secilenId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            VerileriListeleServis();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataServis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataServis.Rows[e.RowIndex];

                txtAdServis.Text = row.Cells["MüsteriAd"].Value?.ToString();
                txtSoyadServis.Text = row.Cells["MüsteriSoyad"].Value?.ToString();
                txtTelServis.Text = row.Cells["MüsteriTelefon"].Value?.ToString();
                txtCihazAd.Text = row.Cells["CihazAd"].Value?.ToString();
                txtDateServis.Text = row.Cells["ServisTarihi"].Value?.ToString();
                txtArıza.Text = row.Cells["ArızaAciklama"].Value?.ToString();

            }
        }

        private void tabServis_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydetServis_Click(object sender, EventArgs e)
        {
            Servis servis = new Servis();
            servis.ShowDialog();
        }

        private void dataEnvanter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataEnvanter.Rows[e.RowIndex];

                txtParcaAd.Text = row.Cells["ParcaAd"].Value?.ToString();
                txtParcaTürü.Text = row.Cells["ParcaTürü"].Value?.ToString();
                txtAdet.Text = row.Cells["ParcaAdet"].Value?.ToString();
                txtÜcret.Text = row.Cells["ParcaFiyat"].Value?.ToString();

            }
        }

        private void btnParcaGüncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
            {
                try
                {
                    baglanti.Open();
                    string query = "SELECT * FROM  Parca";

                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataEnvanter.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler listelenirken hata oluştu: " + ex.Message);
                }
                dataEnvanter.Columns["ParcaId"].HeaderText = "Parça ID";
                dataEnvanter.Columns["ParcaAd"].HeaderText = "Parça Adı";
                dataEnvanter.Columns["ParcaAdet"].HeaderText = "Parça Adet";
                dataEnvanter.Columns["ParcaFiyat"].HeaderText = "Parça Fiyatı";
                dataEnvanter.Columns["ParcaTürü"].HeaderText = "Parça Türü";
            }
        }

        private void btnKayıtParca_Click(object sender, EventArgs e)
        {
            string ad = txtAdEkle.Text;
            string tür = txtTürEkle.Text;
            if (!int.TryParse(txtEkleAdet.Text, out int adet) || !int.TryParse(txtÜcretEkle.Text, out int ücret))
            {
                MessageBox.Show("Lütfen geçerli bir adet girin.");
                return;
            }
            using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
            {
                try
                {
                    baglanti.Open();

                    string query = "INSERT INTO Parca (ParcaAd, ParcaTürü, ParcaAdet, ParcaFiyat) VALUES (@Ad, @Tür, @Adet, @Fiyat)";

                    using (SqlCommand cmd = new SqlCommand(query, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Tür", tür);
                        cmd.Parameters.AddWithValue("@Adet", adet);
                        cmd.Parameters.AddWithValue("@Fiyat", ücret);

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

        private void btnSilParca_Click(object sender, EventArgs e)
        {
            if (dataServis.SelectedRows.Count >= 0)
            {

                DialogResult secim = MessageBox.Show("Seçili İşlemi Silmek İstediğinize Emin Misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (secim == DialogResult.Yes)
                {

                    int secilenId = Convert.ToInt32(dataEnvanter.SelectedRows[0].Cells["ParcaID"].Value);


                    using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
                    {
                        try
                        {
                            baglanti.Open();
                            string query = "DELETE FROM Parca WHERE ParcaId = @ParcaID";

                            using (SqlCommand cmd = new SqlCommand(query, baglanti))
                            {
                                cmd.Parameters.AddWithValue("@ParcaID", secilenId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            VerileriListeleServis();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (dataEnvanter.SelectedRows.Count > 0)
            {

                if (int.TryParse(txtEkleAdet.Text, out int eklenecekAdet))
                {

                    int mevcutAdet = Convert.ToInt32(dataEnvanter.SelectedRows[0].Cells["ParcaAdet"].Value);

                    int yeniAdet = mevcutAdet + eklenecekAdet;

                    dataEnvanter.SelectedRows[0].Cells["ParcaAdet"].Value = yeniAdet;

                    try
                    {

                        using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
                        {
                            baglanti.Open();

                            string sorgu = "UPDATE dbo.Parca SET ParcaAdet = @YeniAdet WHERE ParcaId = @ParcaId";

                            using (System.Data.SqlClient.SqlCommand komut = new System.Data.SqlClient.SqlCommand(sorgu, baglanti))
                            {
                                komut.Parameters.AddWithValue("@YeniAdet", yeniAdet);
                                komut.Parameters.AddWithValue("@ParcaId", Convert.ToInt32(dataEnvanter.SelectedRows[0].Cells["ParcaId"].Value));
                                komut.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Adet başarıyla güncellendi ve kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen 'Parca Adet' kısmına geçerli bir sayı girin.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen işlem yapmak için listeden bir satır seçin.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdetSil_Click(object sender, EventArgs e)
        {
            if (dataEnvanter.SelectedRows.Count > 0)
            {

                if (int.TryParse(txtEkleAdet.Text, out int eksilcekAdet))
                {

                    int mevcutAdet = Convert.ToInt32(dataEnvanter.SelectedRows[0].Cells["ParcaAdet"].Value);

                    int yeniAdet = mevcutAdet - eksilcekAdet;

                    dataEnvanter.SelectedRows[0].Cells["ParcaAdet"].Value = yeniAdet;

                    try
                    {

                        using (SqlConnection baglanti = TESET._3.DatabaseContext.GetConnection())
                        {
                            baglanti.Open();

                            string sorgu = "UPDATE dbo.Parca SET ParcaAdet = @YeniAdet WHERE ParcaId = @ParcaId";

                            using (System.Data.SqlClient.SqlCommand komut = new System.Data.SqlClient.SqlCommand(sorgu, baglanti))
                            {
                                komut.Parameters.AddWithValue("@YeniAdet", yeniAdet);
                                komut.Parameters.AddWithValue("@ParcaId", Convert.ToInt32(dataEnvanter.SelectedRows[0].Cells["ParcaId"].Value));
                                komut.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Adet başarıyla güncellendi ve kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen 'Parca Adet' kısmına geçerli bir sayı girin.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen işlem yapmak için listeden bir satır seçin.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEkleAdet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
    }
}
