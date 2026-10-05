using System.Net.Http.Headers;

namespace Kalkulator;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
    }

    private (double hasil, double a, double b)? Hitung(string operation)
    {
        if (!double.TryParse(txtAngka1.Text, out double a) || !double.TryParse(txtAngka2.Text, out double b))
        {
            MessageBox.Show("isi keduanya dengan angka");
            return null;
        }

        double hasil = operation switch
        {
            "+" => a + b,
            "-" => a - b,
            "/" => a / b,
            "*" => a * b,
            _ => 0
        };

        return (hasil, a, b);
    }

    private void BtnTambah_Click(object? sender, EventArgs e)
    {
        var r = Hitung("+");
        if (r is null) return;
        lblHasil.Text = $"{r.Value.a} + {r.Value.b} = {r.Value.hasil}";
    }

    private void BtnKurang_Click(object? sender, EventArgs e)
    {
        var r = Hitung("-");
        if (r is null) return;
        lblHasil.Text = $"{r.Value.a} + {r.Value.b} = {r.Value.hasil}";
    }
    private void BtnKali_Click(object? sender, EventArgs e)
    {
        var r = Hitung("*");
        if (r is null) return;
        lblHasil.Text = $"{r.Value.a} + {r.Value.b} = {r.Value.hasil}";
    }
    private void BtnBagi_Click(object? sender, EventArgs e)
    {
        var r = Hitung("/");
        if (r is null) return;
        lblHasil.Text = $"{r.Value.a} + {r.Value.b} = {r.Value.hasil}";
    }
}
