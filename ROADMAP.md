# Öğrenme yol haritası

Hedef: C# ile küçük problemleri çözmek, SQL ile veri sorgulamak ve ASP.NET Core ile veritabanına bağlı bir API geliştirmek.

Sekiz hafta bir başlangıç çerçevesidir. Haftalar, uygulama kontrollerine göre uzayabilir. Konu izlemek veya dosya oluşturmak, becerinin tamamlandığı anlamına gelmez.

## Aşamalar

| Hafta | Konular | Üretilecek çalışma | Geçiş ölçütü |
| --- | --- | --- | --- |
| 1 | Değişken, tür, işleç, koşul, döngü, List, metot ve return; temel Git | Küçük konsol alıştırmaları | Koşullu toplamı yazıp boş ve karışık listelerde açıklayabilmek |
| 2 | Sınıf, nesne, referans, null, giriş doğrulama, exception ve debugger | Sipariş hesaplama konsolu | Bozuk akışı bulup düzeltmek ve veriyi doğru nesneden okumak |
| 3 | Koleksiyonlar, LINQ, küçük metotlar, interface ve temel test | Sipariş konsolunun geliştirilmiş sürümü | Döngü ile LINQ çözümünü karşılaştırmak; sınır durumlarını test etmek |
| 4 | SELECT, WHERE, JOIN, GROUP BY, INSERT, UPDATE, DELETE | Müşteri ve sipariş sorguları | Siparişsiz müşteriyi koruyan toplam sorgusunu yazmak |
| 5 | HTTP, JSON, routing, controller, doğrulama, durum kodları | Bellekte çalışan müşteri ve sipariş API'si | Başarılı, hatalı ve bulunamayan kayıt isteklerini göstermek |
| 6 | EF Core, SQL Server, migration, temel DI, async/await | Veritabanına bağlı API | Bir isteğin veritabanına gidişini ve dönüşünü açıklamak |
| 7 | Hata yanıtları, loglama, testler ve dokümantasyon | Tekrar kurulabilen ve test edilen API | Hata üretip nedenini bulmak; kurulum adımlarını doğrulamak |
| 8 | Bağımsız özellik, yeni seviye kontrolü, proje anlatımı | Filtreleme özelliği ve kısa proje demosu | Yeni bir gereksinimi uygulamak ve kararlarını anlatmak |

Frontend ve ticari ürün geliştirme, bu rotanın ilk aşamasında kapsam dışındadır. Interface, gerektiği yerde öğrenilir; her sınıfa interface ekleme şartı yoktur.

## İlk haftanın ders sırası

1. **Değişkenler ve türler:** int, decimal, string, bool; atama ve çıktı.
2. **Koşullar:** if/else, karşılaştırma ve mantıksal işleçler.
3. **Döngüler:** for ve foreach; başlangıç, devam koşulu ve artış.
4. **Listeler ve metotlar:** Count, indeks, parametre ve return.
5. **Hata ayıklama ve Git:** breakpoint, ara çıktı, değişiklik inceleme ve seçerek commit.
6. **Uygulama kontrolü:** yeni problem, küçük değişiklik ve hata düzeltme.
7. **Dinlenme.**

## Günlük zaman

| Çalışma | Süre |
| --- | --- |
| Önceki konuyu hatırlama | 20 dakika |
| Yeni konu ve kısa örnek | 50 dakika |
| Alıştırmalar | 90 dakika; iki ayrı blok |
| Küçük uygulama | 70 dakika |
| Hata ayıklama ve kontrol | 40 dakika |
| Günlük, kod inceleme ve Git | 30 dakika |

Toplam 5 saat net çalışma; yaklaşık 45 dakika mola ile 5 saat 45 dakika. Haftada altı çalışma günü planlanır. İlk dersin tek oturumu 45-60 dakikadır; günün tamamını kesintisiz yeni konuya ayırmak gerekmez.

## Kaynaklar

- [Microsoft Learn C# başlangıç](https://learn.microsoft.com/tr-tr/training/paths/get-started-c-sharp-part-1/)
- [Microsoft Learn Transact-SQL](https://learn.microsoft.com/tr-tr/training/paths/get-started-querying-with-transact-sql/)
- [Microsoft Learn ASP.NET Core Web API](https://learn.microsoft.com/tr-tr/training/modules/build-web-api-aspnet-core/)
- [Türkçe Pro Git](https://git-scm.com/book/tr/v2.html)

Kaynaklar ihtiyaç oldukça kullanılacak. Öğrenme sırası ve uygulamalar bu depodan takip edilecek.
