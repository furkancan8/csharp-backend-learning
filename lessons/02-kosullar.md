# Ders 02 - Koşullar

Süre: 60-90 dakika. Hedef: Programın bir kurala göre farklı yollardan yalnızca birini çalıştırmasını sağlamak.

## 1. Karşılaştırmanın sonucu bool olur

```csharp
decimal bakiye = 750m;
bool yeterliMi = bakiye >= 500m;
```

`bakiye >= 500m` ifadesinin sonucu `true` veya `false` olur. Burada sonuç `true` değeridir.

Temel karşılaştırma işleçleri:

| İşleç | Anlamı |
| --- | --- |
| `==` | Eşit mi? |
| `!=` | Eşit değil mi? |
| `>` | Büyük mü? |
| `<` | Küçük mü? |
| `>=` | Büyük veya eşit mi? |
| `<=` | Küçük veya eşit mi? |

Atama için `=`, eşitlik karşılaştırması için `==` kullanılır.

## 2. if, else if ve else

```csharp
int sicaklik = 18;
bool yagmurVar = true;

if (sicaklik < 10)
{
    Console.WriteLine("Kalın mont al.");
}
else if (yagmurVar)
{
    Console.WriteLine("Şemsiye al.");
}
else
{
    Console.WriteLine("Hava uygun.");
}
```

Program koşulları yukarıdan aşağıya kontrol eder. İlk `true` olan bölüm çalışır; aynı zincirdeki sonraki bölümler artık kontrol edilmez.

**Önce çalıştırmadan cevapla:** Bu örnekte hangi mesaj yazılır? `sicaklik` değerini 8 yaparsak hangi mesaj yazılır? Neden iki mesaj birden yazılmaz?

## 3. Mantıksal işleçler

| İşleç | Anlamı | Örnek |
| --- | --- | --- |
| `&&` | İki koşul da doğru olmalı | `uyeMi && tutar >= 300m` |
| `||` | Koşullardan en az biri doğru olmalı | `haftaSonuMu || tatilMi` |
| `!` | bool değerini tersine çevirir | `!iptalMi` |

`&` ile `&&` aynı şey değildir. Bool koşullarında genellikle `&&` kullanılır; sol taraf `false` ise sağ tarafın değerlendirilmesine gerek kalmaz.

## 4. Senin alıştırman: kargo ücreti

`exercises/Ders02/Program.cs` dosyasında şu başlangıç değerlerini kullan:

```csharp
decimal sepetTutari = 480m;
bool premiumMusteri = true;
```

Kurallar sırayla şunlar:

1. Sepet tutarı 500 TL veya daha fazlaysa kargo ücretsizdir: `0m`.
2. İlk kural sağlanmıyorsa, müşteri premium **ve** sepet tutarı en az 300 TL ise kargo: `19.90m`.
3. Diğer bütün durumlarda kargo: `49.90m`.
4. `odenecekToplam`, sepet tutarı ile kargo ücretinin toplamıdır.
5. Kargo ücretini ve ödenecek toplamı konsola yazdır.

İlk değerlerde beklenen kargo 19,90 TL, ödenecek toplam 499,90 TL'dir.

Çözümün çalıştıktan sonra iki kontrol yapacağız:

- `sepetTutari = 550m`, `premiumMusteri = false`: beklenen kargo `0`.
- `sepetTutari = 250m`, `premiumMusteri = true`: beklenen kargo `49,90`.

## 5. Kontrol için paylaş

- Sıcaklık örneğinin iki tahmini ve gerekçesi.
- Yazdığın `Program.cs` kodu.
- İlk değerlerle gördüğün çıktı.
- Hangi koşulun neden çalıştığının kısa açıklaması.

Tam çözüm bu dosyada verilmez. Önce kendi denemen üzerinden geri bildirim yapılır.
