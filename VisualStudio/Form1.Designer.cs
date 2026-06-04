namespace LibraryManagementorj
{
    partial class Form1
    {
        private const bool V = false;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlAnaGiris = new Panel();
            btnKullaniciEkranDon = new Button();
            btnKutuphane = new Button();
            btnKitapEkleSil = new Button();
            btnEmanetAl = new Button();
            btnArama = new Button();
            btnUyeler = new Button();
            pnlKitapYonetim = new Panel();
            txtPublisherEmail = new TextBox();
            txtPublisherName = new TextBox();
            lblYayineviEmail = new Label();
            lblYayinevi = new Label();
            txtSayfaSayisi = new TextBox();
            lblSayfaSayisi = new Label();
            dgvKitapListesi = new DataGridView();
            btnGeriDonKitap = new Button();
            btnKitapSil = new Button();
            btnKitapKaydet = new Button();
            cmbKategori = new ComboBox();
            txtYazarSoyadı = new TextBox();
            txtYazarAdı = new TextBox();
            txtKitapAdı = new TextBox();
            lblKategori = new Label();
            lblYazarSoyadı = new Label();
            lblYazarAdı = new Label();
            lblKitapAdı = new Label();
            flpRaflar = new FlowLayoutPanel();
            pnlEmanetVer = new Panel();
            cmbKitapID = new ComboBox();
            cmbUyeID = new ComboBox();
            btnEmanetIDAl = new Button();
            lblEmanetID = new Label();
            txtEmanetID = new TextBox();
            dgvEmanetler = new DataGridView();
            lblTeslimTarihi = new Label();
            lblKitapID = new Label();
            lblUyeID = new Label();
            btnKaydet = new Button();
            dtpTeslimTarihi = new DateTimePicker();
            btnGeriDon4 = new Button();
            pnlEmanetAl = new Panel();
            btnGeriDon3 = new Button();
            pnlUyeler = new Panel();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            lblKullaniciAdi = new Label();
            btnGeriDon = new Button();
            btnUyeSil = new Button();
            btnUyeEkle = new Button();
            mtxtUyeTelefon = new MaskedTextBox();
            txtUyeEposta = new TextBox();
            lblUyeTelefon = new Label();
            lblUyeEposta = new Label();
            lblUyeSoyad = new Label();
            lblUyeAd = new Label();
            txtUyeSoyad = new TextBox();
            txtUyeAd = new TextBox();
            dgvUyeler = new DataGridView();
            pnlKitapAra = new Panel();
            button1 = new Button();
            dgvKitaplar = new DataGridView();
            btnAra = new Button();
            txtKitapAra = new TextBox();
            pnlAnaGiris.SuspendLayout();
            pnlKitapYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitapListesi).BeginInit();
            pnlEmanetVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetler).BeginInit();
            pnlEmanetAl.SuspendLayout();
            pnlUyeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            pnlKitapAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // pnlAnaGiris
            // 
            pnlAnaGiris.BackgroundImage = (Image)resources.GetObject("pnlAnaGiris.BackgroundImage");
            pnlAnaGiris.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAnaGiris.Controls.Add(btnKullaniciEkranDon);
            pnlAnaGiris.Controls.Add(btnKutuphane);
            pnlAnaGiris.Controls.Add(btnKitapEkleSil);
            pnlAnaGiris.Controls.Add(btnEmanetAl);
            pnlAnaGiris.Controls.Add(btnArama);
            pnlAnaGiris.Controls.Add(btnUyeler);
            pnlAnaGiris.Dock = DockStyle.Fill;
            pnlAnaGiris.Location = new Point(0, 0);
            pnlAnaGiris.Name = "pnlAnaGiris";
            pnlAnaGiris.Size = new Size(1248, 703);
            pnlAnaGiris.TabIndex = 5;
            // 
            // btnKullaniciEkranDon
            // 
            btnKullaniciEkranDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnKullaniciEkranDon.ForeColor = Color.PaleVioletRed;
            btnKullaniciEkranDon.Location = new Point(3, 3);
            btnKullaniciEkranDon.Name = "btnKullaniciEkranDon";
            btnKullaniciEkranDon.Size = new Size(263, 29);
            btnKullaniciEkranDon.TabIndex = 5;
            btnKullaniciEkranDon.Text = "Kullanıcı Ekranına Dön(❁´◡`❁)";
            btnKullaniciEkranDon.UseVisualStyleBackColor = true;
            btnKullaniciEkranDon.Click += btnKullaniciEkranDon_Click;
            // 
            // btnKutuphane
            // 
            btnKutuphane.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKutuphane.BackColor = Color.Transparent;
            btnKutuphane.Cursor = Cursors.Hand;
            btnKutuphane.FlatAppearance.BorderSize = 0;
            btnKutuphane.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKutuphane.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKutuphane.FlatStyle = FlatStyle.Flat;
            btnKutuphane.Location = new Point(461, 543);
            btnKutuphane.Name = "btnKutuphane";
            btnKutuphane.Size = new Size(383, 157);
            btnKutuphane.TabIndex = 2;
            btnKutuphane.UseVisualStyleBackColor = false;
            btnKutuphane.Click += btnKutuphane_Click;
            // 
            // btnKitapEkleSil
            // 
            btnKitapEkleSil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKitapEkleSil.BackColor = Color.Transparent;
            btnKitapEkleSil.Cursor = Cursors.Hand;
            btnKitapEkleSil.FlatAppearance.BorderSize = 0;
            btnKitapEkleSil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKitapEkleSil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKitapEkleSil.FlatStyle = FlatStyle.Flat;
            btnKitapEkleSil.Location = new Point(206, 566);
            btnKitapEkleSil.Name = "btnKitapEkleSil";
            btnKitapEkleSil.Size = new Size(123, 44);
            btnKitapEkleSil.TabIndex = 3;
            btnKitapEkleSil.UseVisualStyleBackColor = false;
            btnKitapEkleSil.Click += btnKitapEkleSil_Click;
            // 
            // btnEmanetAl
            // 
            btnEmanetAl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEmanetAl.BackColor = Color.Transparent;
            btnEmanetAl.Cursor = Cursors.Hand;
            btnEmanetAl.FlatAppearance.BorderSize = 0;
            btnEmanetAl.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEmanetAl.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEmanetAl.FlatStyle = FlatStyle.Flat;
            btnEmanetAl.Location = new Point(236, 631);
            btnEmanetAl.Name = "btnEmanetAl";
            btnEmanetAl.Size = new Size(118, 49);
            btnEmanetAl.TabIndex = 4;
            btnEmanetAl.UseVisualStyleBackColor = false;
            btnEmanetAl.Click += btnEmanetAl_Click;
            // 
            // btnArama
            // 
            btnArama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnArama.BackColor = Color.Transparent;
            btnArama.Cursor = Cursors.Hand;
            btnArama.FlatAppearance.BorderSize = 0;
            btnArama.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnArama.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnArama.FlatStyle = FlatStyle.Flat;
            btnArama.Location = new Point(543, 244);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(152, 166);
            btnArama.TabIndex = 0;
            btnArama.UseVisualStyleBackColor = false;
            btnArama.Click += btnArama_Click_1;
            // 
            // btnUyeler
            // 
            btnUyeler.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUyeler.BackColor = Color.Transparent;
            btnUyeler.Cursor = Cursors.Hand;
            btnUyeler.FlatAppearance.BorderSize = 0;
            btnUyeler.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUyeler.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUyeler.FlatStyle = FlatStyle.Flat;
            btnUyeler.Location = new Point(746, 244);
            btnUyeler.Name = "btnUyeler";
            btnUyeler.Size = new Size(166, 166);
            btnUyeler.TabIndex = 1;
            btnUyeler.UseVisualStyleBackColor = false;
            btnUyeler.Click += btnUyeler_Click_1;
            // 
            // pnlKitapYonetim
            // 
            pnlKitapYonetim.BackColor = Color.LavenderBlush;
            pnlKitapYonetim.BackgroundImageLayout = ImageLayout.Center;
            pnlKitapYonetim.Controls.Add(txtPublisherEmail);
            pnlKitapYonetim.Controls.Add(txtPublisherName);
            pnlKitapYonetim.Controls.Add(lblYayineviEmail);
            pnlKitapYonetim.Controls.Add(lblYayinevi);
            pnlKitapYonetim.Controls.Add(txtSayfaSayisi);
            pnlKitapYonetim.Controls.Add(lblSayfaSayisi);
            pnlKitapYonetim.Controls.Add(dgvKitapListesi);
            pnlKitapYonetim.Controls.Add(btnGeriDonKitap);
            pnlKitapYonetim.Controls.Add(btnKitapSil);
            pnlKitapYonetim.Controls.Add(btnKitapKaydet);
            pnlKitapYonetim.Controls.Add(cmbKategori);
            pnlKitapYonetim.Controls.Add(txtYazarSoyadı);
            pnlKitapYonetim.Controls.Add(txtYazarAdı);
            pnlKitapYonetim.Controls.Add(txtKitapAdı);
            pnlKitapYonetim.Controls.Add(lblKategori);
            pnlKitapYonetim.Controls.Add(lblYazarSoyadı);
            pnlKitapYonetim.Controls.Add(lblYazarAdı);
            pnlKitapYonetim.Controls.Add(lblKitapAdı);
            pnlKitapYonetim.Dock = DockStyle.Fill;
            pnlKitapYonetim.Location = new Point(0, 0);
            pnlKitapYonetim.Name = "pnlKitapYonetim";
            pnlKitapYonetim.Size = new Size(1248, 703);
            pnlKitapYonetim.TabIndex = 5;
            // 
            // txtPublisherEmail
            // 
            txtPublisherEmail.BackColor = Color.Plum;
            txtPublisherEmail.Location = new Point(575, 112);
            txtPublisherEmail.Name = "txtPublisherEmail";
            txtPublisherEmail.Size = new Size(125, 27);
            txtPublisherEmail.TabIndex = 19;
            // 
            // txtPublisherName
            // 
            txtPublisherName.BackColor = Color.Plum;
            txtPublisherName.Location = new Point(575, 68);
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(125, 27);
            txtPublisherName.TabIndex = 18;
            // 
            // lblYayineviEmail
            // 
            lblYayineviEmail.AutoSize = true;
            lblYayineviEmail.BackColor = Color.Thistle;
            lblYayineviEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYayineviEmail.Location = new Point(448, 115);
            lblYayineviEmail.Name = "lblYayineviEmail";
            lblYayineviEmail.Size = new Size(116, 20);
            lblYayineviEmail.TabIndex = 17;
            lblYayineviEmail.Text = "Yayın Evi Email:";
            // 
            // lblYayinevi
            // 
            lblYayinevi.AutoSize = true;
            lblYayinevi.BackColor = Color.Thistle;
            lblYayinevi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYayinevi.Location = new Point(448, 73);
            lblYayinevi.Name = "lblYayinevi";
            lblYayinevi.Size = new Size(74, 20);
            lblYayinevi.TabIndex = 16;
            lblYayinevi.Text = "Yayın Evi:";
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.BackColor = Color.Plum;
            txtSayfaSayisi.Location = new Point(278, 247);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(125, 27);
            txtSayfaSayisi.TabIndex = 14;
            // 
            // lblSayfaSayisi
            // 
            lblSayfaSayisi.AutoSize = true;
            lblSayfaSayisi.BackColor = Color.Thistle;
            lblSayfaSayisi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSayfaSayisi.Location = new Point(172, 242);
            lblSayfaSayisi.Name = "lblSayfaSayisi";
            lblSayfaSayisi.Size = new Size(94, 20);
            lblSayfaSayisi.TabIndex = 13;
            lblSayfaSayisi.Text = "Sayfa Sayısı:";
            // 
            // dgvKitapListesi
            // 
            dgvKitapListesi.BackgroundColor = Color.LightPink;
            dgvKitapListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitapListesi.Location = new Point(151, 352);
            dgvKitapListesi.Name = "dgvKitapListesi";
            dgvKitapListesi.RowHeadersWidth = 51;
            dgvKitapListesi.Size = new Size(589, 258);
            dgvKitapListesi.TabIndex = 12;
            // 
            // btnGeriDonKitap
            // 
            btnGeriDonKitap.Location = new Point(10, 10);
            btnGeriDonKitap.Name = "btnGeriDonKitap";
            btnGeriDonKitap.Size = new Size(94, 29);
            btnGeriDonKitap.TabIndex = 11;
            btnGeriDonKitap.Text = "←T_T";
            btnGeriDonKitap.UseVisualStyleBackColor = true;
            btnGeriDonKitap.Click += btnGeriDonKitap_Click;
            // 
            // btnKitapSil
            // 
            btnKitapSil.BackColor = Color.PaleVioletRed;
            btnKitapSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKitapSil.Location = new Point(784, 543);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(94, 29);
            btnKitapSil.TabIndex = 10;
            btnKitapSil.Text = "SİL➖";
            btnKitapSil.UseVisualStyleBackColor = false;
            btnKitapSil.Click += btnKitapSil_Click;
            // 
            // btnKitapKaydet
            // 
            btnKitapKaydet.BackColor = Color.PaleVioletRed;
            btnKitapKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKitapKaydet.Location = new Point(575, 313);
            btnKitapKaydet.Name = "btnKitapKaydet";
            btnKitapKaydet.Size = new Size(94, 29);
            btnKitapKaydet.TabIndex = 9;
            btnKitapKaydet.Text = "EKLE➕";
            btnKitapKaydet.UseVisualStyleBackColor = false;
            btnKitapKaydet.Click += btnKitapKaydet_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.BackColor = Color.Plum;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(278, 201);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 28);
            cmbKategori.TabIndex = 8;
            // 
            // txtYazarSoyadı
            // 
            txtYazarSoyadı.BackColor = Color.Plum;
            txtYazarSoyadı.Location = new Point(278, 155);
            txtYazarSoyadı.Name = "txtYazarSoyadı";
            txtYazarSoyadı.Size = new Size(125, 27);
            txtYazarSoyadı.TabIndex = 6;
            // 
            // txtYazarAdı
            // 
            txtYazarAdı.BackColor = Color.Plum;
            txtYazarAdı.Location = new Point(278, 114);
            txtYazarAdı.Name = "txtYazarAdı";
            txtYazarAdı.Size = new Size(125, 27);
            txtYazarAdı.TabIndex = 5;
            // 
            // txtKitapAdı
            // 
            txtKitapAdı.BackColor = Color.Plum;
            txtKitapAdı.Location = new Point(278, 70);
            txtKitapAdı.Name = "txtKitapAdı";
            txtKitapAdı.Size = new Size(125, 27);
            txtKitapAdı.TabIndex = 4;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.BackColor = Color.Thistle;
            lblKategori.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKategori.Location = new Point(172, 201);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(73, 20);
            lblKategori.TabIndex = 3;
            lblKategori.Text = "Kategori:";
            // 
            // lblYazarSoyadı
            // 
            lblYazarSoyadı.AutoSize = true;
            lblYazarSoyadı.BackColor = Color.Thistle;
            lblYazarSoyadı.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYazarSoyadı.Location = new Point(172, 155);
            lblYazarSoyadı.Name = "lblYazarSoyadı";
            lblYazarSoyadı.Size = new Size(100, 20);
            lblYazarSoyadı.TabIndex = 2;
            lblYazarSoyadı.Text = "Yazar Soyadı:";
            // 
            // lblYazarAdı
            // 
            lblYazarAdı.AutoSize = true;
            lblYazarAdı.BackColor = Color.Thistle;
            lblYazarAdı.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYazarAdı.Location = new Point(172, 117);
            lblYazarAdı.Name = "lblYazarAdı";
            lblYazarAdı.Size = new Size(78, 20);
            lblYazarAdı.TabIndex = 1;
            lblYazarAdı.Text = "Yazar Adı:";
            // 
            // lblKitapAdı
            // 
            lblKitapAdı.AutoSize = true;
            lblKitapAdı.BackColor = Color.Thistle;
            lblKitapAdı.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKitapAdı.Location = new Point(172, 75);
            lblKitapAdı.Name = "lblKitapAdı";
            lblKitapAdı.Size = new Size(78, 20);
            lblKitapAdı.TabIndex = 0;
            lblKitapAdı.Text = "Kitap Adı:";
            // 
            // flpRaflar
            // 
            flpRaflar.AutoScroll = true;
            flpRaflar.Dock = DockStyle.Fill;
            flpRaflar.Location = new Point(0, 0);
            flpRaflar.Name = "flpRaflar";
            flpRaflar.Size = new Size(1248, 703);
            flpRaflar.TabIndex = 5;
            // 
            // pnlEmanetVer
            // 
            pnlEmanetVer.BackColor = SystemColors.ActiveCaption;
            pnlEmanetVer.Controls.Add(cmbKitapID);
            pnlEmanetVer.Controls.Add(cmbUyeID);
            pnlEmanetVer.Controls.Add(btnEmanetIDAl);
            pnlEmanetVer.Controls.Add(lblEmanetID);
            pnlEmanetVer.Controls.Add(txtEmanetID);
            pnlEmanetVer.Controls.Add(dgvEmanetler);
            pnlEmanetVer.Controls.Add(lblTeslimTarihi);
            pnlEmanetVer.Controls.Add(lblKitapID);
            pnlEmanetVer.Controls.Add(lblUyeID);
            pnlEmanetVer.Controls.Add(btnKaydet);
            pnlEmanetVer.Controls.Add(dtpTeslimTarihi);
            pnlEmanetVer.Controls.Add(btnGeriDon4);
            pnlEmanetVer.Dock = DockStyle.Fill;
            pnlEmanetVer.Location = new Point(0, 0);
            pnlEmanetVer.Name = "pnlEmanetVer";
            pnlEmanetVer.Size = new Size(1248, 703);
            pnlEmanetVer.TabIndex = 5;
            pnlEmanetVer.Visible = false;
            // 
            // cmbKitapID
            // 
            cmbKitapID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbKitapID.BackColor = SystemColors.GradientInactiveCaption;
            cmbKitapID.FormattingEnabled = true;
            cmbKitapID.Location = new Point(312, 120);
            cmbKitapID.Name = "cmbKitapID";
            cmbKitapID.Size = new Size(151, 28);
            cmbKitapID.TabIndex = 14;
            // 
            // cmbUyeID
            // 
            cmbUyeID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUyeID.BackColor = SystemColors.GradientInactiveCaption;
            cmbUyeID.FormattingEnabled = true;
            cmbUyeID.Location = new Point(300, 44);
            cmbUyeID.Name = "cmbUyeID";
            cmbUyeID.Size = new Size(151, 28);
            cmbUyeID.TabIndex = 13;
            // 
            // btnEmanetIDAl
            // 
            btnEmanetIDAl.BackColor = Color.Coral;
            btnEmanetIDAl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmanetIDAl.Location = new Point(959, 73);
            btnEmanetIDAl.Name = "btnEmanetIDAl";
            btnEmanetIDAl.Size = new Size(144, 29);
            btnEmanetIDAl.TabIndex = 12;
            btnEmanetIDAl.Text = "Emanet Al^_^";
            btnEmanetIDAl.UseVisualStyleBackColor = false;
            btnEmanetIDAl.Click += btnEmanetIDAl_Click;
            // 
            // lblEmanetID
            // 
            lblEmanetID.AutoSize = true;
            lblEmanetID.BackColor = Color.LightCoral;
            lblEmanetID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmanetID.Location = new Point(792, 45);
            lblEmanetID.Name = "lblEmanetID";
            lblEmanetID.Size = new Size(78, 20);
            lblEmanetID.TabIndex = 11;
            lblEmanetID.Text = "EmanetID";
            // 
            // txtEmanetID
            // 
            txtEmanetID.BackColor = SystemColors.GradientInactiveCaption;
            txtEmanetID.Location = new Point(883, 40);
            txtEmanetID.Name = "txtEmanetID";
            txtEmanetID.Size = new Size(125, 27);
            txtEmanetID.TabIndex = 10;
            // 
            // dgvEmanetler
            // 
            dgvEmanetler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmanetler.BackgroundColor = Color.Lavender;
            dgvEmanetler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmanetler.Location = new Point(226, 279);
            dgvEmanetler.Name = "dgvEmanetler";
            dgvEmanetler.RowHeadersWidth = 51;
            dgvEmanetler.Size = new Size(652, 303);
            dgvEmanetler.TabIndex = 9;
            dgvEmanetler.CellContentClick += dgvEmanetler_CellContentClick;
            // 
            // lblTeslimTarihi
            // 
            lblTeslimTarihi.AutoSize = true;
            lblTeslimTarihi.BackColor = Color.LightCoral;
            lblTeslimTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTeslimTarihi.Location = new Point(226, 175);
            lblTeslimTarihi.Name = "lblTeslimTarihi";
            lblTeslimTarihi.Size = new Size(97, 20);
            lblTeslimTarihi.TabIndex = 8;
            lblTeslimTarihi.Text = "Teslim Tarihi";
            // 
            // lblKitapID
            // 
            lblKitapID.AutoSize = true;
            lblKitapID.BackColor = Color.LightCoral;
            lblKitapID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKitapID.Location = new Point(226, 121);
            lblKitapID.Name = "lblKitapID";
            lblKitapID.Size = new Size(78, 20);
            lblKitapID.TabIndex = 7;
            lblKitapID.Text = "Kitap Adı:";
            // 
            // lblUyeID
            // 
            lblUyeID.AutoSize = true;
            lblUyeID.BackColor = Color.LightCoral;
            lblUyeID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUyeID.Location = new Point(226, 47);
            lblUyeID.Name = "lblUyeID";
            lblUyeID.Size = new Size(68, 20);
            lblUyeID.TabIndex = 6;
            lblUyeID.Text = "Üye Adı:";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Coral;
            btnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKaydet.Location = new Point(523, 227);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(172, 29);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Emanet Ver^_~";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dtpTeslimTarihi
            // 
            dtpTeslimTarihi.Location = new Point(322, 175);
            dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            dtpTeslimTarihi.Size = new Size(250, 27);
            dtpTeslimTarihi.TabIndex = 3;
            // 
            // btnGeriDon4
            // 
            btnGeriDon4.BackColor = Color.SkyBlue;
            btnGeriDon4.Location = new Point(5, 7);
            btnGeriDon4.Name = "btnGeriDon4";
            btnGeriDon4.Size = new Size(94, 29);
            btnGeriDon4.TabIndex = 0;
            btnGeriDon4.Text = "←^_^";
            btnGeriDon4.UseVisualStyleBackColor = false;
            btnGeriDon4.Click += btnGeriDon4_Click;
            // 
            // pnlEmanetAl
            // 
            pnlEmanetAl.BackColor = Color.FromArgb(255, 192, 255);
            pnlEmanetAl.Controls.Add(btnGeriDon3);
            pnlEmanetAl.Dock = DockStyle.Fill;
            pnlEmanetAl.Location = new Point(0, 0);
            pnlEmanetAl.Name = "pnlEmanetAl";
            pnlEmanetAl.Size = new Size(1248, 703);
            pnlEmanetAl.TabIndex = 5;
            pnlEmanetAl.Visible = false;
            // 
            // btnGeriDon3
            // 
            btnGeriDon3.BackColor = Color.FromArgb(255, 192, 192);
            btnGeriDon3.Location = new Point(7, 6);
            btnGeriDon3.Name = "btnGeriDon3";
            btnGeriDon3.Size = new Size(94, 29);
            btnGeriDon3.TabIndex = 0;
            btnGeriDon3.Text = "←ಥ_ಥ";
            btnGeriDon3.UseVisualStyleBackColor = false;
            // 
            // pnlUyeler
            // 
            pnlUyeler.BackColor = Color.FromArgb(192, 255, 192);
            pnlUyeler.Controls.Add(txtSifre);
            pnlUyeler.Controls.Add(txtKullaniciAdi);
            pnlUyeler.Controls.Add(lblSifre);
            pnlUyeler.Controls.Add(lblKullaniciAdi);
            pnlUyeler.Controls.Add(btnGeriDon);
            pnlUyeler.Controls.Add(btnUyeSil);
            pnlUyeler.Controls.Add(btnUyeEkle);
            pnlUyeler.Controls.Add(mtxtUyeTelefon);
            pnlUyeler.Controls.Add(txtUyeEposta);
            pnlUyeler.Controls.Add(lblUyeTelefon);
            pnlUyeler.Controls.Add(lblUyeEposta);
            pnlUyeler.Controls.Add(lblUyeSoyad);
            pnlUyeler.Controls.Add(lblUyeAd);
            pnlUyeler.Controls.Add(txtUyeSoyad);
            pnlUyeler.Controls.Add(txtUyeAd);
            pnlUyeler.Controls.Add(dgvUyeler);
            pnlUyeler.Dock = DockStyle.Fill;
            pnlUyeler.Location = new Point(0, 0);
            pnlUyeler.Name = "pnlUyeler";
            pnlUyeler.Size = new Size(1248, 703);
            pnlUyeler.TabIndex = 5;
            pnlUyeler.Visible = false;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(1057, 292);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 15;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(1057, 244);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 14;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.YellowGreen;
            lblSifre.BorderStyle = BorderStyle.FixedSingle;
            lblSifre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSifre.Location = new Point(932, 288);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(54, 22);
            lblSifre.TabIndex = 13;
            lblSifre.Text = "ŞİFRE:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = Color.YellowGreen;
            lblKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            lblKullaniciAdi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKullaniciAdi.Location = new Point(931, 247);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(125, 22);
            lblKullaniciAdi.TabIndex = 12;
            lblKullaniciAdi.Text = "KULLANICI ADI:";
            lblKullaniciAdi.Click += label1_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.NavajoWhite;
            btnGeriDon.Location = new Point(7, 9);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(88, 31);
            btnGeriDon.TabIndex = 0;
            btnGeriDon.Text = "←(●'◡'●)";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // btnUyeSil
            // 
            btnUyeSil.BackColor = Color.Khaki;
            btnUyeSil.Location = new Point(1123, 352);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(94, 29);
            btnUyeSil.TabIndex = 11;
            btnUyeSil.Text = "Sil:P";
            btnUyeSil.UseVisualStyleBackColor = false;
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.BackColor = Color.Khaki;
            btnUyeEkle.Location = new Point(1009, 352);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(94, 29);
            btnUyeEkle.TabIndex = 10;
            btnUyeEkle.Text = "Kaydet*_*";
            btnUyeEkle.UseVisualStyleBackColor = false;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // mtxtUyeTelefon
            // 
            mtxtUyeTelefon.Location = new Point(1057, 201);
            mtxtUyeTelefon.Name = "mtxtUyeTelefon";
            mtxtUyeTelefon.Size = new Size(125, 27);
            mtxtUyeTelefon.TabIndex = 9;
            // 
            // txtUyeEposta
            // 
            txtUyeEposta.Location = new Point(1057, 158);
            txtUyeEposta.Name = "txtUyeEposta";
            txtUyeEposta.Size = new Size(125, 27);
            txtUyeEposta.TabIndex = 8;
            // 
            // lblUyeTelefon
            // 
            lblUyeTelefon.AutoSize = true;
            lblUyeTelefon.BackColor = Color.YellowGreen;
            lblUyeTelefon.BorderStyle = BorderStyle.FixedSingle;
            lblUyeTelefon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUyeTelefon.Location = new Point(931, 201);
            lblUyeTelefon.Name = "lblUyeTelefon";
            lblUyeTelefon.Size = new Size(79, 22);
            lblUyeTelefon.TabIndex = 7;
            lblUyeTelefon.Text = "TELEFON;";
            // 
            // lblUyeEposta
            // 
            lblUyeEposta.AutoSize = true;
            lblUyeEposta.BackColor = Color.YellowGreen;
            lblUyeEposta.BorderStyle = BorderStyle.FixedSingle;
            lblUyeEposta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUyeEposta.Location = new Point(931, 158);
            lblUyeEposta.Name = "lblUyeEposta";
            lblUyeEposta.Size = new Size(64, 22);
            lblUyeEposta.TabIndex = 6;
            lblUyeEposta.Text = "GMAİL;";
            // 
            // lblUyeSoyad
            // 
            lblUyeSoyad.AutoSize = true;
            lblUyeSoyad.BackColor = Color.YellowGreen;
            lblUyeSoyad.BorderStyle = BorderStyle.FixedSingle;
            lblUyeSoyad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUyeSoyad.Location = new Point(931, 120);
            lblUyeSoyad.Name = "lblUyeSoyad";
            lblUyeSoyad.Size = new Size(69, 22);
            lblUyeSoyad.TabIndex = 5;
            lblUyeSoyad.Text = "SOYADI:";
            // 
            // lblUyeAd
            // 
            lblUyeAd.AutoSize = true;
            lblUyeAd.BackColor = Color.YellowGreen;
            lblUyeAd.BorderStyle = BorderStyle.FixedSingle;
            lblUyeAd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUyeAd.Location = new Point(931, 74);
            lblUyeAd.Name = "lblUyeAd";
            lblUyeAd.Size = new Size(42, 22);
            lblUyeAd.TabIndex = 4;
            lblUyeAd.Text = "ADI:";
            // 
            // txtUyeSoyad
            // 
            txtUyeSoyad.Location = new Point(1057, 110);
            txtUyeSoyad.Name = "txtUyeSoyad";
            txtUyeSoyad.Size = new Size(125, 27);
            txtUyeSoyad.TabIndex = 3;
            // 
            // txtUyeAd
            // 
            txtUyeAd.Location = new Point(1057, 67);
            txtUyeAd.Name = "txtUyeAd";
            txtUyeAd.Size = new Size(125, 27);
            txtUyeAd.TabIndex = 2;
            // 
            // dgvUyeler
            // 
            dgvUyeler.BackgroundColor = Color.DarkOliveGreen;
            dgvUyeler.BorderStyle = BorderStyle.Fixed3D;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.GridColor = Color.LightPink;
            dgvUyeler.Location = new Point(12, 47);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.Size = new Size(807, 633);
            dgvUyeler.TabIndex = 1;
            // 
            // pnlKitapAra
            // 
            pnlKitapAra.BackColor = Color.LemonChiffon;
            pnlKitapAra.Controls.Add(button1);
            pnlKitapAra.Controls.Add(dgvKitaplar);
            pnlKitapAra.Controls.Add(btnAra);
            pnlKitapAra.Controls.Add(txtKitapAra);
            pnlKitapAra.Dock = DockStyle.Fill;
            pnlKitapAra.Location = new Point(0, 0);
            pnlKitapAra.Name = "pnlKitapAra";
            pnlKitapAra.Size = new Size(1248, 703);
            pnlKitapAra.TabIndex = 5;
            pnlKitapAra.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(11, 15);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "←^_~";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.BackgroundColor = Color.PaleGoldenrod;
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(142, 67);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.Size = new Size(952, 219);
            dgvKitaplar.TabIndex = 4;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.Gold;
            btnAra.Location = new Point(750, 9);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 3;
            btnAra.Text = "🔍";
            btnAra.UseVisualStyleBackColor = false;
            // 
            // txtKitapAra
            // 
            txtKitapAra.BackColor = Color.PapayaWhip;
            txtKitapAra.Location = new Point(167, 9);
            txtKitapAra.Name = "txtKitapAra";
            txtKitapAra.Size = new Size(577, 27);
            txtKitapAra.TabIndex = 1;
            txtKitapAra.TextChanged += txtKitapAra_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1248, 703);
            Controls.Add(pnlAnaGiris);
            Controls.Add(pnlKitapYonetim);
            Controls.Add(pnlUyeler);
            Controls.Add(pnlEmanetAl);
            Controls.Add(pnlKitapAra);
            Controls.Add(pnlEmanetVer);
            Controls.Add(flpRaflar);
            Name = "Form1";
            pnlAnaGiris.ResumeLayout(false);
            pnlKitapYonetim.ResumeLayout(false);
            pnlKitapYonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitapListesi).EndInit();
            pnlEmanetVer.ResumeLayout(false);
            pnlEmanetVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetler).EndInit();
            pnlEmanetAl.ResumeLayout(false);
            pnlUyeler.ResumeLayout(false);
            pnlUyeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            pnlKitapAra.ResumeLayout(false);
            pnlKitapAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAnaGiris;
        private Button btnEmanetAl;
        private Button btnKitapEkleSil;
        private Button btnKutuphane;
        private Button btnUyeler;
        private Button btnArama;
        private Panel pnlEmanetVer;
        private Panel pnlUyeler;
        private Panel pnlEmanetAl;
        private Panel pnlKitapAra;
        private Button btnGeriDon;
        private Button btnGeriDon4;
        private Button btnGeriDon3;
        private FlowLayoutPanel flpRaflar;
        private Button btnKaydet;
        private DateTimePicker dtpTeslimTarihi;
        private Label lblKitapID;
        private Label lblUyeID;
        private Label lblTeslimTarihi;
        private Button btnEmanetIDAl;
        private Label lblEmanetID;
        private TextBox txtEmanetID;
        private DataGridView dgvEmanetler;
        private ComboBox cmbKitapID;
        private ComboBox cmbUyeID;
        private TextBox txtUyeSoyad;
        private TextBox txtUyeAd;
        private DataGridView dgvUyeler;
        private Button btnUyeSil;
        private Button btnUyeEkle;
        private MaskedTextBox mtxtUyeTelefon;
        private TextBox txtUyeEposta;
        private Label lblUyeTelefon;
        private Label lblUyeEposta;
        private Label lblUyeSoyad;
        private Label lblUyeAd;
        private DataGridView dgvKitaplar;
        private Button btnAra;
        private TextBox txtKitapAra;
        private Button button1;
        private Panel pnlKitapYonetim;
        private TextBox txtYazarSoyadı;
        private TextBox txtYazarAdı;
        private TextBox txtKitapAdı;
        private Label lblKategori;
        private Label lblYazarSoyadı;
        private Label lblYazarAdı;
        private Label lblKitapAdı;
        private ComboBox cmbKategori;
        private Button btnKitapSil;
        private Button btnKitapKaydet;
        private Button btnGeriDonKitap;
        private DataGridView dgvKitapListesi;
        private Label lblSayfaSayisi;
        private TextBox txtSayfaSayisi;
        private Label lblYayinevi;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Button btnKullaniciEkranDon;
        private Label lblYayineviEmail;
        private TextBox txtPublisherEmail;
        private TextBox txtPublisherName;
    }
}
