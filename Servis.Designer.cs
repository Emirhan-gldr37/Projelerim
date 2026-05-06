namespace TESET._3
{
    partial class Servis
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
            dateServis = new DateTimePicker();
            lblDate = new Label();
            lblPosta = new Label();
            txtCihaz = new TextBox();
            mtxtTelefon = new MaskedTextBox();
            lblTelefon = new Label();
            lblMeslek = new Label();
            cmbArıza = new ComboBox();
            txtSoyad = new TextBox();
            lblSoyad = new Label();
            lblAd1 = new Label();
            btnTemizle = new Button();
            btnKayıtekle = new Button();
            txtAd = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dateServis);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblPosta);
            panel1.Controls.Add(txtCihaz);
            panel1.Controls.Add(mtxtTelefon);
            panel1.Controls.Add(lblTelefon);
            panel1.Controls.Add(lblMeslek);
            panel1.Controls.Add(cmbArıza);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(lblSoyad);
            panel1.Controls.Add(lblAd1);
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(btnKayıtekle);
            panel1.Controls.Add(txtAd);
            panel1.Location = new Point(104, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 309);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // dateServis
            // 
            dateServis.Location = new Point(254, 185);
            dateServis.Name = "dateServis";
            dateServis.Size = new Size(150, 23);
            dateServis.TabIndex = 23;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(254, 170);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(71, 15);
            lblDate.TabIndex = 22;
            lblDate.Text = "Servis Tarihi:";
            // 
            // lblPosta
            // 
            lblPosta.AutoSize = true;
            lblPosta.Location = new Point(254, 107);
            lblPosta.Name = "lblPosta";
            lblPosta.Size = new Size(60, 15);
            lblPosta.TabIndex = 21;
            lblPosta.Text = "Cihaz Adı:";
            // 
            // txtCihaz
            // 
            txtCihaz.Location = new Point(254, 125);
            txtCihaz.Name = "txtCihaz";
            txtCihaz.Size = new Size(150, 23);
            txtCihaz.TabIndex = 20;
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(35, 188);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(164, 23);
            mtxtTelefon.TabIndex = 15;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(35, 170);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(98, 15);
            lblTelefon.TabIndex = 14;
            lblTelefon.Text = "Müşteri Telefonu:";
            // 
            // lblMeslek
            // 
            lblMeslek.AutoSize = true;
            lblMeslek.Location = new Point(254, 51);
            lblMeslek.Name = "lblMeslek";
            lblMeslek.Size = new Size(77, 15);
            lblMeslek.TabIndex = 12;
            lblMeslek.Text = "Arıza Tanıımı:";
            // 
            // cmbArıza
            // 
            cmbArıza.FormattingEnabled = true;
            cmbArıza.Location = new Point(254, 69);
            cmbArıza.Name = "cmbArıza";
            cmbArıza.Size = new Size(150, 23);
            cmbArıza.TabIndex = 11;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(35, 125);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(164, 23);
            txtSoyad.TabIndex = 8;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(35, 107);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(88, 15);
            lblSoyad.TabIndex = 7;
            lblSoyad.Text = "Müşteri Soyadı:";
            // 
            // lblAd1
            // 
            lblAd1.AutoSize = true;
            lblAd1.Location = new Point(35, 51);
            lblAd1.Name = "lblAd1";
            lblAd1.Size = new Size(71, 15);
            lblAd1.TabIndex = 6;
            lblAd1.Text = "Müşteri Adı:";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(192, 0, 0);
            btnTemizle.ForeColor = SystemColors.ButtonFace;
            btnTemizle.Location = new Point(329, 263);
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
            btnKayıtekle.Location = new Point(329, 225);
            btnKayıtekle.Name = "btnKayıtekle";
            btnKayıtekle.Size = new Size(75, 32);
            btnKayıtekle.TabIndex = 2;
            btnKayıtekle.Text = "Kayıt Ol";
            btnKayıtekle.UseVisualStyleBackColor = false;
            btnKayıtekle.Click += btnKayıtekle_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(35, 69);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(164, 23);
            txtAd.TabIndex = 0;
            // 
            // Servis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            ClientSize = new Size(658, 641);
            Controls.Add(panel1);
            Name = "Servis";
            Text = "Servis";
            Load += Servis_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateServis;
        private Label lblDate;
        private Label lblPosta;
        private TextBox txtCihaz;
        private MaskedTextBox mtxtTelefon;
        private Label lblTelefon;
        private Label lblMeslek;
        private ComboBox cmbArıza;
        private TextBox txtSoyad;
        private Label lblSoyad;
        private Label lblAd1;
        private Button btnTemizle;
        private Button btnKayıtekle;
        private TextBox txtAd;
    }
}