namespace ContohSoal;

partial class FormDaftar
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private Label lblJudul;
    private Label lblSubJudul;
    private Label lblUsername;
    private Label lblNama;
    private Label lblTanggalLahir;
    private Label lblTelepon;
    private Label lblPassword;
    private TextBox txtUsername;
    private TextBox txtNama;
    private DateTimePicker dtTanggalLahir;
    private TextBox txtTelepon;
    private TextBox txtPassword;
    private Button btnDaftar;
    private PictureBox picLogo;
    private Label lblLogoPlaceholder;
    private Label lblLogo;
    private Label lblSudahPunya;
    private LinkLabel linkLogin;

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
        components = new System.ComponentModel.Container();
        lblJudul = new Label();
        lblSubJudul = new Label();
        lblUsername = new Label();
        lblNama = new Label();
        lblTanggalLahir = new Label();
        lblTelepon = new Label();
        lblPassword = new Label();
        txtUsername = new TextBox();
        txtNama = new TextBox();
        dtTanggalLahir = new DateTimePicker();
        txtTelepon = new TextBox();
        txtPassword = new TextBox();
        btnDaftar = new Button();
        picLogo = new PictureBox();
        lblLogoPlaceholder = new Label();
        lblLogo = new Label();
        lblSudahPunya = new Label();
        linkLogin = new LinkLabel();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        picLogo.SuspendLayout();
        SuspendLayout();
        //
        // lblJudul
        //
        lblJudul.AutoSize = true;
        lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblJudul.Location = new Point(20, 15);
        lblJudul.Name = "lblJudul";
        lblJudul.Size = new Size(109, 25);
        lblJudul.TabIndex = 0;
        lblJudul.Text = "Daftar Akun";
        //
        // lblSubJudul
        //
        lblSubJudul.AutoSize = true;
        lblSubJudul.ForeColor = Color.Gray;
        lblSubJudul.Location = new Point(22, 42);
        lblSubJudul.Name = "lblSubJudul";
        lblSubJudul.Size = new Size(284, 15);
        lblSubJudul.TabIndex = 1;
        lblSubJudul.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
        //
        // lblUsername
        //
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(22, 78);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(60, 15);
        lblUsername.TabIndex = 2;
        lblUsername.Text = "Username";
        //
        // txtUsername
        //
        txtUsername.Location = new Point(130, 75);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(200, 23);
        txtUsername.TabIndex = 3;
        txtUsername.Text = "andi";
        //
        // lblNama
        //
        lblNama.AutoSize = true;
        lblNama.Location = new Point(22, 110);
        lblNama.Name = "lblNama";
        lblNama.Size = new Size(39, 15);
        lblNama.TabIndex = 4;
        lblNama.Text = "Nama";
        //
        // txtNama
        //
        txtNama.Location = new Point(130, 107);
        txtNama.Name = "txtNama";
        txtNama.Size = new Size(200, 23);
        txtNama.TabIndex = 5;
        txtNama.Text = "Andi Taulany";
        //
        // lblTanggalLahir
        //
        lblTanggalLahir.AutoSize = true;
        lblTanggalLahir.Location = new Point(22, 142);
        lblTanggalLahir.Name = "lblTanggalLahir";
        lblTanggalLahir.Size = new Size(75, 15);
        lblTanggalLahir.TabIndex = 6;
        lblTanggalLahir.Text = "Tanggal Lahir";
        //
        // dtTanggalLahir
        //
        dtTanggalLahir.CustomFormat = "dd-MM-yyyy";
        dtTanggalLahir.Format = DateTimePickerFormat.Custom;
        dtTanggalLahir.Location = new Point(130, 139);
        dtTanggalLahir.Name = "dtTanggalLahir";
        dtTanggalLahir.Size = new Size(200, 23);
        dtTanggalLahir.TabIndex = 7;
        dtTanggalLahir.Value = new DateTime(2003, 2, 1);
        //
        // lblTelepon
        //
        lblTelepon.AutoSize = true;
        lblTelepon.Location = new Point(22, 174);
        lblTelepon.Name = "lblTelepon";
        lblTelepon.Size = new Size(93, 15);
        lblTelepon.TabIndex = 8;
        lblTelepon.Text = "Nomor Telepon";
        //
        // txtTelepon
        //
        txtTelepon.Location = new Point(130, 171);
        txtTelepon.Name = "txtTelepon";
        txtTelepon.Size = new Size(200, 23);
        txtTelepon.TabIndex = 9;
        txtTelepon.Text = "08123456789";
        //
        // lblPassword
        //
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(22, 206);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(57, 15);
        lblPassword.TabIndex = 10;
        lblPassword.Text = "Password";
        //
        // txtPassword
        //
        txtPassword.Location = new Point(130, 203);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '•';
        txtPassword.Size = new Size(200, 23);
        txtPassword.TabIndex = 11;
        txtPassword.UseSystemPasswordChar = true;
        //
        // btnDaftar
        //
        // (tanpa .Click += ... — handler sengaja dikosongkan untuk latihan)
        btnDaftar.Location = new Point(200, 240);
        btnDaftar.Name = "btnDaftar";
        btnDaftar.Size = new Size(130, 30);
        btnDaftar.TabIndex = 12;
        btnDaftar.Text = "Daftar";
        btnDaftar.UseVisualStyleBackColor = true;
        //
        // picLogo (placeholder gambar)
        //
        picLogo.BackColor = Color.Gainsboro;
        picLogo.BorderStyle = BorderStyle.FixedSingle;
        picLogo.Controls.Add(lblLogoPlaceholder);
        picLogo.Location = new Point(380, 75);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(200, 140);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 13;
        picLogo.TabStop = false;
        //
        // lblLogoPlaceholder
        //
        lblLogoPlaceholder.Dock = DockStyle.Fill;
        lblLogoPlaceholder.ForeColor = Color.Gray;
        lblLogoPlaceholder.Location = new Point(0, 0);
        lblLogoPlaceholder.Name = "lblLogoPlaceholder";
        lblLogoPlaceholder.Size = new Size(198, 138);
        lblLogoPlaceholder.TabIndex = 0;
        lblLogoPlaceholder.Text = "[ LOGO ]";
        lblLogoPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblLogo
        //
        lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblLogo.ForeColor = Color.FromArgb(20, 60, 140);
        lblLogo.Location = new Point(380, 220);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(200, 30);
        lblLogo.TabIndex = 14;
        lblLogo.Text = "BROMO AIRLINES";
        lblLogo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblSudahPunya
        //
        lblSudahPunya.AutoSize = true;
        lblSudahPunya.Location = new Point(22, 300);
        lblSudahPunya.Name = "lblSudahPunya";
        lblSudahPunya.Size = new Size(105, 15);
        lblSudahPunya.TabIndex = 15;
        lblSudahPunya.Text = "Sudah punya akun?";
        //
        // linkLogin
        //
        linkLogin.AutoSize = true;
        linkLogin.Location = new Point(130, 300);
        linkLogin.Name = "linkLogin";
        linkLogin.Size = new Size(37, 15);
        linkLogin.TabIndex = 16;
        linkLogin.TabStop = true;
        linkLogin.Text = "Login";
        linkLogin.LinkClicked += linkLogin_LinkClicked;
        //
        // FormDaftar
        //
        AcceptButton = btnDaftar;
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(630, 340);
        Controls.Add(lblJudul);
        Controls.Add(lblSubJudul);
        Controls.Add(lblUsername);
        Controls.Add(txtUsername);
        Controls.Add(lblNama);
        Controls.Add(txtNama);
        Controls.Add(lblTanggalLahir);
        Controls.Add(dtTanggalLahir);
        Controls.Add(lblTelepon);
        Controls.Add(txtTelepon);
        Controls.Add(lblPassword);
        Controls.Add(txtPassword);
        Controls.Add(btnDaftar);
        Controls.Add(picLogo);
        Controls.Add(lblLogo);
        Controls.Add(lblSudahPunya);
        Controls.Add(linkLogin);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "FormDaftar";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bromo Airlines - Daftar Akun";
        picLogo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
