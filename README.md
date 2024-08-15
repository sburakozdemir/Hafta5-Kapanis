# Araba Üretim Programı

Bu proje, basit bir araba üretim simülasyonu gerçekleştiren C# konsol uygulamasıdır. Kullanıcılar, program aracılığıyla sanal arabalar üretebilir ve bu arabaların özelliklerini belirleyebilirler.

## Özellikler

- Kullanıcı tarafından belirlenen özelliklere sahip araba nesneleri oluşturma
- Oluşturulan arabaları bir listede saklama
- Hatalı girişlere karşı basit hata yönetimi
- Üretilen arabaların özetini görüntüleme

## Gereksinimler

- .NET Framework veya .NET Core (proje sürümünüze bağlı olarak)
- Bir C# derleyicisi (örneğin, Visual Studio, Visual Studio Code + C# eklentisi, veya JetBrains Rider)

## Kurulum

1. Bu repository'yi klonlayın:
   ```
   git clone https://github.com/kullaniciadi/araba-uretim-programi.git
   ```
2. Proje dizinine gidin:
   ```
   cd araba-uretim-programi
   ```
3. Projeyi derleyin ve çalıştırın:
   ```
   dotnet run
   ```

## Kullanım

1. Program başlatıldığında, araba üretmek isteyip istemediğiniz sorulacaktır.
2. "e" (evet) yanıtı verirseniz, sırasıyla arabanın özelliklerini girmeniz istenecektir:
   - Seri numarası
   - Marka
   - Model
   - Renk
   - Kapı sayısı
3. Tüm özellikleri girdikten sonra, araba listeye eklenir ve yeni bir araba üretmek isteyip istemediğiniz tekrar sorulur.
4. "h" (hayır) yanıtı verdiğinizde, program sonlanır ve üretilen tüm arabaların bir listesi görüntülenir.
