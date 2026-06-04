using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementorj
{
    public partial class LoginForm : Form
    {
        SqlConnection baglanti = new SqlConnection(
            "Data Source=LAPTOP-B92PVUGE\\SQLEXPRESS;Initial Catalog=MyLibraryDB;Integrated Security=True"
        );

        public LoginForm()
        {
            InitializeComponent();


        }




        private void LoginForm_Load(object sender, EventArgs e)
        {
            pnlGiris.Visible = true;
            pnlUyeDunyasi.Visible = false;
            pnlKutuphanem.Visible = false;
        }

        // ================= LOGIN =================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // ================= ADMIN =================
                SqlCommand adminKomut = new SqlCommand(
                    "SELECT AdminID FROM Admins WHERE AdminKullaniciAdi=@p1 AND AdminSifre=@p2",
                    baglanti
                );

                adminKomut.Parameters.AddWithValue("@p1", user);
                adminKomut.Parameters.AddWithValue("@p2", pass);

                object adminResult = adminKomut.ExecuteScalar();

                if (adminResult != null)
                {
                    Form1 adminPanel = new Form1();
                    adminPanel.Show();
                    this.Hide();
                    return;
                }

                // ================= MEMBER =================
                SqlCommand uyeKomut = new SqlCommand(
                    "SELECT MemberID FROM Members WHERE KullaniciAdi=@p1 AND Sifre=@p2",
                    baglanti
                );

                uyeKomut.Parameters.AddWithValue("@p1", user);
                uyeKomut.Parameters.AddWithValue("@p2", pass);

                object result = uyeKomut.ExecuteScalar();
                if (result != null)
                {
                    string girisYapanID = result.ToString();
                    MessageBox.Show("Giriş başarılı");

                    // Sadece panel geçişi yap
                    pnlGiris.Visible = false;
                    pnlKutuphanem.Visible = false;
                    pnlUyeDunyasi.Visible = true;
                    pnlUyeDunyasi.BringToFront();

                    // Tasarımda görünmesi gereken kontroller
                    btnGiriseDon.Visible = true;
                    btnKutuphaneyeGit.Visible = true;
                    dgvEmanetlerim.Visible = true;

                    // Verileri yükle
                    EmanetListele(girisYapanID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        void KategorileriOlustur()
        {
            try
            {
                flpRaflar.Controls.Clear();

                // ================= GERİ BUTONU =================
                Button btnGeriMenu = new Button();
                btnGeriMenu.Text = "🏠 GİRİŞE DÖN";
                btnGeriMenu.Size = new Size(160, 45);
                btnGeriMenu.BackColor = Color.DarkRed;
                btnGeriMenu.ForeColor = Color.White;
                btnGeriMenu.FlatStyle = FlatStyle.Flat;
                btnGeriMenu.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnGeriMenu.Margin = new Padding(20, 10, 20, 20);

                btnGeriMenu.Click += (s, e) =>
                {
                    pnlKutuphanem.Visible = false;
                    pnlUyeDunyasi.Visible = true;
                    pnlUyeDunyasi.BringToFront();
                };

                flpRaflar.Controls.Add(btnGeriMenu);
                flpRaflar.SetFlowBreak(btnGeriMenu, true);

                // ================= SQL =================
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand("SELECT CategoryName FROM Categories", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    string katAdi = dr["CategoryName"].ToString();

                    Button btnRaf = new Button();
                    btnRaf.Text = katAdi;
                    btnRaf.Width = flpRaflar.ClientSize.Width - 200;
                    btnRaf.Height = 80;
                    btnRaf.BackColor = Color.LightPink;
                    btnRaf.ForeColor = Color.DeepPink;
                    btnRaf.FlatStyle = FlatStyle.Flat;
                    btnRaf.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    btnRaf.Margin = new Padding(20, 10, 20, 10);

                    btnRaf.Click += (s, e) => KitaplariGetir(katAdi);

                    flpRaflar.Controls.Add(btnRaf);
                }

                dr.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("Kategoriler yüklenirken hata: " + ex.Message);
            }
        }
        void KitaplariGetir(string kategoriAdi)
        {
            try
            {
                flpRaflar.Controls.Clear();
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

                string sorgu = @"SELECT 
                            B.BookName, 
                            (A.FirstName + ' ' + A.LastName) AS YazarTamAd, 
                            B.Status 
                         FROM Books B 
                         INNER JOIN Authors A ON B.AuthorID = A.AuthorID
                         INNER JOIN Categories C ON B.CategoryID = C.CategoryID
                         WHERE C.CategoryName = @p1";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", kategoriAdi);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Button btnKitap = new Button();
                    btnKitap.Size = new Size(150, 200);

                    string kitapAdi = dr["BookName"].ToString();
                    string yazarAdi = dr["YazarTamAd"].ToString();

                    btnKitap.Text = kitapAdi + "\n\n👤 " + yazarAdi;


                    btnKitap.BackColor = dr["Status"].ToString() == "1" ? Color.LightGreen : Color.MistyRose;
                    btnKitap.FlatStyle = FlatStyle.Popup;
                    btnKitap.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                    flpRaflar.Controls.Add(btnKitap);
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            finally { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        // ================= EMANET LİSTE =================
        void EmanetListele(string uyeID)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string sorgu =
                @"SELECT 
            B.BookName AS 'Kitap Adı',
            C.CategoryName AS 'Kategori',
            (A.FirstName + ' ' + A.LastName) AS 'Yazar',
            B.PageCount AS 'Sayfa Sayısı',
            T.LoanDate AS 'Alış Tarihi'
          FROM Loans T
          INNER JOIN Books B ON T.BookID = B.BookID
          INNER JOIN Categories C ON B.CategoryID = C.CategoryID
          INNER JOIN Authors A ON B.AuthorID = A.AuthorID
          WHERE T.MemberID = @p1";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@p1", uyeID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmanetlerim.DataSource = dt;

                // GRID AYARLARI
                dgvEmanetlerim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEmanetlerim.ReadOnly = true;
                dgvEmanetlerim.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnKutuphaneyeGit_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = false;
            pnlUyeDunyasi.Visible = false;

            pnlKutuphanem.Visible = true;
            pnlKutuphanem.BringToFront();
            pnlKutuphanem.Dock = DockStyle.Fill;

            KategorileriOlustur();
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmanetlerim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGiriseDon_Click(object sender, EventArgs e)
        {

            // Kütüphane panelini gizle
            pnlKutuphanem.Visible = false;

            // Giriş panelini (pnlGiris) görünür yap ve öne getir
            pnlGiris.Visible = true;
            pnlGiris.BringToFront();
        }
        public void GirisEkraniniGoster()
        {
            // Giriş panelini göster, diğerlerini gizle
            pnlGiris.Visible = true;
            pnlUyeDunyasi.Visible = false;
            pnlKutuphanem.Visible = false;

            // Paneli en öne getir
            pnlGiris.BringToFront();

            // Eğer formu gizlediysen (Hide), tekrar göster
            this.Show();
        }
    }

}