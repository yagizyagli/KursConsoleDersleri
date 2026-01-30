namespace _260130_5_dizi_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar=new int[11];
            int sayilar2 = sayilar.Length;
          
            for(int i=0; i<sayilar2; i++)
            {
                Console.WriteLine(i+1+".sayıyı giriniz:");
                sayilar[i]=int.Parse(Console.ReadLine());
              

            }
            for (int i = 0; i < sayilar2; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    Console.WriteLine("Çift: " + sayilar[i]);
                }
                else
                {
                    Console.WriteLine("Tek: " + sayilar[i]);
                }

                //string yaz=sayilar[i]%2==0 ? "--Çift":"--Tek"
                //Console.WriteLine(sayilar[i]+yaz);
            }

        }
    }
}
