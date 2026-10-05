namespace ContohSoal;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    private void linkDaftar_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        var daftar = new FormDaftar();
        daftar.FormClosed += (s, args) => this.Show();
        daftar.Show();
        this.Hide();
    }
}
