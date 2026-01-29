namespace _260129_3_for_ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adetsayisi = 0, toplam = 0;
            for (int i = 1; i <= 15000; i++) 
            {
                if(i%5==0 && !(i % 2 == 0))
                {

                    toplam = toplam + i;
                    adetsayisi++;
                }
            }
            Console.WriteLine("5'in katı 2'nin değili adet sayısı: " + adetsayisi);
            Console.WriteLine("5 in katı 2'nin değili toplamları: " + toplam);
        }
    }
}
