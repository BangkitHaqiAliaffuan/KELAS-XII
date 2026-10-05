// Contoh singkat dasar C# untuk proyek Dasar.
// - namespace : Dasar (sama dengan Program.cs dan Form1)
// - class     : ContohDasar (static, tidak perlu di-new)
// - Main      : tetap di Program.cs -> Main(), file ini dipanggil dari Form.
// - variable, tipe data, operasi, if/else-if/else, switch : lihat method di bawah.
namespace Dasar;

public static class ContohDasar
{
    // 1. Variable + tipe data + operasi sederhana
    public static string DemoVariabel()
    {
        string nama = "Budi";      // teks
        int umur = 20;             // bilangan bulat
        double tinggi = 170.5;     // desimal
        bool lulus = true;         // true/false

        int umurTahunDepan = umur + 1;          // operasi tambah
        double sisa = tinggi - 170;             // operasi kurang
        string status = lulus ? "Lulus" : "Belum"; // operasi ternary sederhana

        return $"Nama: {nama}, Umur: {umur} -> {umurTahunDepan}, Tinggi: {tinggi} (sisa {sisa}), Status: {status}";
    }

    // 2. Percabangan if / else if / else
    public static string DemoIf(int nilai)
    {
        if (nilai >= 90)
        {
            return $"Nilai {nilai} = A (Sangat Baik)";
        }
        else if (nilai >= 75)
        {
            return $"Nilai {nilai} = B (Baik)";
        }
        else if (nilai >= 60)
        {
            return $"Nilai {nilai} = C (Cukup)";
        }
        else
        {
            return $"Nilai {nilai} = D (Kurang)";
        }
    }

    // 3. Percabangan switch
    public static string DemoSwitch(int hari)
    {
        switch (hari)
        {
            case 1:
                return "Hari 1 = Senin";
            case 2:
                return "Hari 2 = Selasa";
            case 3:
                return "Hari 3 = Rabu";
            default:
                return $"Hari {hari} = Hari lain / tidak dikenal";
        }
    }
}
