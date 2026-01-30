namespace _260130_3_while_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[7];
            int elemanSayisi = sayilar.Count();
            int toplam = 0;
            int sayac = 0;
            while (sayac < 7)
            {
                Console.WriteLine(sayac + 1 + ".sayıyı giriniz");
                sayilar[sayac] = int.Parse(Console.ReadLine());
                toplam = toplam + sayilar[sayac];
                sayac++;
            }

            while (sayac < 7)
            {
                Console.WriteLine(sayac + 1 + ".eleman" + sayilar[sayac]);
                sayilar[sayac] = int.Parse(Console.ReadLine());
                sayac++;
            }
            Console.WriteLine("Toplam Sonuç: "+toplam);
        }
    }
}
