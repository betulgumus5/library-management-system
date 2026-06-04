using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementorj
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-B92PVUGE\\SQLEXPRESS;Initial Catalog=MyLibraryDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            flpRaflar.Dock = DockStyle.Fill;
            ComboBoxDoldur();
            PanelGetir(pnlAnaGiris);
            KitaplariListele();
        }

        void KitaplariListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                baglanti.Open();

                string sorgu = @"SELECT 
                            B.BookID, 
                            B.BookName, 
                            (A.FirstName + ' ' + A.LastName) AS Yazar, 
                            C.CategoryName AS Kategori
                         FROM Books B 
                         INNER JOIN Authors A ON B.AuthorID = A.AuthorID 
                         INNER JOIN Categories C ON B.CategoryID = C.CategoryID";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitapListesi.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        // --- KÜTÜPHANE RAFLARI ---
        void KategorileriOlustur()
        {
            try
            {
                flpRaflar.Controls.Clear();
                Button btnAnaGirisDon = new Button();
                btnAnaGirisDon.Text = "🏠 ANA MENÜYE DÖN";
                btnAnaGirisDon.Size = new Size(160, 45);
                btnAnaGirisDon.BackColor = Color.HotPink;
                btnAnaGirisDon.ForeColor = Color.White;
                btnAnaGirisDon.FlatStyle = FlatStyle.Flat;
                btnAnaGirisDon.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnAnaGirisDon.Margin = new Padding(20, 10, 20, 20);
                btnAnaGirisDon.Click += (s, e) => { PanelGetir(pnlAnaGiris); };
                flpRaflar.Controls.Add(btnAnaGirisDon);
                flpRaflar.SetFlowBreak(btnAnaGirisDon, true);

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT CategoryName FROM Categories", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    string katAdi = dr["CategoryName"].ToString();
                    Button btnRaf = new Button();
                    btnRaf.Text = katAdi;
                    btnRaf.Width = flpRaflar.ClientSize.Width - 40;
                    btnRaf.Height = 100;
                    btnRaf.BackColor = Color.LightPink;
                    btnRaf.ForeColor = Color.DeepPink;
                    btnRaf.FlatStyle = FlatStyle.Flat;
                    btnRaf.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    btnRaf.Margin = new Padding(20, 10, 20, 10);
                    btnRaf.Click += (s, e) => { KitaplariGetir(katAdi); };
                    flpRaflar.Controls.Add(btnRaf);
                }
                dr.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Kategoriler yüklenirken hata: " + ex.Message);
            }
        }

        void KitaplariGetir(string kategoriAdi)
        {
            try
            {
                flpRaflar.Controls.Clear();

                Button btnGeri = new Button();
                btnGeri.Text = "⬅️ RAFLARA DÖN";
                btnGeri.Size = new Size(160, 45);
                btnGeri.BackColor = Color.HotPink;
                btnGeri.ForeColor = Color.White;
                btnGeri.FlatStyle = FlatStyle.Flat;
                btnGeri.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnGeri.Margin = new Padding(20, 10, 20, 20);
                btnGeri.Click += (s, e) => { KategorileriOlustur(); };

                flpRaflar.Controls.Add(btnGeri);
                flpRaflar.SetFlowBreak(btnGeri, true);

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // SQL Sorgusuna Yayınevi (P.PublisherName) ve Sayfa Sayısı (B.PageCount) eklendi
                string sorgu = @"SELECT 
                            B.BookName, 
                            (A.FirstName + ' ' + A.LastName) AS YazarTamAd, 
                            P.PublisherName,
                            B.PageCount,
                            B.Status 
                         FROM Books B 
                         INNER JOIN Authors A ON B.AuthorID = A.AuthorID 
                         INNER JOIN Categories C ON B.CategoryID = C.CategoryID 
                         INNER JOIN Publishers P ON B.PublisherID = P.PublisherID 
                         WHERE C.CategoryName = @p1";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", kategoriAdi);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Button btnKitap = new Button();
                    btnKitap.Size = new Size(180, 220); // Bilgiler arttığı için boyutu biraz büyüttük

                    string kitapAdi = dr["BookName"].ToString();
                    string yazarAdi = dr["YazarTamAd"].ToString();
                    string yayinevi = dr["PublisherName"].ToString();
                    string sayfa = dr["PageCount"].ToString();

                    // Buton metnine Yayınevi ve Sayfa Sayısı eklendi
                    btnKitap.Text = $"{kitapAdi}\n\n👤 {yazarAdi}\n🏢 {yayinevi}\n📄 {sayfa} Sayfa";

                    // Duruma göre renk ayarı (Mevcut kodun)
                    btnKitap.BackColor = dr["Status"].ToString() == "1" ? Color.LightGreen : Color.MistyRose;
                    btnKitap.FlatStyle = FlatStyle.Popup;
                    btnKitap.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    btnKitap.Margin = new Padding(10);

                    flpRaflar.Controls.Add(btnKitap);
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            finally { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        void ComboBoxDoldur()
        {
            try
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                baglanti.Open();


                SqlDataAdapter daUye = new SqlDataAdapter("SELECT MemberID, (FirstName + ' ' + LastName) AS AdSoyad FROM Members", baglanti);
                DataTable dtUye = new DataTable();
                daUye.Fill(dtUye);
                cmbUyeID.DataSource = dtUye;
                cmbUyeID.DisplayMember = "AdSoyad";
                cmbUyeID.ValueMember = "MemberID";


                SqlDataAdapter daKitap = new SqlDataAdapter("SELECT BookID, BookName FROM Books WHERE Status = 1", baglanti);
                DataTable dtKitap = new DataTable();
                daKitap.Fill(dtKitap);
                cmbKitapID.DataSource = dtKitap;
                cmbKitapID.DisplayMember = "BookName";
                cmbKitapID.ValueMember = "BookID";


                SqlDataAdapter daKat = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Categories", baglanti);
                DataTable dtKat = new DataTable();
                daKat.Fill(dtKat);
                cmbKategori.DataSource = dtKat;
                cmbKategori.DisplayMember = "CategoryName";
                cmbKategori.ValueMember = "CategoryID";


                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtYazarAdı.Text) || string.IsNullOrWhiteSpace(txtYazarSoyadı.Text) || string.IsNullOrWhiteSpace(txtKitapAdı.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }

                baglanti.Open();


                SqlCommand yazarKontrol = new SqlCommand(
                    "SELECT AuthorID FROM Authors WHERE FirstName = @aName AND LastName = @aSurname", baglanti);
                yazarKontrol.Parameters.AddWithValue("@aName", txtYazarAdı.Text.Trim());
                yazarKontrol.Parameters.AddWithValue("@aSurname", txtYazarSoyadı.Text.Trim());
                object result = yazarKontrol.ExecuteScalar();

                int yazarID;
                if (result != null)
                {
                    yazarID = (int)result;
                }
                else
                {

                    SqlCommand yazarEkle = new SqlCommand(
                        "INSERT INTO Authors (FirstName, LastName) OUTPUT INSERTED.AuthorID VALUES (@aName, @aSurname)", baglanti);
                    yazarEkle.Parameters.AddWithValue("@aName", txtYazarAdı.Text.Trim());
                    yazarEkle.Parameters.AddWithValue("@aSurname", txtYazarSoyadı.Text.Trim());
                    yazarID = (int)yazarEkle.ExecuteScalar();
                }
                SqlCommand pubKontrol = new SqlCommand(
            "SELECT PublisherID FROM Publishers WHERE PublisherName = @pName", baglanti);
                pubKontrol.Parameters.AddWithValue("@pName", txtPublisherName.Text.Trim());
                object pResult = pubKontrol.ExecuteScalar();

                int yayineviID;
                if (pResult != null)
                {
                    yayineviID = (int)pResult;
                }
                else
                {
                    // Veritabanı fotonda gördüğümüz 'Email' sütununu buraya ekledik
                    SqlCommand pubEkle = new SqlCommand(
                        "INSERT INTO Publishers (PublisherName, Email) OUTPUT INSERTED.PublisherID VALUES (@pName, @pEmail)", baglanti);
                    pubEkle.Parameters.AddWithValue("@pName", txtPublisherName.Text.Trim());
                    pubEkle.Parameters.AddWithValue("@pEmail", txtPublisherEmail.Text.Trim());
                    yayineviID = (int)pubEkle.ExecuteScalar();
                }

                int sayfaSayisi = 0;
                if (int.TryParse(txtSayfaSayisi.Text, out int sayfaTemp)) sayfaSayisi = sayfaTemp;


                SqlCommand kitapEkle = new SqlCommand(
@"INSERT INTO Books 
(BookName, AuthorID, CategoryID, PublisherID, PageCount, PublishDate, Status) 
VALUES (@p1, @p2, @p3, @p4, @p5, @p6, 1)", baglanti);

                kitapEkle.Parameters.AddWithValue("@p1", txtKitapAdı.Text.Trim());
                kitapEkle.Parameters.AddWithValue("@p2", yazarID);
                kitapEkle.Parameters.AddWithValue("@p3", cmbKategori.SelectedValue);
                kitapEkle.Parameters.AddWithValue("@p4", yayineviID);
                kitapEkle.Parameters.AddWithValue("@p5", sayfaSayisi);
                kitapEkle.Parameters.AddWithValue("@p6", DateTime.Now); // ya da dtpYayinTarihi

                kitapEkle.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kitap başarıyla kaydedildi! ✅");
                KitaplariListele();
                ComboBoxDoldur();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- DİĞER METOTLAR ---
        void UyeListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Members", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUyeler.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Üye listeleme hatası: " + ex.Message);
            }
        }

        void EmanetListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                baglanti.Open();
                string sorgu = @"SELECT L.LoanID, 
                        M.FirstName + ' ' + M.LastName AS [Üye], 
                        B.BookName AS [Kitap], 
                        L.LoanDate AS [Veriliş], 
                        L.ReturnDate AS [Teslim]
                 FROM Loans L 
                 JOIN Members M ON L.MemberID = M.MemberID 
                 JOIN Books B ON L.BookID = B.BookID
                 WHERE L.Status = 0";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmanetler.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Emanet listeleme hatası: " + ex.Message);
            }
        }

        private void PanelGetir(Panel aktifPanel)
        {
            pnlAnaGiris.Visible = pnlKitapAra.Visible = pnlEmanetVer.Visible = pnlUyeler.Visible = pnlKitapYonetim.Visible = false;
            if (flpRaflar != null) flpRaflar.Visible = false;
            aktifPanel.Visible = true;
            aktifPanel.Dock = DockStyle.Fill;
            aktifPanel.BringToFront();
        }

        // Buton tıklamaları
        private void btnArama_Click_1(object sender, EventArgs e) { PanelGetir(pnlKitapAra); KitaplariHepsiniListele(); }
        private void btnUyeler_Click_1(object sender, EventArgs e) { PanelGetir(pnlUyeler); UyeListele(); }
        private void btnKutuphane_Click(object sender, EventArgs e)
        {



            KategorileriOlustur();

            flpRaflar.Dock = DockStyle.Fill;
            flpRaflar.Visible = true;
            flpRaflar.BringToFront();
        }
        private void btnKitapEkleSil_Click(object sender, EventArgs e) { PanelGetir(pnlKitapYonetim); ComboBoxDoldur(); KitaplariListele(); }
        private void btnEmanetAl_Click(object sender, EventArgs e) { PanelGetir(pnlEmanetVer); EmanetListele(); ComboBoxDoldur(); }
        private void btnGeriDon_Click(object sender, EventArgs e) => PanelGetir(pnlAnaGiris);
        private void btnGeriDon2_Click(object sender, EventArgs e) => PanelGetir(pnlAnaGiris);
        private void btnGeriDonKitap_Click(object sender, EventArgs e) => PanelGetir(pnlAnaGiris);


        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKitapListesi.CurrentRow == null) return;
                int id = Convert.ToInt32(dgvKitapListesi.CurrentRow.Cells["BookID"].Value);
                baglanti.Open();
                SqlCommand sil = new SqlCommand("DELETE FROM Books WHERE BookID = @id", baglanti);
                sil.Parameters.AddWithValue("@id", id);
                sil.ExecuteNonQuery();
                baglanti.Close();
                KitaplariListele();
                MessageBox.Show("Kitap silindi! 🗑️");
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        void KitaplariHepsiniListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = @"SELECT 
                            B.BookID, 
                            B.BookName, 
                            (A.FirstName + ' ' + A.LastName) AS Yazar, 
                            C.CategoryName AS Kategori 
                         FROM Books B
                         INNER JOIN Authors A ON B.AuthorID = A.AuthorID
                         INNER JOIN Categories C ON B.CategoryID = C.CategoryID";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Arama listesi hatası: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGeriDon4_Click(object sender, EventArgs e) => PanelGetir(pnlAnaGiris);

        private void button1_Click(object sender, EventArgs e) => PanelGetir(pnlAnaGiris);

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = @"SELECT 
                            B.BookID, 
                            B.BookName, 
                            (A.FirstName + ' ' + A.LastName) AS Yazar, 
                            C.CategoryName AS Kategori
                         FROM Books B
                         INNER JOIN Authors A ON B.AuthorID = A.AuthorID
                         INNER JOIN Categories C ON B.CategoryID = C.CategoryID
                         WHERE B.BookName LIKE @p1 
                            OR A.FirstName LIKE @p1 
                            OR A.LastName LIKE @p1";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", "%" + txtKitapAra.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKitaplar.DataSource = dt;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("Arama hatası: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUyeID.SelectedValue == null || cmbKitapID.SelectedValue == null)
                {
                    MessageBox.Show("Üye ve kitap seçiniz!");
                    return;
                }

                baglanti.Open();


                SqlCommand ekle = new SqlCommand(
                @"INSERT INTO Loans (BookID, MemberID, LoanDate, ReturnDate, Status) 
          VALUES (@b, @m, @loan, @return, 0)", baglanti);

                ekle.Parameters.AddWithValue("@b", cmbKitapID.SelectedValue);
                ekle.Parameters.AddWithValue("@m", cmbUyeID.SelectedValue);
                ekle.Parameters.AddWithValue("@loan", DateTime.Now);
                ekle.Parameters.AddWithValue("@return", DateTime.Now.AddDays(7)); // 7 gün sonra

                ekle.ExecuteNonQuery();

                SqlCommand guncelle = new SqlCommand(
                    "UPDATE Books SET Status = 0 WHERE BookID = @id", baglanti);

                guncelle.Parameters.AddWithValue("@id", cmbKitapID.SelectedValue);
                guncelle.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Kitap ödünç verildi 📚");

                ComboBoxDoldur();
                EmanetListele();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void btnEmanetIDAl_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtEmanetID.Text))
                {
                    MessageBox.Show("Emanet ID gir!");
                    return;
                }

                int loanID = Convert.ToInt32(txtEmanetID.Text);

                baglanti.Open();

                // 1. Hangi kitap olduğunu bul
                SqlCommand bul = new SqlCommand(
                    "SELECT BookID FROM Loans WHERE LoanID = @id", baglanti);

                bul.Parameters.AddWithValue("@id", loanID);

                object kitapID = bul.ExecuteScalar();

                if (kitapID == null)
                {
                    MessageBox.Show("Emanet bulunamadı!");
                    baglanti.Close();
                    return;
                }

                // 2. Loan'ı kapat
                SqlCommand guncelleLoan = new SqlCommand(
                    "UPDATE Loans SET Status = 1 WHERE LoanID = @id", baglanti);

                guncelleLoan.Parameters.AddWithValue("@id", loanID);
                guncelleLoan.ExecuteNonQuery();

                // 3. Kitabı müsait yap
                SqlCommand guncelleKitap = new SqlCommand(
                    "UPDATE Books SET Status = 1 WHERE BookID = @bid", baglanti);

                guncelleKitap.Parameters.AddWithValue("@bid", kitapID);
                guncelleKitap.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Kitap geri alındı ✅");

                ComboBoxDoldur();
                EmanetListele();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
            EmanetListele();
        }

        private void dgvEmanetler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUyeAd.Text) ||
                    string.IsNullOrWhiteSpace(txtUyeSoyad.Text) ||
                    string.IsNullOrWhiteSpace(txtUyeEposta.Text) ||
                    string.IsNullOrWhiteSpace(mtxtUyeTelefon.Text) ||
                    string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                    string.IsNullOrWhiteSpace(txtSifre.Text))
                {
                    MessageBox.Show("Tüm alanları doldur!");
                    return;
                }

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand(
                @"INSERT INTO Members 
        (FirstName, LastName, Email, PhoneNumber, JoinDate, KullaniciAdi, Sifre) 
        VALUES 
        (@ad, @soyad, @mail, @tel, @tarih, @kuladi, @sifre)", baglanti);

                komut.Parameters.AddWithValue("@ad", txtUyeAd.Text.Trim());
                komut.Parameters.AddWithValue("@soyad", txtUyeSoyad.Text.Trim());
                komut.Parameters.AddWithValue("@mail", txtUyeEposta.Text.Trim());
                komut.Parameters.AddWithValue("@tel", mtxtUyeTelefon.Text.Trim());
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);

                // ✔ YENİ EKLENENLER
                komut.Parameters.AddWithValue("@kuladi", txtKullaniciAdi.Text.Trim());
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());

                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Üye eklendi ✅");

                UyeListele();
                ComboBoxDoldur();

                txtUyeAd.Clear();
                txtUyeSoyad.Clear();
                txtUyeEposta.Clear();
                mtxtUyeTelefon.Clear();
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvUyeler.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek üyeyi seç!");
                    return;
                }

                int id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["MemberID"].Value);

                DialogResult cevap = MessageBox.Show("Bu üyeyi silmek istediğine emin misin?",
                                                     "Uyarı",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (cevap != DialogResult.Yes) return;

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand sil = new SqlCommand("DELETE FROM Members WHERE MemberID = @id", baglanti);
                sil.Parameters.AddWithValue("@id", id);
                sil.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Üye silindi 🗑️");

                UyeListele();
                ComboBoxDoldur();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKullaniciEkranDon_Click(object sender, EventArgs e)
        {
       
            this.Close();

          
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is LoginForm login)
                {
                    login.Show(); 
                    login.GirisEkraniniGoster();
                    break;
                }
            }
        }
    }
    




}

  
        
        
            

         
