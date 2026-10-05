namespace Dasar;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private Button btnHello;
    private Button btnContoh;
    private Button btnLoop;
    private Label lblInfo;

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
        btnHello = new Button();
        btnContoh = new Button();
        btnLoop = new Button();
        lblInfo = new Label();
        SuspendLayout();
        //
        // btnHello
        //
        btnHello.Location = new Point(12, 12);
        btnHello.Name = "btnHello";
        btnHello.Size = new Size(120, 30);
        btnHello.TabIndex = 0;
        btnHello.Text = "Klik Saya";
        btnHello.UseVisualStyleBackColor = true;
        btnHello.Click += btnHello_Click;
        //
        // btnContoh
        //
        btnContoh.Location = new Point(140, 12);
        btnContoh.Name = "btnContoh";
        btnContoh.Size = new Size(140, 30);
        btnContoh.TabIndex = 1;
        btnContoh.Text = "Jalankan Contoh";
        btnContoh.UseVisualStyleBackColor = true;
        btnContoh.Click += btnContoh_Click;
        //
        // btnLoop
        //
        btnLoop.Location = new Point(12, 48);
        btnLoop.Name = "btnLoop";
        btnLoop.Size = new Size(268, 30);
        btnLoop.TabIndex = 2;
        btnLoop.Text = "Contoh Loop";
        btnLoop.UseVisualStyleBackColor = true;
        btnLoop.Click += btnLoop_Click;
        //
        // lblInfo
        //
        lblInfo.AutoSize = true;
        lblInfo.Location = new Point(12, 90);
        lblInfo.Name = "lblInfo";
        lblInfo.Size = new Size(75, 15);
        lblInfo.TabIndex = 3;
        lblInfo.Text = "Belum diklik";
        //
        // Form1
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(300, 160);
        Controls.Add(btnHello);
        Controls.Add(btnContoh);
        Controls.Add(btnLoop);
        Controls.Add(lblInfo);
        Name = "Form1";
        Text = "Dasar";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
