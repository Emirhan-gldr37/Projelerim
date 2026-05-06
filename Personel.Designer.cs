namespace TESET._3
{
    partial class Personel
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
            panel1 = new Panel();
            datePersonel = new DateTimePicker();
            lblDate = new Label();
            lblPosta = new Label();
            txtEposta = new TextBox();
            lblfoto = new Label();
            btnFoto = new Button();
            txtFotoYolu = new TextBox();
            picTek = new PictureBox();
            mtxtTelefon = new MaskedTextBox();
            lblTelefon = new Label();
            lblMeslek = new Label();
            cmbMeslek = new ComboBox();
            txtSoyad = new TextBox();
            lblSoyad = new Label();
            lblAd1 = new Label();
            btnTemizle = new Button();
            btnKayıtekle = new Button();
            txtAd = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTek).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(datePersonel);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblPosta);
            panel1.Controls.Add(txtEposta);
            panel1.Controls.Add(lblfoto);
            panel1.Controls.Add(btnFoto);
            panel1.Controls.Add(txtFotoYolu);
            panel1.Controls.Add(picTek);
            panel1.Controls.Add(mtxtTelefon);
            panel1.Controls.Add(lblTelefon);
            panel1.Controls.Add(lblMeslek);
            panel1.Controls.Add(cmbMeslek);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(lblSoyad);
            panel1.Controls.Add(lblAd1);
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(btnKayıtekle);
            panel1.Controls.Add(txtAd);
            panel1.Location = new Point(144, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 424);
            panel1.TabIndex = 2;
            // 
            // datePersonel
            // 
            datePersonel.Location = new Point(53, 325);
            datePersonel.Name = "datePersonel";
            datePersonel.Size = new Size(200, 23);
            datePersonel.TabIndex = 23;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(53, 293);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(91, 15);
            lblDate.TabIndex = 22;
            lblDate.Text = "Başlangıç Tarihi.";
            // 
            // lblPosta
            // 
            lblPosta.AutoSize = true;
            lblPosta.Location = new Point(53, 225);
            lblPosta.Name = "lblPosta";
            lblPosta.Size = new Size(47, 15);
            lblPosta.TabIndex = 21;
            lblPosta.Text = "E-posta";
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(53, 255);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(164, 23);
            txtEposta.TabIndex = 20;
            // 
            // lblfoto
            // 
            lblfoto.AutoSize = true;
            lblfoto.Location = new Point(342, 198);
            lblfoto.Name = "lblfoto";
            lblfoto.Size = new Size(76, 15);
            lblfoto.TabIndex = 19;
            lblfoto.Text = "Fotoğraf Ekle";
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.CornflowerBlue;
            btnFoto.ForeColor = SystemColors.ButtonFace;
            btnFoto.Location = new Point(302, 246);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(150, 32);
            btnFoto.TabIndex = 18;
            btnFoto.Text = "Ekle";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // txtFotoYolu
            // 
            txtFotoYolu.Location = new Point(302, 217);
            txtFotoYolu.Name = "txtFotoYolu";
            txtFotoYolu.Size = new Size(150, 23);
            txtFotoYolu.TabIndex = 17;
            // 
            // picTek
            // 
            picTek.BorderStyle = BorderStyle.FixedSingle;
            picTek.Location = new Point(302, 45);
            picTek.Name = "picTek";
            picTek.Size = new Size(150, 150);
            picTek.TabIndex = 16;
            picTek.TabStop = false;
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(53, 188);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(164, 23);
            mtxtTelefon.TabIndex = 15;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(53, 170);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(45, 15);
            lblTelefon.TabIndex = 14;
            lblTelefon.Text = "Telefon";
            // 
            // lblMeslek
            // 
            lblMeslek.AutoSize = true;
            lblMeslek.Location = new Point(302, 293);
            lblMeslek.Name = "lblMeslek";
            lblMeslek.Size = new Size(83, 15);
            lblMeslek.TabIndex = 12;
            lblMeslek.Text = "Meslek Seçiniz";
            // 
            // cmbMeslek
            // 
            cmbMeslek.FormattingEnabled = true;
            cmbMeslek.Location = new Point(302, 311);
            cmbMeslek.Name = "cmbMeslek";
            cmbMeslek.Size = new Size(150, 23);
            cmbMeslek.TabIndex = 11;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(53, 125);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(164, 23);
            txtSoyad.TabIndex = 8;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(53, 107);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 7;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd1
            // 
            lblAd1.AutoSize = true;
            lblAd1.Location = new Point(53, 51);
            lblAd1.Name = "lblAd1";
            lblAd1.Size = new Size(22, 15);
            lblAd1.TabIndex = 6;
            lblAd1.Text = "Ad";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(192, 0, 0);
            btnTemizle.ForeColor = SystemColors.ButtonFace;
            btnTemizle.Location = new Point(302, 359);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 32);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKayıtekle
            // 
            btnKayıtekle.BackColor = Color.FromArgb(0, 192, 0);
            btnKayıtekle.ForeColor = SystemColors.ButtonFace;
            btnKayıtekle.Location = new Point(377, 359);
            btnKayıtekle.Name = "btnKayıtekle";
            btnKayıtekle.Size = new Size(75, 32);
            btnKayıtekle.TabIndex = 2;
            btnKayıtekle.Text = "Kayıt Ol";
            btnKayıtekle.UseVisualStyleBackColor = false;
            btnKayıtekle.Click += btnKayıtekle_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(53, 69);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(164, 23);
            txtAd.TabIndex = 0;
            // 
            // Personel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            ClientSize = new Size(800, 614);
            Controls.Add(panel1);
            Name = "Personel";
            Text = "Personel";
            Load += Personel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTek).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPosta;
        private TextBox txtEposta;
        private Label lblfoto;
        private Button btnFoto;
        private TextBox txtFotoYolu;
        private PictureBox picTek;
        private MaskedTextBox mtxtTelefon;
        private Label lblTelefon;
        private Label lblMeslek;
        private ComboBox cmbMeslek;
        private TextBox txtSoyad;
        private Label lblSoyad;
        private Label lblAd1;
        private Button btnTemizle;
        private Button btnKayıtekle;
        private TextBox txtAd;
        private DateTimePicker datePersonel;
        private Label lblDate;
    }
}