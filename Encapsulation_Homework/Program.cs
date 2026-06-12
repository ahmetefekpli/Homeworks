namespace Encapsulation_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Bank_Account bank_Account = new Bank_Account();

                Console.WriteLine("***** Atm Arayüz *****");
                Console.WriteLine("Kullanıcı girişi için şifreyi giriniz. Misafir iseniz 0 giriniz.");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 0)
                {
                    Console.Clear();
                    bank_Account.MisafirPanel();
                }
                else if (secim == bank_Account.Sifre)
                {
                    Console.Clear();
                    bank_Account.KullaniciPanel(secim);
                }
            }
        }
    }
}
