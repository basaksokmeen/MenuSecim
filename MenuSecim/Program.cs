using System;

namespace MenuSecim
{
    class Program
    {
        static int hesap = 0;
        static void Main(string[] args)
        {

            int secim;
            do
            {
                Console.WriteLine("Ana Menü");
                Console.WriteLine("1 - Yiyecekler");
                Console.WriteLine("2 - İçecekler");
                Console.WriteLine("3 - Tatlılar");
                Console.WriteLine("4 - Hesap Öde");
                Console.WriteLine("İşlem yapmak için numara giriniz:");
                secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                    yiyecekler();
                else if (secim == 2)
                    icecekler();
                else if (secim == 3)
                    tatlilar();
                else if (secim == 4)
                   hesapode();
                else
                    break;
            } while(secim != 4);
        }

        static void yiyecekler()
        {
            Console.WriteLine("Seçtiğiniz yemeğin numarasını giriniz:");
            Console.WriteLine("1 - Karnıyarık");
            Console.WriteLine("2 - Pilav");
            Console.WriteLine("3 - Mantı");
            Console.WriteLine("4 - Tavuk Sote");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                hesap += 30;
                Console.WriteLine("Karnıyarık Hazırlanıyor.");
            }
            else if (secim == 2)
            {
                hesap += 15;
                Console.WriteLine("Pilav Hazırlanıyor.");
            }
            else if (secim == 3)
            {
                hesap += 25;
                Console.WriteLine("Mantı Hazırlanıyor.");
            }
            else if (secim == 4)
            {
                hesap += 30;
                Console.WriteLine("Tavuk Sote Hazırlanıyor.");
            }
            else
                Console.WriteLine("Geçersiz İşlem Yaptınız.");
            Console.ReadLine();
        }

        static void icecekler()
        {
            Console.WriteLine("Seçtiğiniz içeceğin numarasını giriniz:");
            Console.WriteLine("1 - Kola");
            Console.WriteLine("2 - Fanta");
            Console.WriteLine("3 - Ayran");
            Console.WriteLine("4 - Su");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                hesap += 10;
                Console.WriteLine("Kola Getiriliyor.");
            }
            else if (secim == 2)
            {
                hesap += 10;
                Console.WriteLine("Fanta Getiriliyor.");
            }
            else if (secim == 3)
            {
                hesap += 8;
                Console.WriteLine("Ayran Getiriliyor.");
            }
            else if (secim == 4)
            {
                hesap += 5;
                Console.WriteLine("Su Getiriliyor.");
            }
            else
                Console.WriteLine("Geçersiz İşlem Yaptınız.");
            Console.ReadLine();
        }

        static void tatlilar()
        {
            Console.WriteLine("Seçtiğiniz Tatlının numarasını giriniz:");
            Console.WriteLine("1 - Sütlaç");
            Console.WriteLine("2 - Puding");
            Console.WriteLine("3 - Kazandibi");
            Console.WriteLine("4 - Tavuk Göğsü");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                hesap += 15;
                Console.WriteLine("Sütlaç Hazırlanıyor.");
            }
            else if (secim == 2)
            {
                hesap += 15;
                Console.WriteLine("Puding Hazırlanıyor.");
            }
            else if (secim == 3)
            {
                hesap += 17;
                Console.WriteLine("Kazandibi Hazırlanıyor.");
            }
            else if (secim == 4)
            {
                hesap += 17;
                Console.WriteLine("Tavuk Göğsü Hazırlanıyor.");
            }
            else
                Console.WriteLine("Geçersiz İşlem Yaptınız.");
            Console.ReadLine();
        }
        static void hesapode()
        {
            Console.WriteLine("Hesabınız = {0} TL' dir.", hesap);
            Console.WriteLine("Mutlu Günler. Tekrar Bekleriz.");
            Console.ReadLine();

        }


    }
}
