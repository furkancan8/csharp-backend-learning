// Ders 02: Koşullar
// Yönerge: lessons/02-kosullar.md
// Alıştırmanın çözümünü aşağıya kendin yaz.

decimal sepetTutar=480m;
bool premiumMusteri=true;
decimal kargoUcreti=0m;
decimal OdenecekTutar=0m;
if(sepetTutar >= 500m)
{
    kargoUcreti=0m;
} else if(premiumMusteri && sepetTutar>=300m)
{
    kargoUcreti=19.90m;
}else{kargoUcreti=49.90m;}

OdenecekTutar=sepetTutar+kargoUcreti;

Console.WriteLine($"Odenecek Tutar = {OdenecekTutar},Kargo Ucreti = {kargoUcreti}");
