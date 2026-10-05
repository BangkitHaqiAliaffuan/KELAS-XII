namespace ContohSoal;

public partial class UcBandara : UserControl
{
    public UcBandara()
    {
        InitializeComponent();
        IsiDummy();
    }

    // Data dummy agar grid langsung terlihat (ganti dengan database nanti)
    private void IsiDummy()
    {
        dgvBandara.Rows.Add("SUB", "Juanda", "Surabaya", "Indonesia");
        dgvBandara.Rows.Add("DPS", "Ngurah Rai", "Denpasar", "Indonesia");
        dgvBandara.Rows.Add("CGK", "Soekarno Hatta", "Jakarta", "Indonesia");
    }
}
