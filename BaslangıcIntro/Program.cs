class Program
{
    private static void Main(string[] args)
    {
        // aleme usulü yazım şekli
        string Baslangic = "Kendini Sartla";
        string Baslangic1 = "Kendine Guven";
        string Baslangic2 = "Disiplinli bir sekilde calis";

        Console.WriteLine(Baslangic);
        Console.WriteLine(Baslangic1);
        Console.WriteLine(Baslangic2);
        
        Console.WriteLine("***************Ikinci gosterim************");

        // Amatör fakat olması gereken şekilde yazım şekli

        string[] BaslangicV1 = new string[] { "Kendini Sartla",
            "Kendine Guven", 
            "Disiplinli bir sekilde calis","Asla pes etme ","Her zaman daha iyi olmak icin calis" };

        for (int i = 0; i < BaslangicV1.Length; i++)
        {
            Console.WriteLine(BaslangicV1[i]);
        }
        // Bu kısımda başlangıç için kurduğumuz cümlelerin birere motivasyon cümlesi olduğu için onlara takma isim verdik ve
        // bunu diziler kolay dolaşmak için daha uygun olan foreach ile yaptık
        foreach (string Motivasyon in BaslangicV1)
        {
                Console.WriteLine(Motivasyon);
        }

        Console.WriteLine("*Her bir son yeni bir baslangictir*");
      

    }
}