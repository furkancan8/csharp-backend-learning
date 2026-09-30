# Birlikte çalışma düzeni

## Bir ders nasıl ilerler

1. Öğretmen o dersin tek ana hedefini açıklar.
2. Kısa bir konu anlatımı ve alıştırmadan farklı küçük bir örnek verir.
3. Öğrenci örneğin çıktısını tahmin eder, sonra kendi alıştırmasını yazar.
4. Öğrenci kodu ve beklediği sonucu paylaşır. Hata varsa tam hata mesajı da paylaşılır.
5. Öğretmen önce doğru yaklaşımı ve ilk önemli hatayı belirtir; çözümün tamamını hemen yazmaz.
6. Öğrenci ipucu yardımıyla düzeltir. Ardından benzer bir görevi daha az yardımla yapar.
7. Çalışma doğrulanır, kısa günlük yazılır ve anlamlı değişiklik commit edilir.

Öğrenci açıkça tam çözüm isterse açıklamalı çözüm gösterilebilir. Bu durumda çalışma "yardımla tamamlandı" diye kaydedilir ve küçük bir bağımsız tekrar yapılır.

## Geçiş ölçütleri

- Kod istenen sonucu veriyor.
- Öğrenci önemli satırların görevini açıklayabiliyor.
- Küçük bir gereksinim değişikliğini uygulayabiliyor.
- O ders için belirlenen örnekleri ve sınır durumlarını kontrol ediyor.

Eksik beceriye ek alıştırma verilir. Bir konudaki eksik nedeniyle bütün haftayı baştan yapmak gerekmez.

## Git adımları

Başlangıçta VS Code Source Control arayüzü kullanılabilir. Ama hangi değişikliğin commit'e girdiği anlaşılmalı.

```powershell
git status
git diff
git add exercises/Ders01/Program.cs
git diff --cached
git commit -m "ders-01: fiyat hesaplama alistirmasini tamamla"
git push
```

Bu yalnızca örnek bir akıştır; commit mesajı çalışmanın gerçek durumuna göre seçilir. Günlük de değişmişse o dosya ayrıca incelenip stage edilir. Başka staged dosya olmadığını kontrol et.

Örnek mesajlar:

- `chore: ogrenme duzenini ve ilk ders iskeletini ekle`
- `ders-01: fiyat hesaplamasinin ilk denemesini ekle`
- `ders-01: decimal turundeki derleme hatasini duzelt`
- `ders-01: yeni degerlerle sonucu dogrula`

Öğrencinin ilk denemesi, tamamlanmış ve doğrulanmış bir özellik gibi adlandırılmaz. Sırf katkı grafiğini doldurmak için boş commit veya geriye dönük tarih kullanılmaz.

## Sonraki oturuma başlama

"Ders 01'e devam edelim" diyerek veya son kodu paylaşarak başlanabilir. Önce `docs/ILERLEME.md`, son günlük kaydı ve son commit incelenir. Böylece hangi görevde kaldığımız somut dosyalardan takip edilir.

Bu düzen arka planda kendiliğinden çalışma veya otomatik günlük commit oluşturmaz. Her ilerleme, yapılan ve incelenen çalışmaya dayanır.
