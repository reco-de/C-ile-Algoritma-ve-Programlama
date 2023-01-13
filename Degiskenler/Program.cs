using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****String Değişkenler****");
            String city,ilce;
            city = "Denizli";
            ilce = "Pamukkale";
            Console.WriteLine(city +"-"+ ilce );

            Console.WriteLine("****Int(integer) Değişkenler****");
            int sayi = 24;
            Console.WriteLine(sayi);

            int sayi1, sayi2, toplam;
            sayi1 = 12;
            sayi2 = 55;
            toplam = sayi1 + sayi2;           
            Console.WriteLine(toplam);        
                                              
            Console.WriteLine("****Dikdörtgen Alan Ve Çevre Hesaplama****");
            Console.Write("Kısa Kenar: ");
            int kisaKenar = int.Parse(Console.ReadLine());
            Console.Write("Uzun Kenar: ");
            int uzunKenar = int.Parse(Console.ReadLine());

            Console.WriteLine("Dörtgenin Alanı= " + (kisaKenar * uzunKenar));
            Console.WriteLine("Dörtgenin Çevresi= " + 2 * (kisaKenar + uzunKenar));

            Console.WriteLine("****Aritmetik İşlemler****");
            int s1, s2, toplam1, carpim, bolum, fark;
            s1 = 20;
            s2 = 5;
            toplam1 = s1 + s2;
            fark = s1 - s2;
            carpim = s1 * s2;
            bolum = s1 / s2;
            Console.WriteLine("Toplam: " + toplam1);
            Console.WriteLine("Fark " + fark);
            Console.WriteLine("Çarpım: " + carpim);
            Console.WriteLine("Bölüm: " + bolum);

            Console.WriteLine("*****Sınav Not Uygulaması*****");

            String ad, soyad, bolumu, ders;
            int sinav1, sinav2, sinav3, ort;
            ad = "Recep";
            soyad = "Yıldırım";
            bolumu = "Yazılım Mühendisliği";
            ders = "Algoritma Programlama";

            sinav1 = 65;
            sinav2 = 70;
            sinav3 = 88;
            ort = (sinav3 + sinav2 + sinav1) / 3;

            Console.WriteLine("****Öğrenci Bilgi Sistemi****");
            Console.WriteLine();
            Console.WriteLine("Öğrencinin Adı Soyadı: " + ad + " " + soyad);
            Console.WriteLine("Öğrencinin Bölümü:" + " " + bolumu);
            Console.WriteLine("Sınava Girilen Ders: " + ders);
            Console.WriteLine("Sınav 1: " + sinav1);
            Console.WriteLine("Sınav 2: " + sinav2);
            Console.WriteLine("Sınav 3: " + sinav3);
            Console.WriteLine("Ders Ortalaması: " + ort);

        }
    }
}
