using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Homework
{
    internal class Bank_Account
    {
        private double Bakiye { get; set; }
        public int Sifre { get; set; } = 1234;

        public double _Bakiye
        {
            get
            {
                return Bakiye;
            }
            set
            {
                if (value >= 0)
                {
                    Bakiye += value;
                    Console.WriteLine("Para yatırma işlemi başarılı");
                }
                else if (value < 0)
                {
                    double cekilecekMiktar = Math.Abs(value);
                    if (Bakiye >= cekilecekMiktar)
                    {
                        Bakiye -= cekilecekMiktar;
                        Console.WriteLine("Para çekme işlemi başarılı");
                    }
                    else
                    {
                        Console.WriteLine($"Yetersiz bakiye mevcut bakiyeniz: {Bakiye} TL");
                    }
                }
            }
        }
        public void MisafirPanel()
        {
            Console.WriteLine("***** Misafir Paneline Hoşgeldiniz *****");
            Console.WriteLine("1- Para yatırma");
            Console.WriteLine("2- Çıkış");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Deposit();
                Console.Clear();
            }
            else if (secim == "2")
            {
                for (int i = 5; i >= 0; i--)
                {
                    Console.WriteLine($"Çıkış yapılıyor => " + i);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız.");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        public void KullaniciPanel(int sifre)
        {
            while (true)
            {
                Console.WriteLine("***** Kullanıcı Paneline Hoşgeldiniz. *****");
                Console.WriteLine("1- Para yatırma");
                Console.WriteLine("2- Para çekme");
                Console.WriteLine("3- Bakiye sorgulama");
                Console.WriteLine("4- Çıkış");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Deposit();
                    Console.Clear();
                }
                else if (secim == "2")
                {
                    Withdraw();
                    Console.Clear();
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Bakiyeniz => " + Bakiye);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (secim == "4")
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        Console.WriteLine($"Çıkış yapılıyor => " + i);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
        public void Deposit()
        {

            Console.WriteLine("Yatırmak istediğiniz miktarı giriniz.");
            double yatirilanMiktar = Convert.ToDouble(Console.ReadLine());
            if (yatirilanMiktar <= 0)
            {
                Console.WriteLine("Yatırılan para sıfır ya da küçük olamaz");
            }
            else
            {
                _Bakiye = yatirilanMiktar;
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        public void Withdraw()
        {
            Console.WriteLine("Çekmek istediğiniz miktarı giriniz.");
            double cekilenMiktar = Convert.ToDouble(Console.ReadLine());
            if (Bakiye < cekilenMiktar)
            {
                Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.");
                Thread.Sleep(2000);
            }
            else if (cekilenMiktar <= 0)
            {
                Console.WriteLine("Çekilecek para sıfır ya da küçük olamaz");
                Thread.Sleep(2000);
            }
            else
            {

                _Bakiye = cekilenMiktar * -1;
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}

