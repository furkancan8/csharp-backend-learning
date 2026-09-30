# Ders 01 - Değişkenler ve türler

Süre: 45-60 dakikalık ilk oturum. Hedef: Birkaç değişken tanımlamak, basit hesap yapmak ve sonucu açıklamak.

## 1. Değişken nedir

Değişken, program içinde bir değere ad vermemizi sağlar. Örneğin:

```csharp
int ogrenciSayisi = 12;
```

- `int`: Tam sayı türü.
- `ogrenciSayisi`: Değişkenin adı.
- `=`: Sağdaki değeri soldaki değişkene atar. Eşitlik karşılaştırması değildir.
- `12`: Değer.
- `;`: Bu ifadenin sonu.

Bugün dört türle tanışacağız:

| Tür | Örnek | Ne için |
| --- | --- | --- |
| int | `int yas = 25;` | Tam sayılar |
| decimal | `decimal uzunluk = 2.5m;` | Ondalık değerler; para hesaplarında sık kullanılır |
| string | `string sehir = "Manisa";` | Metin |
| bool | `bool acikMi = true;` | true veya false |

`2.5m` sonundaki `m`, sayının decimal olduğunu belirtir. C# kaynak kodunda ondalık ayırıcı noktadır. Ekrana yazdırmada bilgisayarın bölgesel ayarına göre virgül görünebilir.

## 2. Program yukarıdan aşağıya ilerler

```csharp
int kutuSayisi = 4;
int kutudakiKalem = 6;
int toplamKalem = kutuSayisi * kutudakiKalem;

kutuSayisi = 5;
Console.WriteLine(toplamKalem);
```

**Önce çalıştırmadan cevapla:** Ekranda hangi sayı görünür? Sonradan kutuSayisi değişince toplamKalem kendiliğinden yeniden hesaplanır mı? Neden?

`Console.WriteLine`, verilen değeri konsola yazdırır. `*` çarpma işlemini yapar. Tahminini paylaştıktan sonra örneği ayrı bir denemede çalıştırabilirsin.

## 3. Senin alıştırman

`exercises/Ders01/Program.cs` dosyasını aç. Bir ürünün toplam fiyatını hesaplayan küçük program yaz.

İstenenler:

1. `urunAdi` adlı string değişkenine `Defter` değerini ver.
2. `adet` adlı int değişkenine `3` değerini ver.
3. `birimFiyat` adlı decimal değişkenine `24.90` değerini ver.
4. `toplamTutar` adlı decimal değişkeninde adet ile birim fiyatı çarp.
5. Ürün adını ve toplam tutarı konsola yazdır.

İlk beklenen toplam: **74.70**. Ardından adedi 5 yapıp tekrar çalıştır: **124.50**. Ekranda `74,70` veya `124,50` görmen de bölgesel ayara bağlı olarak normaldir.

Bugün kullanıcıdan veri almak, döngü, if veya sınıf eklemek gerekmiyor. Önce bu küçük hesabı anlayarak tamamla.

## 4. Çalıştır

Depo klasöründe bir terminal aç:

```powershell
dotnet run --project exercises/Ders01/Ders01.csproj
```

Programda derleme hatası olursa hata mesajını kaydet. Önce hangi satırı gösterdiğine bak; sonra kodunla birlikte paylaş.

## 5. Kontrol için paylaş

- Kutu/kalem örneğinin tahmini çıktısı ve gerekçesi.
- Yazdığın Program.cs kodu.
- Adet 3 ve adet 5 için gördüğün sonuç.
- `int` ve `decimal` seçiminin nedeni.
- Yardım alıp almadığın ve takıldığın nokta.

Tam çözüm bu dosyada verilmez. Önce kendi denemen üzerinden geri bildirim yapılır. Ders sonunda ilerleme ve günlük kaydı birlikte güncellenir.
