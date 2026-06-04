namespace LibraryManagementorj
{
    partial class LoginForm
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            pnlGiris = new Panel();
            pnlUyeDunyasi = new Panel();
            btnKutuphaneyeGit = new Button();
            btnGiriseDon = new Button();
            dgvEmanetlerim = new DataGridView();
            flpRaflar = new FlowLayoutPanel();
            pnlKutuphanem = new Panel();
            pnlGiris.SuspendLayout();
            pnlUyeDunyasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetlerim).BeginInit();
            pnlKutuphanem.SuspendLayout();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUser.BackColor = Color.MistyRose;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Location = new Point(341, 410);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(195, 20);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPass.BackColor = Color.MistyRose;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Location = new Point(341, 461);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(195, 20);
            txtPass.TabIndex = 1;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.LightPink;
            btnLogin.Location = new Point(500, 357);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(83, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlGiris
            // 
            pnlGiris.BackgroundImage = Properties.Resources.gırısyapekranı;
            pnlGiris.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGiris.Controls.Add(txtPass);
            pnlGiris.Controls.Add(btnLogin);
            pnlGiris.Controls.Add(txtUser);
            pnlGiris.Dock = DockStyle.Fill;
            pnlGiris.Location = new Point(0, 0);
            pnlGiris.Name = "pnlGiris";
            pnlGiris.Size = new Size(875, 727);
            pnlGiris.TabIndex = 3;
            // 
            // pnlUyeDunyasi
            // 
            pnlUyeDunyasi.BackColor = Color.Transparent;
            pnlUyeDunyasi.BackgroundImage = Properties.Resources.libraryback;
            pnlUyeDunyasi.BackgroundImageLayout = ImageLayout.Stretch;
            pnlUyeDunyasi.Controls.Add(btnKutuphaneyeGit);
            pnlUyeDunyasi.Controls.Add(btnGiriseDon);
            pnlUyeDunyasi.Controls.Add(dgvEmanetlerim);
            pnlUyeDunyasi.Dock = DockStyle.Fill;
            pnlUyeDunyasi.Location = new Point(0, 0);
            pnlUyeDunyasi.Name = "pnlUyeDunyasi";
            pnlUyeDunyasi.Size = new Size(875, 727);
            pnlUyeDunyasi.TabIndex = 3;
            pnlUyeDunyasi.Visible = false;
            // 
            // btnKutuphaneyeGit
            // 
            btnKutuphaneyeGit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKutuphaneyeGit.ForeColor = Color.LightCoral;
            btnKutuphaneyeGit.Location = new Point(693, 12);
            btnKutuphaneyeGit.Name = "btnKutuphaneyeGit";
            btnKutuphaneyeGit.Size = new Size(154, 29);
            btnKutuphaneyeGit.TabIndex = 1;
            btnKutuphaneyeGit.Text = "Kütüphaneme Git→";
            btnKutuphaneyeGit.UseVisualStyleBackColor = true;
            btnKutuphaneyeGit.Click += btnKutuphaneyeGit_Click;
            // 
            // btnGiriseDon
            // 
            btnGiriseDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGiriseDon.ForeColor = Color.LightCoral;
            btnGiriseDon.Location = new Point(9, 13);
            btnGiriseDon.Name = "btnGiriseDon";
            btnGiriseDon.Size = new Size(188, 29);
            btnGiriseDon.TabIndex = 2;
            btnGiriseDon.Text = "Giriş Ekranına Dön^_^";
            btnGiriseDon.UseVisualStyleBackColor = true;
            btnGiriseDon.Click += btnGiriseDon_Click;
            // 
            // dgvEmanetlerim
            // 
            dgvEmanetlerim.BackgroundColor = Color.Pink;
            dgvEmanetlerim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmanetlerim.Location = new Point(120, 249);
            dgvEmanetlerim.Name = "dgvEmanetlerim";
            dgvEmanetlerim.RowHeadersWidth = 51;
            dgvEmanetlerim.Size = new Size(670, 309);
            dgvEmanetlerim.TabIndex = 0;
            dgvEmanetlerim.CellContentClick += dgvEmanetlerim_CellContentClick;
            // 
            // flpRaflar
            // 
            flpRaflar.BackgroundImageLayout = ImageLayout.None;
            flpRaflar.Dock = DockStyle.Fill;
            flpRaflar.Location = new Point(0, 0);
            flpRaflar.Name = "flpRaflar";
            flpRaflar.Size = new Size(250, 125);
            flpRaflar.TabIndex = 2;
            // 
            // pnlKutuphanem
            // 
            pnlKutuphanem.Controls.Add(flpRaflar);
            pnlKutuphanem.Location = new Point(502, 265);
            pnlKutuphanem.Name = "pnlKutuphanem";
            pnlKutuphanem.Size = new Size(250, 125);
            pnlKutuphanem.TabIndex = 2;
            pnlKutuphanem.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gırısyapekranı;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(875, 727);
            Controls.Add(pnlGiris);
            Controls.Add(pnlUyeDunyasi);
            Controls.Add(pnlKutuphanem);
            Name = "LoginForm";
            Text = "LoginForm";
            pnlGiris.ResumeLayout(false);
            pnlGiris.PerformLayout();
            pnlUyeDunyasi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmanetlerim).EndInit();
            pnlKutuphanem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Panel pnlGiris;
        private Panel pnlUyeDunyasi;
        private Button btnKutuphaneyeGit;
        private DataGridView dgvEmanetlerim;
        private FlowLayoutPanel flpRaflar;
        private Panel pnlKutuphanem;
        private Button btnGiriseDon;
    }
}