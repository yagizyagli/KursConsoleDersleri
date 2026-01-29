namespace _260129_1_for_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for Döngüsü 
            //genelde sayısal işlemlerde kulllanılır ama her türlü kullanılabilir,kullanmaya bağlı

            int sayac = 0;//while ve do while döngülerinde bu şekilde bir değişkene ihtiyaç duyuluyor
                          //ama for bu yapıyı kendi içinde getiriyor

            while (sayac < 100)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            //yukarıdaki while ile aşağıdaki for u karşılaştırarak kullanın
            //for(1.Adım;2.Adım;3.Adım)
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i+",");
            }

            Console.WriteLine("");
            Console.WriteLine("Tersten sayma for ile");

            for (int i = 25; i > 10; i--) 
            {
                Console.WriteLine(i+"");
            }


        }
    }
}
