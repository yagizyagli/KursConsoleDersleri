namespace _260120_2_if_else_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sonuc = 10 > 5 || "Ali" == "Veli";

            //if (sonuc==true) 

            if (10 > 5 || "Ali" == "Veli")
            {
                Console.WriteLine("İşlem Doğru");
            }
            else 
            {
                Console.WriteLine("İşlem Yanlış");
            }

        //kullanıcıdan alınan bir sayının 2 basamaklı bir sayı olup olmadığını kontrol ediniz ve ekranda gösteriniz

            //10-99 arası 2 basamaklıdır

        BASLA:
            Console.WriteLine("Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi>=10 && sayi <= 99)
            {
                Console.WriteLine("2 basamaklı sayıdır: "+sayi);
            }
            else
            {
                Console.WriteLine("2 basamaklı sayı değil!!!: "+sayi);
            }
            Console.WriteLine("------------------------------------");
            goto BASLA;
            
        }
    }
}
