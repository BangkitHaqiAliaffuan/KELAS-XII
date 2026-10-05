namespace ContohSoal;

partial class UcBandara
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private Label lblJudul;
    private TextBox txtCari;
    private Button btnCari;
    private DataGridView dgvBandara;
    private DataGridViewTextBoxColumn colKode;
    private DataGridViewTextBoxColumn colNama;
    private DataGridViewTextBoxColumn colKota;
    private DataGridViewTextBoxColumn colNegara;
    private Label lblKode;
    private Label lblNama;
    private Label lblKota;
    private Label lblNegara;
    private TextBox txtKode;
    private TextBox txtNama;
    private TextBox txtKota;
    private TextBox txtNegara;
    private Button btnTambah;
    private Button btnUbah;
    private Button btnHapus;

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

    #region Component Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblJudul = new Label();
        txtCari = new TextBox();
        btnCari = new Button();
        dgvBandara = new DataGridView();
        colKode = new DataGridViewTextBoxColumn();
        colNama = new DataGridViewTextBoxColumn();
        colKota = new DataGridViewTextBoxColumn();
        colNegara = new DataGridViewTextBoxColumn();
        lblKode = new Label();
        lblNama = new Label();
        lblKota = new Label();
        lblNegara = new Label();
        txtKode = new TextBox();
        txtNama = new TextBox();
        txtKota = new TextBox();
        txtNegara = new TextBox();
        btnTambah = new Button();
        btnUbah = new Button();
        btnHapus = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvBandara).BeginInit();
        SuspendLayout();
        //
        // lblJudul
        //
        lblJudul.AutoSize = true;
        lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblJudul.Location = new Point(15, 12);
        lblJudul.Name = "lblJudul";
        lblJudul.Size = new Size(144, 25);
        lblJudul.TabIndex = 0;
        lblJudul.Text = "Master Bandara";
        //
        // txtCari
        //
        txtCari.Location = new Point(330, 15);
        txtCari.Name = "txtCari";
        txtCari.PlaceholderText = "Cari kode / nama...";
        txtCari.Size = new Size(160, 23);
        txtCari.TabIndex = 1;
        //
        // btnCari
        //
        // (tanpa .Click += ... — untuk latihan)
        btnCari.Location = new Point(496, 14);
        btnCari.Name = "btnCari";
        btnCari.Size = new Size(70, 25);
        btnCari.TabIndex = 2;
        btnCari.Text = "Cari";
        btnCari.UseVisualStyleBackColor = true;
        //
        // dgvBandara
        //
        dgvBandara.AllowUserToAddRows = false;
        dgvBandara.AllowUserToDeleteRows = false;
        dgvBandara.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvBandara.Columns.AddRange(new DataGridViewColumn[] { colKode, colNama, colKota, colNegara });
        dgvBandara.Location = new Point(15, 50);
        dgvBandara.MultiSelect = false;
        dgvBandara.Name = "dgvBandara";
        dgvBandara.ReadOnly = true;
        dgvBandara.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBandara.Size = new Size(551, 180);
        dgvBandara.TabIndex = 3;
        //
        // colKode
        //
        colKode.HeaderText = "Kode";
        colKode.Name = "colKode";
        colKode.ReadOnly = true;
        colKode.Width = 70;
        //
        // colNama
        //
        colNama.HeaderText = "Nama";
        colNama.Name = "colNama";
        colNama.ReadOnly = true;
        colNama.Width = 170;
        //
        // colKota
        //
        colKota.HeaderText = "Kota";
        colKota.Name = "colKota";
        colKota.ReadOnly = true;
        colKota.Width = 150;
        //
        // colNegara
        //
        colNegara.HeaderText = "Negara";
        colNegara.Name = "colNegara";
        colNegara.ReadOnly = true;
        colNegara.Width = 150;
        //
        // lblKode
        //
        lblKode.AutoSize = true;
        lblKode.Location = new Point(15, 248);
        lblKode.Name = "lblKode";
        lblKode.Size = new Size(37, 15);
        lblKode.TabIndex = 4;
        lblKode.Text = "Kode";
        //
        // txtKode
        //
        txtKode.Location = new Point(90, 245);
        txtKode.MaxLength = 3;
        txtKode.Name = "txtKode";
        txtKode.PlaceholderText = "SUB";
        txtKode.Size = new Size(180, 23);
        txtKode.TabIndex = 5;
        //
        // lblNama
        //
        lblNama.AutoSize = true;
        lblNama.Location = new Point(300, 248);
        lblNama.Name = "lblNama";
        lblNama.Size = new Size(39, 15);
        lblNama.TabIndex = 6;
        lblNama.Text = "Nama";
        //
        // txtNama
        //
        txtNama.Location = new Point(360, 245);
        txtNama.Name = "txtNama";
        txtNama.Size = new Size(206, 23);
        txtNama.TabIndex = 7;
        //
        // lblKota
        //
        lblKota.AutoSize = true;
        lblKota.Location = new Point(15, 280);
        lblKota.Name = "lblKota";
        lblKota.Size = new Size(31, 15);
        lblKota.TabIndex = 8;
        lblKota.Text = "Kota";
        //
        // txtKota
        //
        txtKota.Location = new Point(90, 277);
        txtKota.Name = "txtKota";
        txtKota.Size = new Size(180, 23);
        txtKota.TabIndex = 9;
        //
        // lblNegara
        //
        lblNegara.AutoSize = true;
        lblNegara.Location = new Point(300, 280);
        lblNegara.Name = "lblNegara";
        lblNegara.Size = new Size(45, 15);
        lblNegara.TabIndex = 10;
        lblNegara.Text = "Negara";
        //
        // txtNegara
        //
        txtNegara.Location = new Point(360, 277);
        txtNegara.Name = "txtNegara";
        txtNegara.Size = new Size(206, 23);
        txtNegara.TabIndex = 11;
        //
        // btnTambah
        //
        // (tanpa .Click += ... — untuk latihan)
        btnTambah.Location = new Point(300, 315);
        btnTambah.Name = "btnTambah";
        btnTambah.Size = new Size(80, 30);
        btnTambah.TabIndex = 12;
        btnTambah.Text = "Tambah";
        btnTambah.UseVisualStyleBackColor = true;
        //
        // btnUbah
        //
        btnUbah.Location = new Point(390, 315);
        btnUbah.Name = "btnUbah";
        btnUbah.Size = new Size(80, 30);
        btnUbah.TabIndex = 13;
        btnUbah.Text = "Ubah";
        btnUbah.UseVisualStyleBackColor = true;
        //
        // btnHapus
        //
        btnHapus.Location = new Point(480, 315);
        btnHapus.Name = "btnHapus";
        btnHapus.Size = new Size(80, 30);
        btnHapus.TabIndex = 14;
        btnHapus.Text = "Hapus";
        btnHapus.UseVisualStyleBackColor = true;
        //
        // UcBandara
        //
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Controls.Add(lblJudul);
        Controls.Add(txtCari);
        Controls.Add(btnCari);
        Controls.Add(dgvBandara);
        Controls.Add(lblKode);
        Controls.Add(txtKode);
        Controls.Add(lblNama);
        Controls.Add(txtNama);
        Controls.Add(lblKota);
        Controls.Add(txtKota);
        Controls.Add(lblNegara);
        Controls.Add(txtNegara);
        Controls.Add(btnTambah);
        Controls.Add(btnUbah);
        Controls.Add(btnHapus);
        Name = "UcBandara";
        Size = new Size(585, 360);
        ((System.ComponentModel.ISupportInitialize)dgvBandara).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
