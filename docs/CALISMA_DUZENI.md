# Birlikte çalışma düzeni

## Bir ders nasıl ilerler

1. Öğretmen o dersin tek ana hedefini ve gereken mantığı kısa, somut bir örnekle açıklar.
2. Öğrenci Visual Studio'da benzer bir örneği kendisi yazar, çalıştırır ve debugger ile gerekirse adım adım inceler.
3. Öğretmen çalışan kod üzerinden geri bildirim verir; önce doğru yaklaşımı ve ilk önemli hatayı belirtir.
4. Öğrenci küçük bir gereksinim değişikliğini kod üzerinde uygular ve sonucu çalıştırarak görür.
5. Yalnızca kritik bir kavramı kontrol etmek gerektiğinde bir veya iki kısa soru sorulur; ders art arda sözlü sorularla yürütülmez.
6. Öğrenci hazır çözümü körü körüne kopyalamaz. Önce mantığı görür, sonra benzer kodu kendisi yazar.
7. Çalışma doğrulanır, kısa günlük yazılır ve anlamlı değişiklik commit edilir.

Öğrenci açıkça tam çözüm isterse açıklamalı çözüm gösterilebilir. Bu durumda çalışma "yardımla tamamlandı" diye kaydedilir ve küçük bir bağımsız tekrar yapılır.

## Visual Studio ile çalışma

- Ana çalışma yüzeyi Visual Studio ve konsol projeleridir.
- `CSharpBackendLearning.sln` açılarak ders projelerine Solution Explorer üzerinden erişilir.
- Kod yazıldıktan sonra `Ctrl+S` ile kaydedilir; ardından `Ctrl+F5` ile çalıştırılır.
- Bir koşulun veya değişkenin davranışı anlaşılmadığında satıra breakpoint konur ve `F10` ile adım adım ilerlenir.
- Öğretmen örnek kodu açıklayabilir; öğrenci alıştırma kodunu kendi dosyasına kendisi yazar.

## Geçiş ölçütleri

- Kod istenen sonucu veriyor.
- Öğrenci önemli satırların görevini açıklayabiliyor.
- Küçük bir gereksinim değişikliğini uygulayabiliyor.
- O ders için belirlenen örnekleri ve sınır durumlarını kontrol ediyor.

Eksik beceriye ek alıştırma verilir. Bir konudaki eksik nedeniyle bütün haftayı baştan yapmak gerekmez.

## Git adımları

Başlangıçta Visual Studio Git Changes penceresi kullanılabilir. Ancak hangi değişikliğin commit'e girdiği anlaşılmalı.

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
