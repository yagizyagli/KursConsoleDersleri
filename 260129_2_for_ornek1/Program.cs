using System;

namespace _260129_2_for_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adet11 = 0,adet13 = 0 ,toplam11 = 0 , toplam13 = 0;
            for (int i = 50; i <= 5000; i++) 
            {
                
                if (i%11==0)
                {
                    Console.WriteLine(i);
                    toplam11 = toplam11 + i;
                   
                    adet11++;
                }
                if (i % 13 == 0)
                {
                    Console.WriteLine(i);
                    toplam13 = toplam13 + i;                    
                    adet13++;

                }                            
            }
            Console.WriteLine("11'in katlar toplamı: " +adet11+toplam11);
            Console.WriteLine("13'in katlar toplamı: " +adet13+ toplam13);
        }
    }
}
