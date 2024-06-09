using System;

namespace KullanıcıdanDegerAlma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fiyat Girin: ");
            double fiyat = double.Parse(Console.ReadLine());

            Console.Write("Kar oranını girin: ");
            int sayi = int.Parse(Console.ReadLine());

            double sonuc = fiyat + ((fiyat * sayi) / 100);
            Console.WriteLine("Satış Fiyatı: " + sonuc);
        }
    }
}
