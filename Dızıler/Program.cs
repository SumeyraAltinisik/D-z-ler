namespace Dızıler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] sehirler = { "adana", "bursa", "ankara", "istanbul" };
            //Console.WriteLine("dizinin 2. Index değeri: " + sehirler[2]);
            //Console.WriteLine(sehirler[0]);
            //Console.WriteLine(sehirler[1]);
            //Console.WriteLine(sehirler[3]);
            //Console.WriteLine(sehirler[2]);

            //Console.WriteLine(sehirler[5]); //hata 5.değer yok

            //int[] ciftsayilar = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            ////Console.WriteLine("dizinin 5.Index değeri: " + ciftsayilar[5]);
            ////Console.WriteLine(ciftsayilar[0]);
            ////Console.WriteLine(ciftsayilar[1]);
            ////Console.WriteLine(ciftsayilar[2]);
            ////Console.WriteLine(ciftsayilar[3]);
            ////Console.WriteLine(ciftsayilar[4]);
            ////Console.WriteLine(ciftsayilar[5]);
            ////Console.WriteLine(ciftsayilar[6]);
            ////Console.WriteLine(ciftsayilar[7]);
            ////Console.WriteLine(ciftsayilar[8]);
            ////Console.WriteLine(ciftsayilar[9]);

            //for (int i = 0; i < 9; i++)
            //{
            //    Console.WriteLine(ciftsayilar[i]);
            //}

            //dizilerle beraber karar yapıları kullanımı
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i]%20==0 && sayilar[i]%30==00)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }

            //}

            //LENGTH KOMUTU: dizinin uzunluğunu verir.
            //Console.WriteLine("Length kullanımı");
            //Console.WriteLine();
            //string[] kisiler = { "ali", "ayşe", "veli", "ahmet", "eylül" };
            ////for (int i = 0; i < kisiler.Length; i++)
            ////{
            ////    Console.WriteLine(kisiler[i]);

            ////}
            //Console.Write(kisiler.Length);

            //Dizilerde toplama işlemi
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //int toplam=0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    toplam+=sayilar[i];
            //    Console.WriteLine(toplam);
            //}

            //SORT Methodu
            //int[] sayilar = { 50, 20, 14, 32, 13, 27, 70, 80, 90 };
            //Array.Sort(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //REVERSE methodu
            //string[] sehirler = { "adana", "bursa", "ankara", "istanbul" };
            //Array.Reverse(sehirler);
            //Array.Sort(sehirler);
            //Array.Reverse(sehirler); //önce sırala sonra tersten sırala (z den a ya)
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            //Index Of Methodu
            //string[] kisiler = { "ali", "ayşe", "veli", "ahmet", "eylül" };
            //int sira;
            //Array.Sort(kisiler);
            //sira = Array.IndexOf(kisiler, "veli");
            //Console.WriteLine(sira);

            //MIN-MAX
            //int[] sayilar = { 76, 43, 12, 56, 34 };
            //Console.WriteLine("En küçük sayı: "+ sayilar.Min());
            //Console.WriteLine("En büyük sayı: " + sayilar.Max());

            //FOREACH DONGUSU
            //string[] sehirler = { "adana", "bursa", "ankara", "istanbul" };
            //foreach(string s in sehirler)
            //{
            //    Console.WriteLine(s);
            //}

            //int[] sayilar = { 23, 55, 32, 16, 89, 70 };
            //int toplam = 0;
            //foreach(int x in sayilar)
            //{
            //    toplam = toplam + x;
            //}
            //Console.WriteLine(toplam);

            //int[] sayilar = { 34, 22, 11, 67, 89, 50};
            //Array.Sort(sayilar);
            //foreach (int sayi in sayilar)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine("Çift sayılar: " + sayi);

            //    }

            //}

            //Klavyeden diziye eleman girişi
            string[] sehirler = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Şehir ismi: ");
                sehirler[i] = Console.ReadLine();
            }
            for(int j=0; j<5; j++)
            {
                Console.WriteLine(sehirler[j]);
            }
            Console.Read();        
        }
        
    }
}