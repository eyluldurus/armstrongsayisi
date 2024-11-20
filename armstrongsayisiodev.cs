// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0, girilenSayi = sayi;

        while (sayi > 0)
        {
            int basamak = sayi % 10;
            toplam += basamak * basamak * basamak;
            sayi /= 10;
        }

        if (toplam == girilenSayi)
            Console.WriteLine($"{girilenSayi} bir Armstrong sayısıdır.");
        else
            Console.WriteLine($"{girilenSayi} bir Armstrong sayısı değildir.");
    }
}

