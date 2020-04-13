class Karyawan
{
    public int NIK { get; set; }
    public string Nama { get; set; }
    public int GajiBulanan { get; set; }

    public Karyawan(int nik, string nama, int gaji)
    {
        this.NIK = nik;
        this.Nama = nama;

        if (gaji < 0)
        {
            this.GajiBulanan = 0;
        }
        else
        {
            this.GajiBulanan = gaji;
        }
    }

    public void BK()
    {
        Console.WriteLine("{0} \t {1} \t {2}", NIK, Nama, GajiBulanan);
    }

    public void KenaikanGaji()
    {
        double tmp = 0;
        tmp = 0.1 * GajiBulanan;
        GajiBulanan += Convert.ToInt32(tmp);
        Console.WriteLine("{0} \t {1} \t {2}", NIK, Nama, GajiBulanan);
    }
}