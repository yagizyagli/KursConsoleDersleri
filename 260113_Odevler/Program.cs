namespace _260113_Odevler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*kullanıcıdan alınan 4 sayı için aşağıdaki işlemlerin sonuçlarını ekrana yazdıran bir program yazınız
            * 1-4 sayının toplamı
            * 2- 1. ve 2. sayının çarpımını 4 sayıyı bölmek
            * 3- 1. ve 2. sayıların toplam sonucu ,3. sayıdan 4.sayının çıkartılması sonucuna bölüm sonucu
            * 4- 4.sayıya diğer 3 sayının toplamının bölünmesi
            * 5-
            */
             Console.WriteLine("1 sayıyı giriniz");
             int sayi1=int.Parse(Console.ReadLine());


             Console.WriteLine("2 sayıyı giriniz");
             int sayi2 = int.Parse(Console.ReadLine());


             Console.WriteLine("3 sayıyı giriniz");
             int sayi3 = int.Parse(Console.ReadLine());


            Console.WriteLine("4 sayıyı giriniz");
            int sayi4 = int.Parse(Console.ReadLine());

         int toplam=(int)(sayi1+sayi2+sayi3+sayi4);
         double carpTopla = (double)(sayi1 * sayi2 / toplam);
         int toplam2 = (int)(sayi1 + sayi2);
         int cıkart = (int)(sayi3 - sayi4);
         double sonuc1 = (double)(toplam / cıkart);
         int toplam3 = (int)(sayi1 + sayi2 + sayi3);
         double Bol = (double)(toplam3 / sayi4);
         double carp2 = (double)(sayi1 * sayi2 * sayi3 / sayi4);

         Console.WriteLine("1. cevap:"+toplam);
         Console.WriteLine("2.cevap:"+carpTopla);
         Console.WriteLine("3.cevap:"+sonuc1);
         Console.WriteLine("4. cevap:"+Bol);
         Console.WriteLine("5. cevap:"+carp2);
           
        }
    }
}
