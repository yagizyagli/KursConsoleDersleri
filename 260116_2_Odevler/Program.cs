namespace _260116_2_Odevler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ödevler
            /*  - Kullanıcıdan alınan 5 sayı için aşağıdaki işlemleri yapı ve sonuçları ekranda gösteriniz
             * 
             * 1- 5 sayıdan 2 nin katı olanlar true, olmayan için false verecek şeklinde bir işlem düşünüp kodlayınız
             * 2- 1.sayıdan 5.sayıya kadar olan sayıların toplamını bulunuz
             * 3- 1.sayıya 5 ekleyin,2.sayıdan -10 çıkartın, 3.sayıy da 5 ile çarparak işlemlerin sonucunu ekranda gösteriniz? 
             * NOT:yeni bir değişken tanımlanmadan yapılacak
             * 4- 5 sayının toplam sonucu 9,11,13 e ayrı aayrı bölündüğünü true,false şeklinde hesaplayınız
             * 5- 1.,2.,3. sayıların toplamı,4.sayıdan 5.sayıya çıkartılınca kalan sonuca bölerek sonucu ekranda gösteriniz
             */



            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3.Sayı:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("4.Sayı:");
            int sayi4 = int.Parse(Console.ReadLine());

            Console.WriteLine("5.Sayı");
            int sayi5 = int.Parse(Console.ReadLine());


            //1.Sorunun Cevabı
            bool sonuc1;
            //sayi1 %= 2;
            //sayi1 = sayi1 % 2;
            sonuc1 = Convert.ToBoolean(sayi1 % 2);//
            //sonuc1 = Convert.ToBoolean(sayi1);
            //Console.WriteLine("1.Soru 1.Cevap: " + sonuc1);
            //kısa yol
            Console.WriteLine("1.Soru 1.Cevap: " + (sayi1 % 2 == 0));

            sayi2 %= 2;
            sonuc1 = Convert.ToBoolean(sayi2);
            Console.WriteLine("1.Soru 2.Cevap: " + sonuc1);

            sayi3 %= 2;
            sonuc1 = Convert.ToBoolean(sayi3);
            Console.WriteLine("1.Soru 3.Cevap: " + sonuc1);

            sayi4 %= 2;
            sonuc1 = Convert.ToBoolean(sayi4);
            Console.WriteLine("1.Soru 4.Cevap: " + sonuc1);

            sayi5 %= 2;
            sonuc1 = Convert.ToBoolean(sayi5);
            Console.WriteLine("1.Soru 5.Cevap: " + sonuc1);





            //2.Sorunun Cevabı
            int toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;
            Console.WriteLine("2.Sorunun Cevabı: " + toplam);


            //3.Sorunun Cevabı
            sayi1 += 5;
            sayi2 -= 10;
            sayi3 *= 5;
            Console.WriteLine("3.Soru 1.Cevap: " + sayi1);
            Console.WriteLine("3.Soru 2.Cevap: " + sayi2);
            Console.WriteLine("3.Soru 3.Cevap: " + sayi3);


            //4.Sorunun Cevabı
            bool sonuc2;
            int ToplaBol = toplam / 9;
            int ToplaBol2 = toplam / 11;
            int ToplaBol3 = toplam / 13;
            //sonuc2 = Convert.ToBoolean(ToplaBol);
            //sonuc2 = Convert.ToBoolean(ToplaBol2);
            //sonuc2 = Convert.ToBoolean(ToplaBol3);
            //Console.WriteLine("4.Soru 1.Cevap: " + sonuc2);
            //Console.WriteLine("4.Soru 2.Cevap: " + sonuc2);
            //Console.WriteLine("4.Soru 3.Cevap: " + sonuc2);

            sonuc2 = Convert.ToBoolean(ToplaBol);
            Console.WriteLine("4.Soru 2.Cevap: " + sonuc2);
            sonuc2 = Convert.ToBoolean(ToplaBol2);
            Console.WriteLine("4.Soru 1.Cevap: " + sonuc2);
            sonuc2 = Convert.ToBoolean(ToplaBol3);
            Console.WriteLine("4.Soru 3.Cevap: " + sonuc2);


            //5.Sorunun Cevabı
            int toplam2 = sayi1 + sayi2 + sayi3;
            int cikart = sayi4 - sayi5;
            double toplaCikartBol = (double)(toplam2 / cikart);
            Console.WriteLine("5.Sorunun Cevabı: " + toplaCikartBol);
        }
    }
}
