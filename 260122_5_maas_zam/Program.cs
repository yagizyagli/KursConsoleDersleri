namespace _260122_5_maas_zam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*
            Kullanıcıdan alınan bir maaş için 
            Eğer maaş değeri 25.000 ve altında ise %45 zam
            Eğer maaş 50.000 ve üstünde ise %17 zam
            Eğer maaş 100.000 ve üstünde ise %9 zam
            Eğer maaş 150.000 ve üstü ise %5 zam yapacak şekilde yapılan zam oranını ve yeni maaşı kullanıcıya gösteren yapıyı kodlayınız

         */

        START:
            Console.WriteLine("Maaşınızı giriniz:");
            double maas = Convert.ToDouble(Console.ReadLine());

            if (maas>0 && maas<=25000)
            {
                maas += maas * 45 / 100;
                Console.WriteLine("Yeni Maaşınız: " + maas);
            }

            else if (maas>25000 && maas <= 50000)
            {
                maas += maas * 17 / 100;
                Console.WriteLine("Yeni Maaşınız: " + maas);
            }
            else if (maas>50000 && maas<= 100000)
            {
                maas += maas * 9 / 100;
                Console.WriteLine("Yeni Maaşınız: " + maas);
            }
            else if (maas>100000 && maas <= 150000)
            {
                maas += maas * 5 / 100;
                Console.WriteLine("Yeni Maaşınız: " + maas);
            }
            
            else 
            {
                maas += maas * 3 / 100;
                Console.WriteLine("Yeni Maaşınız: "+maas);
            }
            goto START;
        }
    
    }
}
