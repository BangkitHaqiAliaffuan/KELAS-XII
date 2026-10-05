namespace ContohSoal;

public partial class FormDashboard : Form
{
    public FormDashboard()
    {
        InitializeComponent();
    }

    // Helper: muat UserControl ke panel konten + ganti judul header
    private void MuatKonten(UserControl uc, string judul)
    {
        pnlContent.Controls.Clear();
        uc.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(uc);
        lblTitle.Text = judul;
    }

    private void btnBandara_Click(object? sender, EventArgs e)
    {
        MuatKonten(new UcBandara(), "Master Bandara");
    }
}
