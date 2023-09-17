
class Program
{
     static void Main(string[] args)
    {
        kullanicilar insan = new kullanicilar();
        insan.MusteriAdi = "Samil";
        insan.MusteriSoyadi = "YILDIZ";
        insan.TCNO = "11800000000";
        insan.MusteriYasi = 23;
        insan.Adres = "Konya/Selcuklu Yazır Mah.";
        insan.EpostaAdresi = "yildizmsamil@gmail.com";
        insan.TelefonNumarasi = "5523210000";

        kullanicilar insan1 = new kullanicilar();
        insan1.MusteriAdi = "Sumeyye";
        insan1.MusteriSoyadi = "YILDIZ";
        insan1.TCNO = "10000000000";
        insan1.MusteriYasi = 21;
        insan1.Adres = "Konya/Selcuklu Yazır Mah.";
        insan1.EpostaAdresi = "smyerdems2002@gmail.com";
        insan1.TelefonNumarasi = "5418297690";

        kullanicilar insan2 = new kullanicilar();
        insan2.MusteriAdi = "Abdurrahman";
        insan2.MusteriSoyadi = "YILDIZ";
        insan2.TCNO = "30000000000";
        insan2.MusteriYasi = 21;
        insan2.Adres = "Kocaeli/izmit Yazır Mah.";
        insan2.EpostaAdresi = "abduryil@gmail.com";
        insan2.TelefonNumarasi = "5511319455";

        kullanicilar[] veriler = new kullanicilar[] {insan, insan1, insan2 };

        foreach (kullanicilar insanlar in veriler)
        {
            Console.WriteLine(insanlar.MusteriAdi+insanlar.MusteriSoyadi);
            Console.WriteLine(insanlar.MusteriYasi+ " : "+insanlar.TCNO);
            Console.WriteLine(insanlar.Adres);
            Console.WriteLine(insanlar.EpostaAdresi+"      "+insanlar.TelefonNumarasi);    
        }

    }

        
    
}
class kullanicilar
{
    public string MusteriAdi { get; set; }
    public string MusteriSoyadi { get; set; }
    public string TCNO { get; set; }
    public int MusteriYasi { get; set; }
    public string Adres { get; set; }
    public string EpostaAdresi { get; set; }
    public string TelefonNumarasi { get; set; }

}