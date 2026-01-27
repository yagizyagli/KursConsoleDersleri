namespace _260127_1_Super_sayi_while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kendisi hariç bölümlerin toplamı kendisini veren sayılara süper sayı denir.1-100000 arasındaki süper sayıları listeleyiniz ?
            int sayi1 = 0;                        
            while (sayi1<100000)

            {
                int bolensayi = 1;
                int toplam = 0;
                while (sayi1 > bolensayi)
                {
                    if (sayi1 % bolensayi == 0)
                    {
                        toplam = toplam + bolensayi;

                    }
                    bolensayi++;
                }
               
                if (sayi1 == toplam)
                {
                    Console.WriteLine(sayi1);
                }

                sayi1++;
            }
            
        }
    }
}
