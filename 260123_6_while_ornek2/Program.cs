namespace _260123_6_while_ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1)1-100 arasındaki sayıları ekrana yazın ve toplalarını hesaplayın
            2)55-255 arasındaki 5 in katları ekrana yazın ve toplamlarını hesaplayın
            3)500 den 0 a doğru 13 katlarını ekranda yazınız(tersten sayım olacak)
            4)1-100 arasında asal sayıların toplamını hesaplayınız(zor soru)             
             */

             /*
  1)1-100 arasındaki sayıları ekrana yazın ve toplamlarını hesaplayın
  2)55-255 arasındaki 5 in katları ekrana yazın ve toplamlarını hesaplayın
  3)500 den 0 a doğru 13 katlarını ekranda yazınız(tersten sayım olacak)
  4)1-10000 arasında asal sayıların toplamını hesaplayınız?(zor soru)
  */
 /*
 int sayi = 0;
 int toplam = 0;
 while (sayi <= 100)
 {
     toplam = toplam + sayi;
     Console.WriteLine(sayi);
     sayi++;
 }
 Console.WriteLine("-----------------");
 Console.WriteLine(toplam);
int sayi2 = 2;
//bir sayı 1 ve kendisinden başka bölüneni yoksa asaldır
int toplamAsalSayilar = 0;
while (sayi2 < 1000)
{
    int bolenSayi = 2;
    bool asalMi = true;
    while (sayi2 > bolenSayi)
    {
        if (sayi2 % bolenSayi == 0)
        {
            asalMi = false;
            break;//içinde bulunduğu döngüyü sonlandırır.sayi2>bolenSayi koşullu döngüyü sonlandırır,diğer döngüye devam eder.
        }
        bolenSayi++;
    }
    if (asalMi)
    {
        toplamAsalSayilar = toplamAsalSayilar + sayi2;
        Console.Write(sayi2 + ",");
    }
    sayi2++;
}
Console.WriteLine();
Console.WriteLine("Toplam Asal Sayılar: "+toplamAsalSayilar);


            
        }
    }
}
