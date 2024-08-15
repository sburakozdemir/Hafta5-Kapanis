using Hafta5_Kapanis;
using System;
using System.Collections.Generic;

// Üretilen arabaları tutacak liste
List<Araba> arabalar = new List<Araba>();

while (true)
{
uretim:
    Console.WriteLine("Araba üretmek ister misiniz? (e: Evet, h: Hayır)");
    string secim = Console.ReadLine().ToLower();

    if (secim == "h")
    {
        Console.WriteLine("Araba üretimi sonlandırılıyor...");
        break; // Programdan çıkış
    }
    else if (secim == "e")
    {
        Araba araba = new Araba(); // Yeni bir araba nesnesi oluştur

        Console.Write("Lütfen arabanın seri numarasını giriniz: ");
        araba.SeriNumarası = Console.ReadLine();

        Console.Write("Lütfen arabanın markasını giriniz: ");
        araba.Marka = Console.ReadLine();

        Console.Write("Lütfen arabanın modelini giriniz: ");
        araba.Model = Console.ReadLine();

        Console.Write("Lütfen arabanın rengini giriniz: ");
        araba.Renk = Console.ReadLine();

    kapi:
        try
        {
            Console.Write("Lütfen arabanın kapı sayısını giriniz (sayısal değer): ");
            araba.KapiSayisi = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hatalı giriş! Lütfen kapı sayısı için sadece sayısal değer giriniz.");
            goto kapi; // Kapı sayısı girişine geri dön
        }

        arabalar.Add(araba); // Yeni arabayı listeye ekle
        Console.WriteLine("Araba başarıyla üretildi ve listeye eklendi.");
    }
    else
    {
        Console.WriteLine("Hatalı giriş yaptınız. Lütfen 'e' veya 'h' giriniz.");
        goto uretim; // Üretim sorusuna geri dön
    }
}

// Üretilen arabaların listesini göster
Console.WriteLine("\nÜretilen Arabaların Listesi:");
foreach (var item in arabalar)
{
    Console.WriteLine($"Seri Numarası: {item.SeriNumarası}, Markası: {item.Marka}");
}