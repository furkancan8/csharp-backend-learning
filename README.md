# C# ve Backend Öğrenme Yolculuğu

C#, SQL ve ASP.NET Core öğrenirken yaptığım alıştırmaları, küçük projeleri ve düzeltmeleri bu depoda biriktiriyorum. Amacım, yazdığım kodu açıklayabildiğim ve hatalarını araştırabildiğim bir geliştirme pratiği kazanmak.

Bu bir öğrenme deposudur. Yol haritası, ders açıklamaları ve ilk proje iskeleti AI desteğiyle hazırlanmıştır. Alıştırmaların durumu ve alınan yardım ilerleme günlüğünde belirtilir; hazırlanan iskeletler tamamlanmış öğrenci çalışması olarak işaretlenmez.

## Başlangıç

1. Visual Studio ile `CSharpBackendLearning.sln` dosyasını aç.
2. [Yol haritasını](ROADMAP.md) ve [birlikte çalışma düzenini](docs/CALISMA_DUZENI.md) incele.
3. Solution Explorer üzerinden ders projesini seç.
4. Kısa konu anlatımından sonra örneği Visual Studio'da kendin yaz, çalıştır ve gerektiğinde breakpoint ile izle.
5. Tamamlanan [Ders 01](lessons/01-degiskenler-ve-turler.md) sonrasında [Ders 02: Koşullar](lessons/02-kosullar.md) ile devam et.
5. Kodunu çalıştır, sonucu açıkla ve [öğrenme günlüğünü](docs/OGRENME_GUNLUGU.md) doldur.

## Çalıştırma

Başlangıç projesi .NET 9 SDK ile hedeflenmiştir. Çalışılan makinede .NET 9 SDK bulunmaktadır. Kurulu sürümleri görmek için:

```powershell
dotnet --list-sdks
```

Depo klasöründe:

```powershell
dotnet run --project exercises/Ders01/Ders01.csproj
dotnet run --project exercises/Ders02/Ders02.csproj
```

Mevcut Ders 01 uygulaması, ürün adını ve hesaplanan toplam tutarı konsola yazar. `adet = 5` için 124,50 ve bağımsız tekrarda `adet = 3` için 74,70 sonuçları doğrulanmıştır.

## Depo düzeni

```text
ROADMAP.md                    Öğrenme sırası ve geçiş ölçütleri
lessons/                      Kısa dersler ve alıştırma yönergeleri
exercises/                    Öğrencinin uygulama projeleri
docs/CALISMA_DUZENI.md         Ders, geri bildirim ve Git çalışma biçimi
docs/ILERLEME.md               Doğrulanmış durum ve sonraki adım
docs/OGRENME_GUNLUGU.md        Kısa öğrenme kayıtları
```

## İlerleme

| Aşama | Durum |
| --- | --- |
| Çalışma düzeni ve başlangıç iskeleti | Hazır |
| Ders 01 - Değişkenler ve türler | Tamamlandı |
| Ders 02 - Koşullar | İlk çözüm ve ilk senaryo doğrulandı; bağımsız kontroller sürüyor |
| C# temelleri | Planlandı |
| SQL | Planlandı |
| ASP.NET Core API | Planlandı |

## Commit yaklaşımı

Her commit anlamlı bir öğrenme adımını kaydeder: ilk deneme, hata düzeltmesi, doğrulanmış alıştırma veya açıklama. Commit tarihleri ve tamamlanma durumu gerçek çalışmayı yansıtır. Küçük, anlaşılır ilerleme hedeflenir.

Kullanıcı parolaları, API anahtarları, kişisel değerlendirme raporları ve özel belgeler bu depoya eklenmez.
