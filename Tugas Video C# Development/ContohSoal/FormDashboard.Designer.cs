namespace ContohSoal;

partial class FormDashboard
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private Panel pnlHeader;
    private Button btnMenu;
    private Label lblTitle;
    private Panel pnlSidebar;
    private Button btnBandara;
    private Button btnMaskapai;
    private Button btnJadwal;
    private Button btnPromo;
    private Button btnStatus;
    private Button btnLogout;
    private Panel pnlContent;

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
        pnlHeader = new Panel();
        btnMenu = new Button();
        lblTitle = new Label();
        pnlSidebar = new Panel();
        btnBandara = new Button();
        btnMaskapai = new Button();
        btnJadwal = new Button();
        btnPromo = new Button();
        btnStatus = new Button();
        btnLogout = new Button();
        pnlContent = new Panel();
        pnlHeader.SuspendLayout();
        pnlSidebar.SuspendLayout();
        SuspendLayout();
        //
        // pnlHeader
        //
        pnlHeader.BackColor = Color.FromArgb(31, 102, 176);
        pnlHeader.Controls.Add(btnMenu);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(800, 45);
        pnlHeader.TabIndex = 0;
        //
        // btnMenu (placeholder ikon hamburger)
        //
        btnMenu.FlatAppearance.BorderSize = 0;
        btnMenu.FlatStyle = FlatStyle.Flat;
        btnMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnMenu.ForeColor = Color.White;
        btnMenu.Location = new Point(5, 5);
        btnMenu.Name = "btnMenu";
        btnMenu.Size = new Size(40, 35);
        btnMenu.TabIndex = 0;
        btnMenu.Text = "☰";
        btnMenu.UseVisualStyleBackColor = true;
        //
        // lblTitle
        //
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(50, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(84, 20);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Dashboard";
        //
        // pnlSidebar
        //
        pnlSidebar.BackColor = Color.White;
        pnlSidebar.BorderStyle = BorderStyle.FixedSingle;
        pnlSidebar.Controls.Add(btnLogout);
        pnlSidebar.Controls.Add(btnStatus);
        pnlSidebar.Controls.Add(btnPromo);
        pnlSidebar.Controls.Add(btnJadwal);
        pnlSidebar.Controls.Add(btnMaskapai);
        pnlSidebar.Controls.Add(btnBandara);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 45);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(200, 455);
        pnlSidebar.TabIndex = 1;
        //
        // btnBandara (tanpa .Click += ... — handler untuk latihan)
        //
        btnBandara.Dock = DockStyle.Top;
        btnBandara.FlatAppearance.BorderSize = 0;
        btnBandara.FlatStyle = FlatStyle.Flat;
        btnBandara.Location = new Point(0, 0);
        btnBandara.Name = "btnBandara";
        btnBandara.Size = new Size(198, 45);
        btnBandara.TabIndex = 0;
        btnBandara.Text = "◎  Master Bandara";
        btnBandara.TextAlign = ContentAlignment.MiddleLeft;
        btnBandara.Click += btnBandara_Click;
        btnBandara.UseVisualStyleBackColor = true;
        //
        // btnMaskapai
        //
        btnMaskapai.Dock = DockStyle.Top;
        btnMaskapai.FlatAppearance.BorderSize = 0;
        btnMaskapai.FlatStyle = FlatStyle.Flat;
        btnMaskapai.Location = new Point(0, 45);
        btnMaskapai.Name = "btnMaskapai";
        btnMaskapai.Size = new Size(198, 45);
        btnMaskapai.TabIndex = 1;
        btnMaskapai.Text = "➤  Master Maskapai";
        btnMaskapai.TextAlign = ContentAlignment.MiddleLeft;
        btnMaskapai.UseVisualStyleBackColor = true;
        //
        // btnJadwal
        //
        btnJadwal.Dock = DockStyle.Top;
        btnJadwal.FlatAppearance.BorderSize = 0;
        btnJadwal.FlatStyle = FlatStyle.Flat;
        btnJadwal.Location = new Point(0, 90);
        btnJadwal.Name = "btnJadwal";
        btnJadwal.Size = new Size(198, 45);
        btnJadwal.TabIndex = 2;
        btnJadwal.Text = "▤  Master Jadwal Penerbangan";
        btnJadwal.TextAlign = ContentAlignment.MiddleLeft;
        btnJadwal.UseVisualStyleBackColor = true;
        //
        // btnPromo
        //
        btnPromo.Dock = DockStyle.Top;
        btnPromo.FlatAppearance.BorderSize = 0;
        btnPromo.FlatStyle = FlatStyle.Flat;
        btnPromo.Location = new Point(0, 135);
        btnPromo.Name = "btnPromo";
        btnPromo.Size = new Size(198, 45);
        btnPromo.TabIndex = 3;
        btnPromo.Text = "◈  Master Kode Promo";
        btnPromo.TextAlign = ContentAlignment.MiddleLeft;
        btnPromo.UseVisualStyleBackColor = true;
        //
        // btnStatus
        //
        btnStatus.Dock = DockStyle.Top;
        btnStatus.FlatAppearance.BorderSize = 0;
        btnStatus.FlatStyle = FlatStyle.Flat;
        btnStatus.Location = new Point(0, 180);
        btnStatus.Name = "btnStatus";
        btnStatus.Size = new Size(198, 45);
        btnStatus.TabIndex = 4;
        btnStatus.Text = "▦  Ubah Status Penerbangan";
        btnStatus.TextAlign = ContentAlignment.MiddleLeft;
        btnStatus.UseVisualStyleBackColor = true;
        //
        // btnLogout
        //
        btnLogout.Dock = DockStyle.Bottom;
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.ForeColor = Color.FromArgb(200, 40, 40);
        btnLogout.Location = new Point(0, 410);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(198, 43);
        btnLogout.TabIndex = 5;
        btnLogout.Text = "⏻  Logout";
        btnLogout.TextAlign = ContentAlignment.MiddleLeft;
        btnLogout.UseVisualStyleBackColor = true;
        //
        // pnlContent (kosongan — isi per menu nantinya)
        //
        pnlContent.BackColor = Color.White;
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(200, 45);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new Size(600, 455);
        pnlContent.TabIndex = 2;
        //
        // FormDashboard
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 500);
        Controls.Add(pnlContent);
        Controls.Add(pnlSidebar);
        Controls.Add(pnlHeader);
        Name = "FormDashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bromo Airlines - Admin";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlSidebar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
}
