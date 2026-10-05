// Contoh singkat perulangan + array/list + method untuk proyek Dasar.
// namespace sama (Dasar), static class agar mudah dipanggil dari Form.
namespace Dasar;

public static class ContohPerulangan
{
    // 1. Perulangan for : jumlahkan 1..5
    public static string DemoFor()
    {
        int total = 0;
        for (int i = 1; i <= 5; i++)
        {
            total += i; // total = total + i
        }
        return $"for: 1+2+3+4+5 = {total}";
    }

    // 2. Perulangan while : countdown dari 3
    public static string DemoWhile()
    {
        int n = 3;
        string hasil = "";
        while (n > 0)
        {
            hasil += n + ",";
            n--; // kurang 1 tiap putaran
        }
        return $"while: {hasil}Go!";
    }

    // 3. Perulangan foreach : jalan tiap isi array
    public static string DemoForeach()
    {
        string[] buah = { "Apel", "Mangga", "Jeruk" };
        string hasil = "";
        foreach (string b in buah)
        {
            hasil += b + " ";
        }
        return $"foreach: {hasil.Trim()}";
    }

    // 4. Array dan List dasar
    public static string DemoArrayList()
    {
        int[] nilai = { 80, 75, 90 };              // array: ukuran tetap
        List<string> nama = new() { "Budi", "Ani" }; // list: bisa tambah/hapus
        nama.Add("Citra");                          // tambah 1 data

        return $"array: isi[0]={nilai[0]}, jumlah={nilai.Length} | list: {string.Join(",", nama)} (count={nama.Count})";
    }

    // 5. Method dan fungsi dasar : void vs return value
    static void Sapa(string nama, out string pesan) // void lewat out (prosedur)
    {
        pesan = $"Halo, {nama}!";
    }

    static int Tambah(int a, int b) // fungsi dengan return int
    {
        return a + b;
    }

    public static string DemoMethod()
    {
        Sapa("Budi", out string sapa);
        int hasil = Tambah(3, 4);
        return $"method: {sapa} Tambah(3,4) = {hasil}";
    }
}
