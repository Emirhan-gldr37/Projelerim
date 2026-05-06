namespace TESET._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelGiris = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            picGiris = new PictureBox();
            tabEnvanter = new TabPage();
            txtTür = new Panel();
            txtTürEkle = new TextBox();
            btnEkle = new Button();
            btnAdetSil = new Button();
            btnParcaGüncelle = new Button();
            btnSilParca = new Button();
            btnKayıtParca = new Button();
            label8 = new Label();
            txtEkleAdet = new TextBox();
            txtÜcretEkle = new TextBox();
            txtAdEkle = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            txtParcaTürü = new TextBox();
            label4 = new Label();
            txtAdet = new TextBox();
            txtÜcret = new TextBox();
            txtParcaAd = new TextBox();
            lblÜcret = new Label();
            lblParcaAd = new Label();
            lblAdet = new Label();
            dataEnvanter = new DataGridView();
            tabServis = new TabPage();
            btnGüncelServis = new Button();
            btnSilSservis = new Button();
            btnKaydetServis = new Button();
            dataServis = new DataGridView();
            panel1 = new Panel();
            txtArıza = new TextBox();
            label7 = new Label();
            txtCihazAd = new TextBox();
            txtTelServis = new TextBox();
            txtDateServis = new TextBox();
            txtSoyadServis = new TextBox();
            txtAdServis = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            tabCalisanlar = new TabPage();
            btnGüncelle = new Button();
            btnKayıtSil = new Button();
            btnKayıtEkle = new Button();
            dataCalisan = new DataGridView();
            panelA = new Panel();
            txtPosta = new TextBox();
            txtMeslek = new TextBox();
            txtTel = new TextBox();
            txtDate = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblDate = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            lblPosta = new Label();
            lblTelefon = new Label();
            lblMeslek = new Label();
            picCalisan = new PictureBox();
            tabControl1 = new TabControl();
            panel3 = new Panel();
            panelGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGiris).BeginInit();
            tabEnvanter.SuspendLayout();
            txtTür.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataEnvanter).BeginInit();
            tabServis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataServis).BeginInit();
            panel1.SuspendLayout();
            tabCalisanlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataCalisan).BeginInit();
            panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCalisan).BeginInit();
            tabControl1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelGiris
            // 
            panelGiris.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelGiris.BackColor = Color.Silver;
            panelGiris.BorderStyle = BorderStyle.FixedSingle;
            panelGiris.Controls.Add(button3);
            panelGiris.Controls.Add(button2);
            panelGiris.Controls.Add(button1);
            panelGiris.Controls.Add(picGiris);
            panelGiris.Location = new Point(1, 0);
            panelGiris.Name = "panelGiris";
            panelGiris.Size = new Size(219, 604);
            panelGiris.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 57, 153);
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(23, 266);
            button3.Name = "button3";
            button3.Size = new Size(164, 42);
            button3.TabIndex = 4;
            button3.Text = "Envanter";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 57, 153);
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(23, 218);
            button2.Name = "button2";
            button2.Size = new Size(164, 42);
            button2.TabIndex = 3;
            button2.Text = "Servis";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 57, 153);
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(23, 170);
            button1.Name = "button1";
            button1.Size = new Size(164, 42);
            button1.TabIndex = 2;
            button1.Text = "Çalışanlar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // picGiris
            // 
            picGiris.BackgroundImage = Properties.Resources.TESET;
            picGiris.BorderStyle = BorderStyle.FixedSingle;
            picGiris.Location = new Point(23, 26);
            picGiris.Name = "picGiris";
            picGiris.Size = new Size(164, 119);
            picGiris.SizeMode = PictureBoxSizeMode.StretchImage;
            picGiris.TabIndex = 1;
            picGiris.TabStop = false;
            // 
            // tabEnvanter
            // 
            tabEnvanter.BackgroundImage = Properties.Resources.arkaplan;
            tabEnvanter.Controls.Add(txtTür);
            tabEnvanter.Controls.Add(panel2);
            tabEnvanter.Controls.Add(dataEnvanter);
            tabEnvanter.Location = new Point(4, 24);
            tabEnvanter.Name = "tabEnvanter";
            tabEnvanter.Padding = new Padding(3);
            tabEnvanter.Size = new Size(961, 576);
            tabEnvanter.TabIndex = 2;
            tabEnvanter.Text = "Envanter";
            tabEnvanter.UseVisualStyleBackColor = true;
            // 
            // txtTür
            // 
            txtTür.Anchor = AnchorStyles.None;
            txtTür.BackColor = Color.FromArgb(30, 57, 153);
            txtTür.Controls.Add(txtTürEkle);
            txtTür.Controls.Add(btnEkle);
            txtTür.Controls.Add(btnAdetSil);
            txtTür.Controls.Add(btnParcaGüncelle);
            txtTür.Controls.Add(btnSilParca);
            txtTür.Controls.Add(btnKayıtParca);
            txtTür.Controls.Add(label8);
            txtTür.Controls.Add(txtEkleAdet);
            txtTür.Controls.Add(txtÜcretEkle);
            txtTür.Controls.Add(txtAdEkle);
            txtTür.Controls.Add(label9);
            txtTür.Controls.Add(label10);
            txtTür.Controls.Add(label11);
            txtTür.Location = new Point(573, 13);
            txtTür.Name = "txtTür";
            txtTür.Size = new Size(366, 394);
            txtTür.TabIndex = 21;
            // 
            // txtTürEkle
            // 
            txtTürEkle.Location = new Point(135, 69);
            txtTürEkle.Name = "txtTürEkle";
            txtTürEkle.Size = new Size(199, 23);
            txtTürEkle.TabIndex = 33;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(0, 192, 0);
            btnEkle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkle.ForeColor = SystemColors.ButtonFace;
            btnEkle.Location = new Point(198, 262);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(136, 42);
            btnEkle.TabIndex = 32;
            btnEkle.Text = "Adet Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnAdetSil
            // 
            btnAdetSil.BackColor = Color.FromArgb(192, 0, 0);
            btnAdetSil.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdetSil.ForeColor = SystemColors.ButtonFace;
            btnAdetSil.Location = new Point(19, 262);
            btnAdetSil.Name = "btnAdetSil";
            btnAdetSil.Size = new Size(136, 42);
            btnAdetSil.TabIndex = 31;
            btnAdetSil.Text = "Adet Sil";
            btnAdetSil.UseVisualStyleBackColor = false;
            btnAdetSil.Click += btnAdetSil_Click;
            // 
            // btnParcaGüncelle
            // 
            btnParcaGüncelle.BackColor = Color.FromArgb(0, 0, 192);
            btnParcaGüncelle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParcaGüncelle.ForeColor = SystemColors.ButtonFace;
            btnParcaGüncelle.Location = new Point(198, 329);
            btnParcaGüncelle.Name = "btnParcaGüncelle";
            btnParcaGüncelle.Size = new Size(136, 42);
            btnParcaGüncelle.TabIndex = 30;
            btnParcaGüncelle.Text = "Güncelle";
            btnParcaGüncelle.UseVisualStyleBackColor = false;
            btnParcaGüncelle.Click += btnParcaGüncelle_Click;
            // 
            // btnSilParca
            // 
            btnSilParca.BackColor = Color.FromArgb(192, 0, 0);
            btnSilParca.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSilParca.ForeColor = SystemColors.ButtonFace;
            btnSilParca.Location = new Point(19, 196);
            btnSilParca.Name = "btnSilParca";
            btnSilParca.Size = new Size(136, 42);
            btnSilParca.TabIndex = 29;
            btnSilParca.Text = "Kaydı Sil";
            btnSilParca.UseVisualStyleBackColor = false;
            btnSilParca.Click += btnSilParca_Click;
            // 
            // btnKayıtParca
            // 
            btnKayıtParca.BackColor = Color.FromArgb(0, 192, 0);
            btnKayıtParca.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKayıtParca.ForeColor = SystemColors.ButtonFace;
            btnKayıtParca.Location = new Point(198, 196);
            btnKayıtParca.Name = "btnKayıtParca";
            btnKayıtParca.Size = new Size(136, 42);
            btnKayıtParca.TabIndex = 28;
            btnKayıtParca.Text = "Kayıt Ekle";
            btnKayıtParca.UseVisualStyleBackColor = false;
            btnKayıtParca.Click += btnKayıtParca_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(17, 66);
            label8.Name = "label8";
            label8.Size = new Size(112, 22);
            label8.TabIndex = 26;
            label8.Text = "Parça Türü:";
            // 
            // txtEkleAdet
            // 
            txtEkleAdet.Location = new Point(135, 148);
            txtEkleAdet.Name = "txtEkleAdet";
            txtEkleAdet.Size = new Size(199, 23);
            txtEkleAdet.TabIndex = 23;
            txtEkleAdet.TextChanged += txtEkleAdet_TextChanged;
            // 
            // txtÜcretEkle
            // 
            txtÜcretEkle.Location = new Point(135, 112);
            txtÜcretEkle.Name = "txtÜcretEkle";
            txtÜcretEkle.Size = new Size(199, 23);
            txtÜcretEkle.TabIndex = 21;
            // 
            // txtAdEkle
            // 
            txtAdEkle.Location = new Point(135, 26);
            txtAdEkle.Name = "txtAdEkle";
            txtAdEkle.Size = new Size(199, 23);
            txtAdEkle.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(12, 109);
            label9.Name = "label9";
            label9.Size = new Size(117, 22);
            label9.TabIndex = 18;
            label9.Text = "Parça Ücret:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(31, 23);
            label10.Name = "label10";
            label10.Size = new Size(98, 22);
            label10.TabIndex = 16;
            label10.Text = "Parça Adı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(19, 149);
            label11.Name = "label11";
            label11.Size = new Size(109, 22);
            label11.TabIndex = 9;
            label11.Text = "Parça Adet:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(30, 57, 153);
            panel2.Controls.Add(txtParcaTürü);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtAdet);
            panel2.Controls.Add(txtÜcret);
            panel2.Controls.Add(txtParcaAd);
            panel2.Controls.Add(lblÜcret);
            panel2.Controls.Add(lblParcaAd);
            panel2.Controls.Add(lblAdet);
            panel2.Location = new Point(175, 429);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 125);
            panel2.TabIndex = 20;
            // 
            // txtParcaTürü
            // 
            txtParcaTürü.Location = new Point(135, 69);
            txtParcaTürü.Name = "txtParcaTürü";
            txtParcaTürü.ReadOnly = true;
            txtParcaTürü.Size = new Size(199, 23);
            txtParcaTürü.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(17, 66);
            label4.Name = "label4";
            label4.Size = new Size(112, 22);
            label4.TabIndex = 26;
            label4.Text = "Parça Türü:";
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(485, 26);
            txtAdet.Name = "txtAdet";
            txtAdet.ReadOnly = true;
            txtAdet.Size = new Size(140, 23);
            txtAdet.TabIndex = 23;
            // 
            // txtÜcret
            // 
            txtÜcret.Location = new Point(485, 69);
            txtÜcret.Name = "txtÜcret";
            txtÜcret.ReadOnly = true;
            txtÜcret.Size = new Size(140, 23);
            txtÜcret.TabIndex = 21;
            // 
            // txtParcaAd
            // 
            txtParcaAd.Location = new Point(135, 26);
            txtParcaAd.Name = "txtParcaAd";
            txtParcaAd.ReadOnly = true;
            txtParcaAd.Size = new Size(199, 23);
            txtParcaAd.TabIndex = 19;
            // 
            // lblÜcret
            // 
            lblÜcret.AutoSize = true;
            lblÜcret.BackColor = Color.Transparent;
            lblÜcret.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblÜcret.ForeColor = SystemColors.ButtonFace;
            lblÜcret.Location = new Point(362, 66);
            lblÜcret.Name = "lblÜcret";
            lblÜcret.Size = new Size(117, 22);
            lblÜcret.TabIndex = 18;
            lblÜcret.Text = "Parça Ücret:";
            // 
            // lblParcaAd
            // 
            lblParcaAd.AutoSize = true;
            lblParcaAd.BackColor = Color.Transparent;
            lblParcaAd.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParcaAd.ForeColor = SystemColors.ButtonFace;
            lblParcaAd.Location = new Point(31, 23);
            lblParcaAd.Name = "lblParcaAd";
            lblParcaAd.Size = new Size(98, 22);
            lblParcaAd.TabIndex = 16;
            lblParcaAd.Text = "Parça Adı:";
            // 
            // lblAdet
            // 
            lblAdet.AutoSize = true;
            lblAdet.BackColor = Color.Transparent;
            lblAdet.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdet.ForeColor = SystemColors.ButtonFace;
            lblAdet.Location = new Point(370, 23);
            lblAdet.Name = "lblAdet";
            lblAdet.Size = new Size(109, 22);
            lblAdet.TabIndex = 9;
            lblAdet.Text = "Parça Adet:";
            // 
            // dataEnvanter
            // 
            dataEnvanter.BackgroundColor = SystemColors.ButtonFace;
            dataEnvanter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEnvanter.Location = new Point(27, 16);
            dataEnvanter.Name = "dataEnvanter";
            dataEnvanter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataEnvanter.Size = new Size(531, 394);
            dataEnvanter.TabIndex = 19;
            dataEnvanter.CellContentClick += dataEnvanter_CellContentClick;
            // 
            // tabServis
            // 
            tabServis.BackgroundImage = Properties.Resources.arkaplan;
            tabServis.Controls.Add(btnGüncelServis);
            tabServis.Controls.Add(btnSilSservis);
            tabServis.Controls.Add(btnKaydetServis);
            tabServis.Controls.Add(dataServis);
            tabServis.Controls.Add(panel1);
            tabServis.Location = new Point(4, 24);
            tabServis.Name = "tabServis";
            tabServis.Padding = new Padding(3);
            tabServis.Size = new Size(961, 576);
            tabServis.TabIndex = 1;
            tabServis.Text = "Servis";
            tabServis.UseVisualStyleBackColor = true;
            tabServis.Click += tabServis_Click;
            // 
            // btnGüncelServis
            // 
            btnGüncelServis.Anchor = AnchorStyles.None;
            btnGüncelServis.BackColor = Color.FromArgb(0, 0, 192);
            btnGüncelServis.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGüncelServis.ForeColor = SystemColors.ButtonFace;
            btnGüncelServis.Location = new Point(769, 508);
            btnGüncelServis.Name = "btnGüncelServis";
            btnGüncelServis.Size = new Size(85, 42);
            btnGüncelServis.TabIndex = 23;
            btnGüncelServis.Text = "Güncelle";
            btnGüncelServis.UseVisualStyleBackColor = false;
            btnGüncelServis.Click += btnGüncelServis_Click;
            // 
            // btnSilSservis
            // 
            btnSilSservis.Anchor = AnchorStyles.None;
            btnSilSservis.BackColor = Color.FromArgb(192, 0, 0);
            btnSilSservis.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSilSservis.ForeColor = SystemColors.ButtonFace;
            btnSilSservis.Location = new Point(769, 445);
            btnSilSservis.Name = "btnSilSservis";
            btnSilSservis.Size = new Size(85, 42);
            btnSilSservis.TabIndex = 22;
            btnSilSservis.Text = "Kaydı Sil";
            btnSilSservis.UseVisualStyleBackColor = false;
            btnSilSservis.Click += btnSilServis_Click;
            // 
            // btnKaydetServis
            // 
            btnKaydetServis.Anchor = AnchorStyles.None;
            btnKaydetServis.BackColor = Color.FromArgb(0, 192, 0);
            btnKaydetServis.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKaydetServis.ForeColor = SystemColors.ButtonFace;
            btnKaydetServis.Location = new Point(769, 379);
            btnKaydetServis.Name = "btnKaydetServis";
            btnKaydetServis.Size = new Size(85, 42);
            btnKaydetServis.TabIndex = 21;
            btnKaydetServis.Text = "Kayıt Ekle";
            btnKaydetServis.UseVisualStyleBackColor = false;
            btnKaydetServis.Click += btnKaydetServis_Click;
            // 
            // dataServis
            // 
            dataServis.BackgroundColor = SystemColors.ButtonFace;
            dataServis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataServis.Location = new Point(119, 38);
            dataServis.Name = "dataServis";
            dataServis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataServis.Size = new Size(735, 335);
            dataServis.TabIndex = 18;
            dataServis.CellContentClick += dataServis_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 57, 153);
            panel1.Controls.Add(txtArıza);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtCihazAd);
            panel1.Controls.Add(txtTelServis);
            panel1.Controls.Add(txtDateServis);
            panel1.Controls.Add(txtSoyadServis);
            panel1.Controls.Add(txtAdServis);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(119, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 171);
            panel1.TabIndex = 14;
            // 
            // txtArıza
            // 
            txtArıza.Location = new Point(488, 123);
            txtArıza.Name = "txtArıza";
            txtArıza.ReadOnly = true;
            txtArıza.Size = new Size(140, 23);
            txtArıza.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(356, 120);
            label7.Name = "label7";
            label7.Size = new Size(126, 22);
            label7.TabIndex = 26;
            label7.Text = "Arıza Tanımı:";
            // 
            // txtCihazAd
            // 
            txtCihazAd.Location = new Point(488, 23);
            txtCihazAd.Name = "txtCihazAd";
            txtCihazAd.ReadOnly = true;
            txtCihazAd.Size = new Size(140, 23);
            txtCihazAd.TabIndex = 23;
            // 
            // txtTelServis
            // 
            txtTelServis.Location = new Point(196, 123);
            txtTelServis.Name = "txtTelServis";
            txtTelServis.ReadOnly = true;
            txtTelServis.Size = new Size(140, 23);
            txtTelServis.TabIndex = 22;
            // 
            // txtDateServis
            // 
            txtDateServis.Location = new Point(488, 72);
            txtDateServis.Name = "txtDateServis";
            txtDateServis.ReadOnly = true;
            txtDateServis.Size = new Size(140, 23);
            txtDateServis.TabIndex = 21;
            // 
            // txtSoyadServis
            // 
            txtSoyadServis.Location = new Point(196, 72);
            txtSoyadServis.Name = "txtSoyadServis";
            txtSoyadServis.ReadOnly = true;
            txtSoyadServis.Size = new Size(140, 23);
            txtSoyadServis.TabIndex = 20;
            // 
            // txtAdServis
            // 
            txtAdServis.Location = new Point(196, 23);
            txtAdServis.Name = "txtAdServis";
            txtAdServis.ReadOnly = true;
            txtAdServis.Size = new Size(140, 23);
            txtAdServis.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(356, 69);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 18;
            label1.Text = "Servis Tarihi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(20, 66);
            label2.Name = "label2";
            label2.Size = new Size(139, 22);
            label2.TabIndex = 17;
            label2.Text = "Müşteri Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(116, 22);
            label3.TabIndex = 16;
            label3.Text = "Müşteri Adı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(20, 121);
            label5.Name = "label5";
            label5.Size = new Size(162, 22);
            label5.TabIndex = 10;
            label5.Text = "Müşteri Telefonu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(387, 20);
            label6.Name = "label6";
            label6.Size = new Size(95, 22);
            label6.TabIndex = 9;
            label6.Text = "Cihaz Adı:";
            // 
            // tabCalisanlar
            // 
            tabCalisanlar.BackgroundImage = Properties.Resources.arkaplan;
            tabCalisanlar.Controls.Add(btnGüncelle);
            tabCalisanlar.Controls.Add(btnKayıtSil);
            tabCalisanlar.Controls.Add(btnKayıtEkle);
            tabCalisanlar.Controls.Add(dataCalisan);
            tabCalisanlar.Controls.Add(panelA);
            tabCalisanlar.Location = new Point(4, 24);
            tabCalisanlar.Name = "tabCalisanlar";
            tabCalisanlar.Padding = new Padding(3);
            tabCalisanlar.Size = new Size(961, 576);
            tabCalisanlar.TabIndex = 0;
            tabCalisanlar.Text = "Çalışanlar";
            tabCalisanlar.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGüncelle.AutoSize = true;
            btnGüncelle.BackColor = Color.FromArgb(0, 0, 192);
            btnGüncelle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGüncelle.ForeColor = SystemColors.ButtonFace;
            btnGüncelle.Location = new Point(782, 291);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(150, 42);
            btnGüncelle.TabIndex = 20;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnKayıtSil
            // 
            btnKayıtSil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKayıtSil.AutoSize = true;
            btnKayıtSil.BackColor = Color.FromArgb(192, 0, 0);
            btnKayıtSil.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKayıtSil.ForeColor = SystemColors.ButtonFace;
            btnKayıtSil.Location = new Point(782, 243);
            btnKayıtSil.Name = "btnKayıtSil";
            btnKayıtSil.Size = new Size(150, 42);
            btnKayıtSil.TabIndex = 19;
            btnKayıtSil.Text = "Kaydı Sil";
            btnKayıtSil.UseVisualStyleBackColor = false;
            btnKayıtSil.Click += btnKayıtSil_Click;
            // 
            // btnKayıtEkle
            // 
            btnKayıtEkle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKayıtEkle.AutoSize = true;
            btnKayıtEkle.BackColor = Color.FromArgb(0, 192, 0);
            btnKayıtEkle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKayıtEkle.ForeColor = SystemColors.ButtonFace;
            btnKayıtEkle.Location = new Point(782, 195);
            btnKayıtEkle.Name = "btnKayıtEkle";
            btnKayıtEkle.Size = new Size(150, 42);
            btnKayıtEkle.TabIndex = 18;
            btnKayıtEkle.Text = "Kayıt Ekle";
            btnKayıtEkle.UseVisualStyleBackColor = false;
            btnKayıtEkle.Click += btnKayıtEkle_Click_1;
            // 
            // dataCalisan
            // 
            dataCalisan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataCalisan.BackgroundColor = SystemColors.ButtonFace;
            dataCalisan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCalisan.Location = new Point(21, 194);
            dataCalisan.Name = "dataCalisan";
            dataCalisan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataCalisan.Size = new Size(717, 368);
            dataCalisan.TabIndex = 17;
            dataCalisan.CellContentClick += dataCalisan_CellContentClick;
            // 
            // panelA
            // 
            panelA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelA.BackColor = Color.FromArgb(30, 57, 153);
            panelA.BorderStyle = BorderStyle.FixedSingle;
            panelA.Controls.Add(txtPosta);
            panelA.Controls.Add(txtMeslek);
            panelA.Controls.Add(txtTel);
            panelA.Controls.Add(txtDate);
            panelA.Controls.Add(txtSoyad);
            panelA.Controls.Add(txtAd);
            panelA.Controls.Add(lblDate);
            panelA.Controls.Add(lblSoyad);
            panelA.Controls.Add(lblAd);
            panelA.Controls.Add(lblPosta);
            panelA.Controls.Add(lblTelefon);
            panelA.Controls.Add(lblMeslek);
            panelA.Controls.Add(picCalisan);
            panelA.Location = new Point(0, 14);
            panelA.Name = "panelA";
            panelA.Size = new Size(962, 160);
            panelA.TabIndex = 13;
            // 
            // txtPosta
            // 
            txtPosta.Location = new Point(597, 122);
            txtPosta.Name = "txtPosta";
            txtPosta.ReadOnly = true;
            txtPosta.Size = new Size(140, 23);
            txtPosta.TabIndex = 24;
            // 
            // txtMeslek
            // 
            txtMeslek.Location = new Point(597, 72);
            txtMeslek.Name = "txtMeslek";
            txtMeslek.ReadOnly = true;
            txtMeslek.Size = new Size(140, 23);
            txtMeslek.TabIndex = 23;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(597, 23);
            txtTel.Name = "txtTel";
            txtTel.ReadOnly = true;
            txtTel.Size = new Size(140, 23);
            txtTel.TabIndex = 22;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(151, 122);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(140, 23);
            txtDate.TabIndex = 21;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(151, 72);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.ReadOnly = true;
            txtSoyad.Size = new Size(140, 23);
            txtSoyad.TabIndex = 20;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(151, 23);
            txtAd.Name = "txtAd";
            txtAd.ReadOnly = true;
            txtAd.Size = new Size(140, 23);
            txtAd.TabIndex = 19;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ButtonFace;
            lblDate.Location = new Point(31, 123);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(114, 22);
            lblDate.TabIndex = 18;
            lblDate.Text = "Giriş Tarihi:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.BackColor = Color.Transparent;
            lblSoyad.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoyad.ForeColor = SystemColors.ButtonFace;
            lblSoyad.Location = new Point(78, 73);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(67, 22);
            lblSoyad.TabIndex = 17;
            lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.BackColor = Color.Transparent;
            lblAd.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAd.ForeColor = SystemColors.ButtonFace;
            lblAd.Location = new Point(107, 20);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(38, 22);
            lblAd.TabIndex = 16;
            lblAd.Text = "Ad:";
            // 
            // lblPosta
            // 
            lblPosta.AutoSize = true;
            lblPosta.BackColor = Color.Transparent;
            lblPosta.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosta.ForeColor = SystemColors.ButtonFace;
            lblPosta.Location = new Point(504, 123);
            lblPosta.Name = "lblPosta";
            lblPosta.Size = new Size(80, 22);
            lblPosta.TabIndex = 11;
            lblPosta.Text = "E-posta:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.BackColor = Color.Transparent;
            lblTelefon.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefon.ForeColor = SystemColors.ButtonFace;
            lblTelefon.Location = new Point(504, 20);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(79, 22);
            lblTelefon.TabIndex = 10;
            lblTelefon.Text = "Telefon:";
            // 
            // lblMeslek
            // 
            lblMeslek.AutoSize = true;
            lblMeslek.BackColor = Color.Transparent;
            lblMeslek.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMeslek.ForeColor = SystemColors.ButtonFace;
            lblMeslek.Location = new Point(504, 73);
            lblMeslek.Name = "lblMeslek";
            lblMeslek.Size = new Size(77, 22);
            lblMeslek.TabIndex = 9;
            lblMeslek.Text = "Meslek:";
            // 
            // picCalisan
            // 
            picCalisan.BackgroundImage = Properties.Resources.Adsız_tasarım;
            picCalisan.BorderStyle = BorderStyle.FixedSingle;
            picCalisan.Location = new Point(778, 4);
            picCalisan.Name = "picCalisan";
            picCalisan.Size = new Size(150, 150);
            picCalisan.SizeMode = PictureBoxSizeMode.StretchImage;
            picCalisan.TabIndex = 15;
            picCalisan.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabCalisanlar);
            tabControl1.Controls.Add(tabServis);
            tabControl1.Controls.Add(tabEnvanter);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(969, 604);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(tabControl1);
            panel3.Location = new Point(222, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(969, 604);
            panel3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 604);
            Controls.Add(panelGiris);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "T.E.S.E.T.";
            Load += Form1_Load;
            panelGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picGiris).EndInit();
            tabEnvanter.ResumeLayout(false);
            txtTür.ResumeLayout(false);
            txtTür.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataEnvanter).EndInit();
            tabServis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataServis).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabCalisanlar.ResumeLayout(false);
            tabCalisanlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataCalisan).EndInit();
            panelA.ResumeLayout(false);
            panelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCalisan).EndInit();
            tabControl1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGiris;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox picGiris;
        private TabPage tabEnvanter;
        private Panel txtTür;
        private TextBox txtTürEkle;
        private Button btnEkle;
        private Button btnAdetSil;
        private Button btnParcaGüncelle;
        private Button btnSilParca;
        private Button btnKayıtParca;
        private Label label8;
        private TextBox txtEkleAdet;
        private TextBox txtÜcretEkle;
        private TextBox txtAdEkle;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private TextBox txtParcaTürü;
        private Label label4;
        private TextBox txtAdet;
        private TextBox txtÜcret;
        private TextBox txtParcaAd;
        private Label lblÜcret;
        private Label lblParcaAd;
        private Label lblAdet;
        private DataGridView dataEnvanter;
        private TabPage tabServis;
        private Button btnGüncelServis;
        private Button btnSilSservis;
        private Button btnKaydetServis;
        private DataGridView dataServis;
        private Panel panel1;
        private TextBox txtArıza;
        private Label label7;
        private TextBox txtCihazAd;
        private TextBox txtTelServis;
        private TextBox txtDateServis;
        private TextBox txtSoyadServis;
        private TextBox txtAdServis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TabPage tabCalisanlar;
        private Button btnGüncelle;
        private Button btnKayıtSil;
        private Button btnKayıtEkle;
        private DataGridView dataCalisan;
        private Panel panelA;
        private TextBox txtPosta;
        private TextBox txtMeslek;
        private TextBox txtTel;
        private TextBox txtDate;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lblDate;
        private Label lblSoyad;
        private Label lblAd;
        private Label lblPosta;
        private Label lblTelefon;
        private Label lblMeslek;
        private PictureBox picCalisan;
        private TabControl tabControl1;
        private Panel panel3;
    }
}
