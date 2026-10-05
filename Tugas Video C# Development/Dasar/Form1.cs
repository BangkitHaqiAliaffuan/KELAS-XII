namespace Dasar;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnHello_Click(object? sender, EventArgs e)
    {
        lblInfo.Text = "Hello World!";
    }

    private void btnContoh_Click(object? sender, EventArgs e)
    {
        string hasilVariabel = ContohDasar.DemoVariabel();
        string hasilIf = ContohDasar.DemoIf(82);
        string hasilSwitch = ContohDasar.DemoSwitch(2);

        lblInfo.Text = hasilIf + " | " + hasilSwitch;
        MessageBox.Show(hasilVariabel + "\n" + hasilIf + "\n" + hasilSwitch, "Contoh Dasar C#");
    }

    private void btnLoop_Click(object? sender, EventArgs e)
    {
        string rFor = ContohPerulangan.DemoFor();
        string rWhile = ContohPerulangan.DemoWhile();
        string rForeach = ContohPerulangan.DemoForeach();
        string rArrayList = ContohPerulangan.DemoArrayList();
        string rMethod = ContohPerulangan.DemoMethod();

        lblInfo.Text = rFor + " | " + rWhile;
        MessageBox.Show(rFor + "\n" + rWhile + "\n" + rForeach + "\n" + rArrayList + "\n" + rMethod, "Contoh Loop & Method");
    }
}
