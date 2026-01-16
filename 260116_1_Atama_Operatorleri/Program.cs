namespace _260116_1_Atama_Operatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             += topla ve eşitle 
             -= çıkart ve eşitle
             *= çarp ve eşitle
             /= böl ve eşitle
             %= mod al ve eşitle
             ++ 1 arttır
            -- 1 azalt
            + string olarak  birleştir
             */

            int sayi1 = 900;
            //kodun içinde herhangi bir yerde sayi1 e yeni değer eklenmesi gerekiyor

            //sayi yeniSayi1 olarak devam edecek
            //int yeniSayi1=sayi1+10; //bunun yerine aşağıdaki gibi atama işlemi yapılarak yeni değişken tanımlanması yapılmaz,
            //sayi1 değişkeni yeni aldığı değer üzerinden işlem görmesini sağlayacaktır
           
            
           
            
            //sayi1 = sayi1 + 10;
            sayi1+= 10;

            //kod ilerledi, sayi1 için yeni bir bir işlem gerekli oldu ,örneğin %20 artırılmak istendi

            //int yeniSayi2=yeniSayi1+yeniSayi1*20/100;
            //sayi1 artık yeniSayi2 olarak devam edecek
            //sayi1 = sayi1 + sayi1 * 20 / 100;
            sayi1 += sayi1 * 20 / 100;
            //******************************************
            int sayi2 = 100; //değerini 5 ilr çarpalım
            //sayi2 = sayi2 * 5;
            sayi2 *= 5;
            


            Console.WriteLine("sayi2=100,sayi2 değeri 5 ile çarptık:"+sayi2);

            int sayi3 = 450;
            //sayi3 9 ile bölündüğünde sonucunu atama operatörü ile yazalım

            sayi3 /= 9;
            Console.WriteLine("450 değerinin 9 ile bölümü:"+sayi3);

            int sayi4 = 845;
            //sayi4 değerinin 9 ile bölünmesinden kalanı atama operatörü ile yazalım
            sayi4 %= 9;
            Console.WriteLine("845 in 9 ile bölümünden Mod alması:"+sayi4);

            /* 
             * ++
             * --
             * +
             * operatörlerinin kullanılması
             */

            int deger1 = 10;
            deger1++;//deger1 in değerini 1 arttırır
            Console.WriteLine("deger1=10 değeri ++ ile arttırıldı:"+deger1);
            deger1 += 1;//deger ++ ile aynıdır
            Console.WriteLine("deger1=10 +=1 ile arttırıldı:"+deger1);
            int deger2 = ++deger1;//deger1 in değeri 1 arttırılır ve deger2 ye atanır
            Console.WriteLine("++deger1:"+deger2);
            // int deger3=deger2++ + 10 //ilkin deger2 değeri deger3  e eşitlenir sonra ++ işlemi deger2 ye uygulanır
            int deger3=++deger2 + 10;//deger2 nin değeri 1 arttırılır ve 10 ile toplanarak deger3 e atanır. diğer artımı yaparak eşitleme yapılır
            Console.WriteLine("++deger1:"+deger3);



            



        }
    }
}
