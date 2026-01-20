namespace _260120_3_if_else_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Kullanıcıdan bir websitesi için login sayfasında giriş ekranı için kullanıcı ve şifre isteyen sistemi kodlayarak tasarlayınız

        //Kullanıcı adı:admin
        //şifre:ab?0

        BASLA:

            Console.WriteLine("Kullanıc adınızı giriniz");
            string kullaniciAdi=Console.ReadLine();

            Console.WriteLine("şifrenizi giriniz");
            string sifre=Console.ReadLine();
            if (kullaniciAdi=="admin"&&sifre=="ab?0")
            {
                Console.WriteLine("giriş başarılı");
                Console.WriteLine("!!!!!!!!!!!!!Hoşgeldiniz!!!!!!!!");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı,tekrar deneyiniz");
                goto BASLA;
            }
        }
    }
}
