namespace _260123_2_switch_case_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan kaçıncı ayda olduğu bilgisini göre ayın adı ve hangi mevsimde oldğunu hesaplayan yapıyı kodlayınız

            START:
            Console.WriteLine("Kaçıncı Aydasınız");
            byte ay=Convert.ToByte(Console.ReadLine());

            switch (ay)
            {
                case 1:
                    Console.WriteLine("Kış Mevsimi Ocak Ayı");
                    break;
                case 2:
                    Console.WriteLine("Kış Mevsimi Şubat Ayı");
                    break;
                case 3:
                    Console.WriteLine("İlkBahar Mevsimi Mart Ayı");
                    break;
                case 4:
                    Console.WriteLine("İlkBahar Mevsimi Nisan Ayı");
                    break;
                case 5:
                    Console.WriteLine("İlkBahar Mevsimi Mayıs Ayı");
                    break;
                case 6:
                    Console.WriteLine("Yaz Mevsimi Haziran Ayı");
                    break;
                case 7:
                    Console.WriteLine("Yaz Mevsimi Temmuz Ayı ");
                    break;
                case 8:
                    Console.WriteLine("Yaz Mevsimi Ağustos Ayı");
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    if (ay == 9)
                    {
                        Console.WriteLine("Sonbahar Mevsimi Eylül Ayı");
                    }
                    else if (ay == 10)
                    {
                        Console.WriteLine("Sonbahar mevsimi Ekim Ayı");
                    }
                    else if (ay == 11)
                    {
                        Console.WriteLine("Sonbahar Mevsimi Kasım Ayı");
                    }
                    else
                    {
                        Console.WriteLine("Kış Mevsimi Aralık Ayı");
                    }
                    break;
                    default:                                                                   
                    {
                        Console.WriteLine("Hatalı Ay Girişi");
                    }
                    break;


            }
            goto START;

            /* switch(ay)
             {
                 case 6:
                    Console.WriteLine("Yaz Mevsimi Haziran Ayı");
                    break;
                case 7:
                    Console.WriteLine("Yaz Mevsimi Temmuz Ayı ");
                    break;
                case 8:
                    Console.WriteLine("Yaz Mevsimi Ağustos Ayı");
                    break;
            */

             }
        }
    }
}
