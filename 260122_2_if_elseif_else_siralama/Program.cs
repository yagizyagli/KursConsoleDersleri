namespace _260122_2_if_elseif_else_siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            START:
            Console.WriteLine("1.Sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.Sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3.Sayıyı giriniz:");
            int sayi3 = int.Parse(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3 && sayi2>sayi3 )
            {
                Console.WriteLine("sayi3<sayi2<sayi1");
            }
            else if(sayi2>sayi1 && sayi1 > sayi3 && sayi2>sayi3)
            {
                Console.WriteLine("sayi3<sayi1<sayi2");
            }
            else if(sayi3>sayi1 && sayi3>sayi2 && sayi2>sayi1)
            {
                Console.WriteLine("sayi1<sayi2<sayi3");
            }
            else if(sayi1>sayi2 && sayi3>sayi1 && sayi3 > sayi2)
            {
                Console.WriteLine("sayi2<sayi1<sayi3");
            }
            else if(sayi1>sayi2 && sayi2>sayi3)
            {
                Console.WriteLine("sayi2<sayi3<sayi1");
            }
            else if(sayi2>sayi1 && sayi3>sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine("sayi1<sayi3<sayi2");
            }
            
            else
            {
                Console.WriteLine("Eşit sayılar girilmesin daha yapmadım");
            }
            goto START;
        }
    }
}
