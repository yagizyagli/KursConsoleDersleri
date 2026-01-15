namespace _260113_4_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int deger1=int.Parse(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int deger2 = Convert.ToInt32(Console.ReadLine());
            int toplam1 = deger1 + deger2;

            Console.WriteLine("3.sayıyı giriniz:");
            int deger3 = int.Parse(Console.ReadLine());
            int toplam2 = deger1 + deger3;
            int toplam3=deger2 + deger3;
            double bolum1 = (double) deger1 / deger2;
            int cıkarma1 = deger1 - deger3;
            double toplaBol = (double) (deger2 + deger3) / deger1;
            double carpimBol = (double)(deger1 * deger2 )/ deger3;


            Console.WriteLine("1 ve 2 toplam:"+toplam1);
            Console.WriteLine("1 ve 3 toplam:" +toplam2);
            Console.WriteLine("2 ve 3 toplam:" +toplam3);
            Console.WriteLine("1 ve 2 Bölme:" + bolum1);
            Console.WriteLine("1 ve 3 Çıkartılması:" +cıkarma1);
            Console.WriteLine("2 ve 3 toplamının 1.sayıya bölümü:" + toplaBol);
            Console.WriteLine("1 ve 2 sayılarının çarpımının bölümü:"+carpimBol);
        }
    }
}
