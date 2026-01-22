namespace _260122_HocaninYaptigi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        DESTPEK:
            double maas = 0, ikramiye = 0;
            string cinsiyet = string.Empty;
            byte yas = 0;

            Console.WriteLine("Cinsiyet giriniz \n kadın için =>kadın,bayan ya da  k\n Erkek için erkek,bay ya da e");
            cinsiyet = Console.ReadLine().ToLower();

            if(cinsiyet=="kadın" || cinsiyet=="bayan" || cinsiyet == "k")
            {
                Console.WriteLine("Yaşınızı giriniz");
                yas=Convert.ToByte(Console.ReadLine());
                if (yas >= 60)
                {
                    Console.WriteLine("Maaşınızı giriniz:");
                    maas=double.Parse(Console.ReadLine());
                    ikramiye = maas * 13;
                    Console.WriteLine("Emekli olabilirsiniz ikramiyeniz: "+ikramiye);

                }
                else
                {
                    Console.WriteLine("Yaşınız emeklilik için yeterli değildir");
                }
            else if(cinsiyet=="erkek" || cinsiyet="bay" || cinsiyet == "e")
                {
                    Console.WriteLine("Yaşınızı giriniz");
                    yas = Convert.ToByte(Console.ReadLine());
                    if(yas >= 65)
                    {
                        Console.WriteLine("Maaşınızı giriniz:");
                        maas = double.Parse(Console.ReadLine());
                        ikramiye = maas * 15;
                        Console.WriteLine("Emekli olabilirsiniz ikramiyeniz: " + ikramiye);
                    }
                    else
                    {
                        Console.WriteLine("Yaşınız emeklilik için yeterli değildir");
                    }
            else
                    {
                        Console.WriteLine("Hatalı cinsiyet girişi,lütfen tekrar deneyiniz");
                    }
                    Console.WriteLine("---------------------------------");
                    goto DESTPEK;
                }
            }
        }
    }
}
