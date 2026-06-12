namespace Method_Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Indirim();
        }
        static void Indirim()
        {
            double toplam = 0;
            double urun3 = 0;
            Console.WriteLine("Birinci ürünün fiyatını giriniz.");
            double urun1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci ürünün fiyatını giriniz.");
            double urun2 = Convert.ToDouble(Console.ReadLine());
            if (urun1 > urun2)
            {
                toplam += urun1 + (urun2 * 0.70);
                Console.WriteLine($"İkinci ürüne indirim uygulandı, ürünlerin toplam fiyatı: {toplam}");
                Console.WriteLine("Üçüncü ürüne %50 indirim var devam etmek ister misiniz?\nE/H");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "E")
                {
                    toplam += Indirim(urun3);
                    Console.WriteLine($"Üçüncü ürüne indirim uygulandı, ürünlerin toplam fiyatı: {toplam}");
                }
                else
                {
                    Console.WriteLine("İyi günler...");
                }
            }
            else
            {
                toplam += urun2 + (urun1 * 0.70);
                Console.WriteLine($"Birinci ürüne indirim uygulandı, ürünlerin toplam fiyatı: {toplam}");
                Console.WriteLine("Üçüncü ürüne %50 indirim var devam etmek ister misiniz?\nE/H");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "E")
                {
                    toplam += Indirim(urun3);
                    Console.WriteLine($"Üçüncü ürüne indirim uygulandı, ürünlerin toplam fiyatı: {toplam}");
                }
                else
                {
                    Console.WriteLine("İyi günler...");
                }
            }
        }
        static double Indirim(double urun1)
        {
            Console.WriteLine("Üçüncü ürünün fiyatını giriniz.");
            double urun3 = Convert.ToDouble(Console.ReadLine());
            return urun3 * 0.50;
        }
    }
}
