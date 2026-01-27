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
 */
 /*
 int sayi2 = 55;
 int toplam2 = 0;
 while (sayi2<= 255)
 {
     toplam2 = toplam2 + sayi2;
     Console.WriteLine(sayi2%5);
 }

 Console.WriteLine("----------------------");
 Console.WriteLine(toplam2);
 */
 int sayi3 = 500;
 while (0 <= sayi3)
 {
     Console.WriteLine(sayi3%13);
 }

 
 
 /*
 while (sayi <= 10000)
 {
     
 }
 */

            
        }
    }
}
