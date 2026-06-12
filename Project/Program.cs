using System.Collections;

namespace Project
{
    internal class Program
    {
        static void SatinAlim(ArrayList urunler, ArrayList kilo, string urun)
        {
            bool urunVar = urunler.Contains(urun);
            if (urunVar)
            {
                Console.WriteLine("Kaç Kilo?");
                int urunKilo = Convert.ToInt32(Console.ReadLine());
                int i = urunler.IndexOf(urun);
                int kiloToplam = 0;
                kiloToplam += (int)kilo[i] + urunKilo;
                kilo[i] = kiloToplam;
            }
            else
            {
                urunler.Add(urun);
                Console.WriteLine("Kaç Kilo?");
                int urunKilo = Convert.ToInt32(Console.ReadLine());
                kilo.Add(urunKilo);
            }
        }
        static void Main(string[] args)
        {
            ArrayList halMeyveler = new ArrayList() { "elma", "armut", "muz", "çilek", "kivi" };
            ArrayList halSebzeler = new ArrayList() { "marul", "domates", "salatalık", "biber", "maydanoz" };
            ArrayList manavMeyveler = new ArrayList();
            ArrayList manavSebzeler = new ArrayList();
            ArrayList meyveKilo = new ArrayList();
            ArrayList sebzeKilo = new ArrayList();
            ArrayList musteri = new ArrayList();

            while (true)
            {
                try
                {
                    Console.WriteLine("***** Hale Hoşgeldiniz*****");
                    Console.WriteLine("Meyve mi sebze mi?");
                    string secim = Console.ReadLine().ToLower();
                    if (secim == "meyve")
                    {
                        for (int i = 0; i < halMeyveler.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {halMeyveler[i]}");
                        }
                        Console.WriteLine("Seçim yapınız...");
                        string meyveSecim = Console.ReadLine();

                        if (meyveSecim == "elma")
                        {
                            SatinAlim(manavMeyveler, meyveKilo, meyveSecim);
                        }

                        else if (meyveSecim == "armut")
                        {
                            SatinAlim(manavMeyveler, meyveKilo, meyveSecim);
                        }

                        else if (meyveSecim == "muz")
                        {
                            SatinAlim(manavMeyveler, meyveKilo, meyveSecim);
                        }

                        else if (meyveSecim == "çilek")
                        {
                            SatinAlim(manavMeyveler, meyveKilo, meyveSecim);
                        }

                        else if (meyveSecim == "kivi")
                        {
                            SatinAlim(manavMeyveler, meyveKilo, meyveSecim);
                        }

                        else
                        {
                            Console.WriteLine("Hatalı işlem.");
                            Thread.Sleep(3000);
                        }

                        Console.WriteLine("Başka bir isteğiniz var mı? E/H");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (cevap == "H")
                        {
                            Console.WriteLine("İyi günler...");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim.");
                            Thread.Sleep(3000);
                        }
                    }

                    else if (secim == "sebze")
                    {
                        for (int i = 0; i < halSebzeler.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {halSebzeler[i]}");
                        }
                        Console.WriteLine("Seçim yapınız...");
                        string sebzeSecim = Console.ReadLine();

                        if (sebzeSecim == "marul")
                        {
                            SatinAlim(manavSebzeler, sebzeKilo, sebzeSecim);
                        }

                        else if (sebzeSecim == "domates")
                        {
                            SatinAlim(manavSebzeler, sebzeKilo, sebzeSecim);
                        }

                        else if (sebzeSecim == "salatalık")
                        {
                            SatinAlim(manavSebzeler, sebzeKilo, sebzeSecim);
                        }

                        else if (sebzeSecim == "biber")
                        {
                            SatinAlim(manavSebzeler, sebzeKilo, sebzeSecim);
                        }

                        else if (sebzeSecim == "maydonoz")
                        {
                            SatinAlim(manavSebzeler, sebzeKilo, sebzeSecim);
                        }

                        else
                        {
                            Console.WriteLine("Hatalı işlem.");
                            Thread.Sleep(3000);
                        }

                        Console.WriteLine("Başka bir isteğiniz var mı? E/H");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (cevap == "H")
                        {
                            Console.WriteLine("İyi günler...");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim.");
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
                        Thread.Sleep(3000);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hatalı işlem" + ex.Message);
                    throw;
                }

            }

            while (true)
            {
                try
                {
                    Console.WriteLine("***** Manava Hoşgeldiniz *****");
                    Console.WriteLine("Meyve mi Sebze mi?");
                    string secim = Console.ReadLine().ToLower();

                    if (secim == "meyve")
                    {
                        for (int i = 0; i < manavMeyveler.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {manavMeyveler[i]} => {meyveKilo[i]}Kilo");
                        }
                        Console.WriteLine("Seçim yapınız...");
                        string meyveSecim = Console.ReadLine().ToLower();
                        if (!manavMeyveler.Contains(meyveSecim))
                        {
                            Console.WriteLine("Ürün mevcut değil.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            continue;
                        }
                        if (manavMeyveler.Contains(meyveSecim))
                        {
                            int index = manavMeyveler.IndexOf(meyveSecim);
                            Console.WriteLine($"Kaç Kilo {manavMeyveler[index]} almak istiyorsunuz?");
                            int kiloAlim = Convert.ToInt32(Console.ReadLine());
                            int meyveKiloIndex = (int)meyveKilo[index];
                            if (meyveKiloIndex >= kiloAlim)
                            {
                                meyveKiloIndex -= kiloAlim;
                                musteri.Add($"{meyveSecim} => {meyveKiloIndex} Kilo");
                                meyveKilo[index] = meyveKiloIndex;

                                Console.WriteLine($"Satın alma işlemi başarılı. Stokta kalan {meyveSecim} => {meyveKiloIndex} Kilo");

                                if (meyveKiloIndex == 0)
                                {
                                    manavMeyveler.RemoveAt(index);
                                    meyveKilo.RemoveAt(index);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"İstediğiniz kilo stokta yok. Mevcut kilo {meyveKiloIndex}");
                                Thread.Sleep(3000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ürün mevcut değil.");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }

                        Console.WriteLine("Başka bir isteğiniz var mı? E/H");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (cevap == "H")
                        {
                            Console.WriteLine("İyi günler...");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim.");
                            Thread.Sleep(3000);
                        }
                    }

                    else if (secim == "sebze")
                    {
                        for (int i = 0; i < manavSebzeler.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {manavSebzeler[i]} => {sebzeKilo[i]}Kilo");
                        }
                        Console.WriteLine("Seçim yapınız...");
                        string sebzeSecim = Console.ReadLine().ToLower();
                        if (!manavSebzeler.Contains(sebzeSecim))
                        {
                            Console.WriteLine("Ürün mevcut değil.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            continue;
                        }
                        if (manavSebzeler.Contains(sebzeSecim))
                        {
                            int index = manavSebzeler.IndexOf(sebzeSecim);
                            Console.WriteLine($"Kaç Kilo {manavSebzeler[index]} almak istiyorsunuz?");
                            int kiloAlim = Convert.ToInt32(Console.ReadLine());
                            int sebzeKiloIndex = (int)sebzeKilo[index];
                            if (sebzeKiloIndex >= kiloAlim)
                            {
                                sebzeKiloIndex -= kiloAlim;
                                musteri.Add($"{sebzeSecim} => {sebzeKiloIndex} Kilo");
                                sebzeKilo[index] = sebzeKiloIndex;
                                Console.WriteLine($"Satın alma işlemi başarılı. Stokta kalan {sebzeSecim} => {sebzeKiloIndex} Kilo");

                                if (sebzeKiloIndex == 0)
                                {
                                    manavSebzeler.RemoveAt(index);
                                    sebzeKilo.RemoveAt(index);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"İstediğiniz kilo stokta yok. Mevcut kilo {sebzeKiloIndex}");
                                Thread.Sleep(3000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ürün mevcut değil.");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }

                        Console.WriteLine("Başka bir isteğiniz var mı? E/H");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (cevap == "H")
                        {
                            Console.WriteLine("İyi günler...");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim.");
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı işlem.");
                        Thread.Sleep(3000);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hatalı işlem" + ex.Message);
                    throw;
                }
            }
            Console.WriteLine("Alışverişiniz tamamlandı. Aldığınız ürünler:");
            foreach (var item in musteri)
            {
                Console.WriteLine(item);
            }
        }
    }
}
