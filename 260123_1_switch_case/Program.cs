namespace _260123_1_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             switch case karar yapısı sadece eşitlik durumunda çalışan bir karar yapısıdır             
             */

            int sayi = 0;
            switch (sayi)//değişken sadece tanımlanır,burda tanımlanan değişken herhangi karşılaştırma operatörü ile kullanılmaz,
                         //sadece case ler için hangi değişken  kullanılacak belirtilir
            {
                case 1://sayi değişkeni 1'e eşit olduğunda burdaki kodlar okunacaktır
                    //kod alanı
                    break;//1 için son
                    case 2:

                    break;//her bir case bir break ile sonlanır
                default://bir değer almaz,eğer case lerde verilen değer sayi değişkeninde yoksa default kısmındaki kodlar okunacaktır.
                        //if-else yapısındaki else gibi alır

                    //kodlar
                    break;//default için son
                case 47:
                    //47 için kodlar
                    break;

                    string metin = "merhaba";

                    switch (metin)
                    {
                        default:
                            break;
                        case "hello":
                        case "mer":
                        case "":
                            //1'den fazla case 1 break ile sonlanabilinir
                            break;
                        case "slav":
                            break;
                        case "hallo":
                            break;
                    }
            }
        }
    }
}
