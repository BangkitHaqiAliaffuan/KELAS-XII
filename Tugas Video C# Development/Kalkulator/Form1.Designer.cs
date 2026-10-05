namespace Kalkulator;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private TextBox txtAngka1;
    private TextBox txtAngka2;
    private Label lblHasil;
    private Button btnTambah;
    private Button btnKurang;
    private Button btnKali;
    private Button btnBagi;

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
        txtAngka1 = new TextBox();
        txtAngka2 = new TextBox();
        lblHasil = new Label();
        btnTambah = new Button();
        btnKurang = new Button();
        btnKali = new Button();
        btnBagi = new Button();
        SuspendLayout();
        //
        // txtAngka1
        //
        txtAngka1.Location = new Point(12, 12);
        txtAngka1.Name = "txtAngka1";
        txtAngka1.PlaceholderText = "Angka 1";
        txtAngka1.Size = new Size(130, 23);
        txtAngka1.TabIndex = 0;
        //
        // txtAngka2
        //
        txtAngka2.Location = new Point(150, 12);
        txtAngka2.Name = "txtAngka2";
        txtAngka2.PlaceholderText = "Angka 2";
        txtAngka2.Size = new Size(130, 23);
        txtAngka2.TabIndex = 1;
        //
        // lblHasil
        //
        lblHasil.AutoSize = true;
        lblHasil.Location = new Point(12, 48);
        lblHasil.Name = "lblHasil";
        lblHasil.Size = new Size(52, 15);
        lblHasil.TabIndex = 2;
        lblHasil.Text = "Hasil: -";
        //
        // btnTambah
        //
        btnTambah.Location = new Point(12, 75);
        btnTambah.Name = "btnTambah";
        btnTambah.Size = new Size(64, 35);
        btnTambah.TabIndex = 3;
        btnTambah.Text = "+";
        btnTambah.Click += BtnTambah_Click;
        btnTambah.UseVisualStyleBackColor = true;
        //
        // btnKurang
        //
        btnKurang.Location = new Point(82, 75);
        btnKurang.Name = "btnKurang";
        btnKurang.Size = new Size(64, 35);
        btnKurang.TabIndex = 4;
        btnKurang.Text = "-";
        btnKurang.Click += BtnKurang_Click;
        btnKurang.UseVisualStyleBackColor = true;
        //
        // btnKali
        //
        btnKali.Location = new Point(152, 75);
        btnKali.Name = "btnKali";
        btnKali.Size = new Size(64, 35);
        btnKali.TabIndex = 5;
        btnKali.Text = "x";
        btnKali.Click += BtnKali_Click;
        btnKali.UseVisualStyleBackColor = true;
        //
        // btnBagi
        //
        btnBagi.Location = new Point(222, 75);
        btnBagi.Name = "btnBagi";
        btnBagi.Size = new Size(64, 35);
        btnBagi.TabIndex = 6;
        btnBagi.Text = "/";
        btnBagi.Click += BtnBagi_Click;
        btnBagi.UseVisualStyleBackColor = true;
        //
        // Form1
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(300, 130);
        Controls.Add(txtAngka1);
        Controls.Add(txtAngka2);
        Controls.Add(lblHasil);
        Controls.Add(btnTambah);
        Controls.Add(btnKurang);
        Controls.Add(btnKali);
        Controls.Add(btnBagi);
        Name = "Form1";
        Text = "Kalkulator";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
