namespace _260120_4_if_else_maas_cinsiyet
{
    internal class Program
    {
        static void Main(string[] args)
        {

        DEST:
            Console.WriteLine("Maaşınızı giriniz");
            double maas=double.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyetinizi giriniz Kadın/Erkek veya K/E");
            string cinsiyet=Console.ReadLine();

            if (cinsiyet == "Kadın")
            {
                maas = maas + maas * 20.5 / 100;
                Console.WriteLine("Kadın için Yeni Maaş: "+maas);
            }
            else
            {
                maas = maas + maas * 21.25 / 100;
                Console.WriteLine("Erkek İçin Yeni Maaş: "+maas);
            }
            goto DEST;
        }
    }
}
