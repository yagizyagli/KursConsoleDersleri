namespace _260115_1_Aritmetik_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1 Aritmetik 
             * 2 Karşılaştırma
             * 3 Atama
             * 4 Mantıksal      
             */
            // 1) Aritmetik Operatörler

            int sayi1 = 57;
            int sayi2 = 25;
            int topla = sayi1 + sayi2;
            int cikart = sayi1 - sayi2;
            int carp = sayi1 * sayi2;
            int bol = sayi1 / sayi2;
            int modAl = sayi1 % sayi2; // ->Bölmede Kalan sayıyı verir

            Console.WriteLine("Toplam:"+topla);
            Console.WriteLine("Çıkartma:"+cikart);
            Console.WriteLine("Çarp:"+carp);
            Console.WriteLine("Böl:"+bol);
            Console.WriteLine("Mod Alma:" + modAl);
        }
    }
}
