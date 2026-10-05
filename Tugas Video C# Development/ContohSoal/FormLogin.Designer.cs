namespace ContohSoal;

partial class FormLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private PictureBox picLogo;
    private Label lblLogoPlaceholder;
    private Label lblLogo;
    private Label lblSubLogo;
    private Label lblUsername;
    private Label lblPassword;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Button btnLogin;
    private Label lblBelumPunya;
    private LinkLabel linkDaftar;

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
        picLogo = new PictureBox();
        lblLogoPlaceholder = new Label();
        lblLogo = new Label();
        lblSubLogo = new Label();
        lblUsername = new Label();
        lblPassword = new Label();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        lblBelumPunya = new Label();
        linkDaftar = new LinkLabel();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        picLogo.SuspendLayout();
        SuspendLayout();
        //
        // picLogo (placeholder gambar — ganti Image-nya dengan logo asli nanti)
        //
        picLogo.BackColor = Color.Gainsboro;
        picLogo.BorderStyle = BorderStyle.FixedSingle;
        picLogo.Controls.Add(lblLogoPlaceholder);
        picLogo.Location = new Point(100, 12);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(100, 80);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 0;
        picLogo.TabStop = false;
        //
        // lblLogoPlaceholder
        //
        lblLogoPlaceholder.Dock = DockStyle.Fill;
        lblLogoPlaceholder.ForeColor = Color.Gray;
        lblLogoPlaceholder.Location = new Point(0, 0);
        lblLogoPlaceholder.Name = "lblLogoPlaceholder";
        lblLogoPlaceholder.Size = new Size(98, 78);
        lblLogoPlaceholder.TabIndex = 0;
        lblLogoPlaceholder.Text = "[ LOGO ]";
        lblLogoPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblLogo
        //
        lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblLogo.ForeColor = Color.FromArgb(20, 60, 140);
        lblLogo.Location = new Point(12, 96);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(276, 32);
        lblLogo.TabIndex = 1;
        lblLogo.Text = "BROMO";
        lblLogo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblSubLogo
        //
        lblSubLogo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblSubLogo.ForeColor = Color.FromArgb(20, 60, 140);
        lblSubLogo.Location = new Point(12, 126);
        lblSubLogo.Name = "lblSubLogo";
        lblSubLogo.Size = new Size(276, 24);
        lblSubLogo.TabIndex = 2;
        lblSubLogo.Text = "AIRLINES";
        lblSubLogo.TextAlign = ContentAlignment.TopCenter;
        //
        // lblUsername
        //
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(30, 165);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(60, 15);
        lblUsername.TabIndex = 3;
        lblUsername.Text = "Username";
        //
        // txtUsername
        //
        txtUsername.Location = new Point(105, 162);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(160, 23);
        txtUsername.TabIndex = 4;
        txtUsername.Text = "user";
        //
        // lblPassword
        //
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(30, 195);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(57, 15);
        lblPassword.TabIndex = 5;
        lblPassword.Text = "Password";
        //
        // txtPassword
        //
        txtPassword.Location = new Point(105, 192);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '•';
        txtPassword.Size = new Size(160, 23);
        txtPassword.TabIndex = 6;
        txtPassword.UseSystemPasswordChar = true;
        //
        // btnLogin
        //
        btnLogin.Location = new Point(190, 225);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(75, 28);
        btnLogin.TabIndex = 7;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        //
        // lblBelumPunya
        //
        lblBelumPunya.AutoSize = true;
        lblBelumPunya.Location = new Point(70, 268);
        lblBelumPunya.Name = "lblBelumPunya";
        lblBelumPunya.Size = new Size(101, 15);
        lblBelumPunya.TabIndex = 8;
        lblBelumPunya.Text = "Belum punya akun?";
        //
        // linkDaftar
        //
        linkDaftar.AutoSize = true;
        linkDaftar.Location = new Point(173, 268);
        linkDaftar.Name = "linkDaftar";
        linkDaftar.Size = new Size(82, 15);
        linkDaftar.TabIndex = 9;
        linkDaftar.TabStop = true;
        linkDaftar.Text = "Daftar Sekarang";
        linkDaftar.LinkClicked += linkDaftar_LinkClicked;
        //
        // FormLogin
        //
        AcceptButton = btnLogin;
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(300, 305);
        Controls.Add(picLogo);
        Controls.Add(lblLogo);
        Controls.Add(lblSubLogo);
        Controls.Add(lblUsername);
        Controls.Add(txtUsername);
        Controls.Add(lblPassword);
        Controls.Add(txtPassword);
        Controls.Add(btnLogin);
        Controls.Add(lblBelumPunya);
        Controls.Add(linkDaftar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "FormLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bromo Airlines - Login";
        picLogo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
