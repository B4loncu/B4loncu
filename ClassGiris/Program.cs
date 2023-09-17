
class Program
{
     static void Main(string[] args)
    {
        kullanicilar insan = new kullanicilar();
        insan.MusteriAdi = "ZURT";
        insan.MusteriSoyadi = "ZURT";
        insan.TCNO = "ZURT";
        insan.MusteriYasi = 12;
        insan.Adres = "ZURT";
        insan.EpostaAdresi = "ZURT";
        insan.TelefonNumarasi = "ZURT";

        kullanicilar insan1 = new kullanicilar();
        insan1.MusteriAdi = "ZURT";
        insan1.MusteriSoyadi = "ZURT";
        insan1.TCNO = "ZURT";
        insan1.MusteriYasi = 15;
        insan1.Adres = "ZURT";
        insan1.EpostaAdresi = "ZURT@gmail.com";
        insan1.TelefonNumarasi = "ZURT";

        kullanicilar insan2 = new kullanicilar();
        insan2.MusteriAdi = "ZURT";
        insan2.MusteriSoyadi = "ZURT";
        insan2.TCNO = "ZURT";
        insan2.MusteriYasi = 6;
        insan2.Adres = "ZURT";
        insan2.EpostaAdresi = "ZURT";
        insan2.TelefonNumarasi = "ZURT";

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
