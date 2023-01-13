using System;

namespace Degiskenler1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("*****Double Değişkenler*****");

            //Klavyeden Girilen Ondalıklı Sayıyı toplayan Kod Blogu
            //double sayi1,sayi2,toplam;
            //Console.Write("Sayıyı Giriniz: ");
            //sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //sayi2 = Convert.ToDouble(Console.ReadLine());
            //toplam = sayi1 + sayi2;
            //Console.WriteLine("Sayıların Toplamı: " + toplam);

            //Console.WriteLine("*****Char Değişkenler*****");

            //char degisken;
            //degisken = 'a';
            //Console.WriteLine(degisken);

            //char deger;
            //deger = '+';
            //Console.WriteLine(deger);

            //char secim;
            //Console.WriteLine("Seçiminizi Giriniz");
            //secim = Convert.ToChar(Console.ReadLine());
            //Console.Write("Seçiminiz: " + secim);

            //Console.WriteLine("*****Byte Değişkenler*****");
            //byte sayi3;
            //sayi3 = 12;
            //Console.WriteLine(sayi3);

            //Console.WriteLine("*****Float Değişkenler*****");
            ////float sayi;
            ////sayi = 256.67f;
            ////Console.WriteLine(sayi);
            //float sayi1, sayi2, toplam;
            //Console.Write("Sayı 1: ");
            //sayi1 = float.Parse(Console.ReadLine());
            //Console.Write("Sayı 2: ");
            //sayi2 = float.Parse(Console.ReadLine());
            //toplam = sayi1 + sayi2;
            //Console.WriteLine("Toplam: " + toplam);

            //Console.WriteLine("*****Değişkenlerde Min Max Value*****");

            //Console.WriteLine("Byte Max Value: " + byte.MaxValue);
            //Console.WriteLine("Byte Min Value: " + byte.MinValue);
            //Console.WriteLine("Sbyte Max Value: " + sbyte.MaxValue);
            //Console.WriteLine("Sbyte Min Value: " + sbyte.MinValue);
            //Console.WriteLine("İnt Max Value: " + int.MaxValue);
            //Console.WriteLine("İnt Min Value: " + int.MinValue);
            //Console.WriteLine("Double Min Value: " + double.MinValue);
            //Console.WriteLine("Double Max Value: " + double.MaxValue);
            //Console.WriteLine("Float Max Value: " + float.MaxValue);
            //Console.WriteLine("Float Min Value: " + float.MinValue);

            //Console.WriteLine("*****Short Değişkenler*****");
            //short s1, s2, toplam;
            //s1 = 126;
            //s2 = 236;
            //toplam = Convert.ToInt16(s1 + s2);
            //Console.WriteLine(toplam);

            //short a, b, c;
            //Console.Write("A: ");
            //a = Convert.ToInt16(Console.ReadLine());
            //Console.Write("B: ");
            //b = short.Parse(Console.ReadLine());
            //c = Convert.ToInt16(a + b);
            //Console.WriteLine(c);

            //Console.WriteLine("*****Short Değişkenler*****");

            //ushort kenar1, kenar2, alan, cevre;
            //Console.Write("Kısa Kenar: ");
            //kenar1 = ushort.Parse(Console.ReadLine());
            //Console.Write("Uzun Kenar: ");
            //kenar2 = ushort.Parse(Console.ReadLine());
            //alan = (ushort)(kenar1 * kenar2);
            //cevre = (ushort)(2 * (kenar1 + kenar2));
            //Console.WriteLine("Alanı: " + alan);
            //Console.WriteLine("Çevresi: " + cevre);

            //Console.WriteLine("*****Decimal Değişkenler*****");

            ////decimal kenar, alan, cevre;
            ////Console.Write("Kenarı Giriniz: ");
            ////kenar = decimal.Parse(Console.ReadLine());
            ////alan = kenar * kenar;
            ////cevre = kenar * 4;
            ////Console.WriteLine(alan);
            ////Console.WriteLine(cevre);
            //decimal sayi;
            //sayi=4.26m;
            //Console.Write(sayi);

            Console.WriteLine("*****Bool Değişkenler*****");

            //bool durum;
            //durum = true;
            //Console.WriteLine("Öğrenci Sınavdan Geçti mi: " + durum);
            bool uyemi;
            Console.Write("Kullanıcı Sisteme Kayıtlı Mı: ");
            uyemi = bool.Parse(Console.ReadLine());
            Console.Write("Kullanıcı Durumu: " + uyemi);

        }
    }
}
