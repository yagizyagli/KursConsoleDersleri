namespace _260123_3_ternary_operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ternary operatörü=>if else yerine kullanılan ?: operatörleridir


            //sayi>0 ? "Pozitif" : "Negatif"
            //koşul? True:False;//ternary operatörü kullanımı
            //koşul ? koşul doğru(true) ise yazılacak kod alanı:koşul hatalı(false) ise yazılacak kod alanı
            START:
            Console.WriteLine("Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Pozitif"+sayi);
            }
            else
            {
                Console.WriteLine("Negatif"+sayi);
            }
            Console.WriteLine("------------Ternary İle");

            string sonuc;
            //Console.WriteLine(sayi>0? "Pozitif"+sayi : "Negatif"+sayi);
            sonuc = sayi > 0 ? "Pozitif" : "Negatif";

            Console.WriteLine(sonuc+":"+sayi);
            Console.WriteLine("----------------------");
            
            goto START;           
        }
    }
}
