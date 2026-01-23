namespace _260123_5_while_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            int toplam = 0;
            while (sayi <= 135)
            {
                //toplam = toplam + sayi;
                toplam += sayi;
                Console.Write(sayi+",");
                sayi++;
            }
            Console.WriteLine("Aralıktaki sayıların toplamı: "+toplam);
        }
    }
}
