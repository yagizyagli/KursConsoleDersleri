namespace _260122_3_if_elseif_else_emekli
{
    internal class Program
    {
        static void Main(string[] args)
        {
        BASLA:

            Console.WriteLine("Cinsiyetinizi giriniz: ");
            string cinsiyet = Console.ReadLine();

            Console.WriteLine("Yaşınızı giriniz:");
            int yas=int.Parse(Console.ReadLine());

            Console.WriteLine("Maaşınızı giriniz:");
            double maas = Convert.ToDouble(Console.ReadLine());


            if (cinsiyet=="Kadın" && yas >= 60)
            {
                

                double YeniMaas = maas * 13;
                Console.WriteLine("İkramiye ve Emeklilik var: "+YeniMaas);

            }
            else if(cinsiyet=="Erkek" && yas >= 65)
            {
                
                double Yenimaas = maas * 15;
                Console.WriteLine("İkramiye ve Emeklilik var: " +Yenimaas);
            }
            else
            {
                Console.WriteLine("Emeklilik ve İkramiye yok");
            }
            goto BASLA;
        }
        
    }
}
