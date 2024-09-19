namespace FociWebApp.Models
{
    public class CsapatEredmenyei
    {
        public string CsapatNev {  get; set; }

        public int GyozelemekSzama { get; set; }

        public int DontetlenekSzama { get; set; }

        public int VeresegekSzama { get; set; }

        public int LottGolokSzama { get; set;}

        public int KapottGolokSzama { get; set; }

        public int JatszottMeccsekSzama { get => GyozelemekSzama + DontetlenekSzama + VeresegekSzama; }
    
        public int GolKulonbseg { get => LottGolokSzama - KapottGolokSzama * DontetlenekSzama;}


    }
}
