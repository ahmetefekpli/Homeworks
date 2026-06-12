namespace Method_Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] sayilarDizisi = new int[15];

            for (int i = 0; i < sayilarDizisi.Length; i++)
            {
                sayilarDizisi[i] = random.Next(1, 101);
            }
            TekCift(sayilarDizisi, out int[] tekSayilar, out int[] ciftSayilar);

            Console.WriteLine("Tek Sayılar:\n");
            for (int i = 0; i < tekSayilar.Length; i++)
            {
                Console.WriteLine(tekSayilar[i]);
            }
            Console.WriteLine("**********************");
            Console.WriteLine("Çift Sayılar:\n");
            for (int i = 0; i < ciftSayilar.Length; i++)
            {
                Console.WriteLine(ciftSayilar[i]);
            }
        }
        static void TekCift(int[] sayilar, out int[] tekSayilar, out int[] ciftSayilar)
        {
            int tsayiSayac = 0;
            int csayiSayac = 0;
            foreach (int s in sayilar)
            {
                if (s % 2 == 0)
                {
                    csayiSayac++;
                }
                else
                {
                    tsayiSayac++;
                }
            }

            int[] tekDizisi = new int[tsayiSayac];
            int[] ciftDizisi = new int[csayiSayac];

            int tekIndex = 0;
            int ciftIndex = 0;

            foreach (int item in sayilar)
            {
                if (item % 2 == 0)
                {
                    ciftDizisi[ciftIndex] = item;
                    ciftIndex++;
                }
                else
                {
                    tekDizisi[tekIndex] = item;
                    tekIndex++;
                }
            }

            tekSayilar = tekDizisi;
            ciftSayilar = ciftDizisi;
        }
    }
}
