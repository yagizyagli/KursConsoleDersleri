namespace _260130_2_dizi_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar=new int[7];
            int elemanSayisi = sayilar.Count();
            int toplam = 0;
            for(int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine(i + 1 + ".sayıyı giriniz");
                sayilar[i] = int.Parse(Console.ReadLine());
                toplam = toplam + sayilar[i];

            }
            for(int i = 0;i < elemanSayisi; i++)
            {
                Console.WriteLine(i + 1 + ".eleman:" + sayilar[i]);
              
            }
            Console.WriteLine(toplam);


            



        }
    }
}
