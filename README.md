# C# ve Backend Öğrenme Yolculuğu

C#, SQL ve ASP.NET Core öğrenirken yaptığım alıştırmaları, küçük projeleri ve düzeltmeleri bu depoda biriktiriyorum. Amacım, yazdığım kodu açıklayabildiğim ve hatalarını araştırabildiğim bir geliştirme pratiği kazanmak.

Bu bir öğrenme deposudur. Yol haritası, ders açıklamaları ve ilk proje iskeleti AI desteğiyle hazırlanmıştır. Alıştırmaların durumu ve alınan yardım ilerleme günlüğünde belirtilir; hazırlanan iskeletler tamamlanmış öğrenci çalışması olarak işaretlenmez.

## Başlangıç

1. [Yol haritasını](ROADMAP.md) oku.
2. [Birlikte çalışma düzenine](docs/CALISMA_DUZENI.md) bak.
3. [Ders 01: Değişkenler ve türler](lessons/01-degiskenler-ve-turler.md) ile başla.
4. `exercises/Ders01/Program.cs` dosyasındaki görevi kendin tamamla.
5. Kodunu çalıştır, sonucu açıkla ve [öğrenme günlüğünü](docs/OGRENME_GUNLUGU.md) doldur.

## Çalıştırma

Başlangıç projesi .NET 9 SDK ile hedeflenmiştir. Çalışılan makinede .NET 9 SDK bulunmaktadır. Kurulu sürümleri görmek için:

```powershell
dotnet --list-sdks
```

Depo klasöründe:

```powershell
dotnet run --project exercises/Ders01/Ders01.csproj
```

Mevcut Ders 01 uygulaması, ürün adını ve hesaplanan toplam tutarı konsola yazar. Doğrulanan örnekte `adet = 5` ve `birimFiyat = 24.90M` için toplam 124,50'dir.

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
| Ders 01 - Değişkenler ve türler | İlk uygulama çalıştı; bağımsız tekrar sürüyor |
| C# temelleri | Planlandı |
| SQL | Planlandı |
| ASP.NET Core API | Planlandı |

## Commit yaklaşımı

Her commit anlamlı bir öğrenme adımını kaydeder: ilk deneme, hata düzeltmesi, doğrulanmış alıştırma veya açıklama. Commit tarihleri ve tamamlanma durumu gerçek çalışmayı yansıtır. Küçük, anlaşılır ilerleme hedeflenir.

Kullanıcı parolaları, API anahtarları, kişisel değerlendirme raporları ve özel belgeler bu depoya eklenmez.
