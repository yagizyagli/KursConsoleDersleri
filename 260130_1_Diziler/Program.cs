namespace _260130_1_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizileri=>aynı veri tipinde birden fazla data tutan yapılara deriz                        
            
            int sayi1 = 0;
            int sayi2 = 90;
            int sayi3 = 50;
            int sayi4 = 45;

            //yukarıdaki gibi birden fazla sayı lazım olduğunda sayıları bir diziye ekleyip kullanabiliriz
            int[] sayilar = { 0, 90, 50, 45 };//rastgele eleman alan dizi
            int[] numbers = new int[4];//eleman sayısı belirtilerek oluşturulan dizi
            numbers[0] = 0;// 0 index numbers[0] şeklinde tanımlanır ama
                                    // 1.eleman olarak ifade edilir.Diziye eleman atamak için kullanılan yoldur
            numbers[1] = 90;//1.eleman
            numbers[2] = 50;//2.eleman
            numbers[3] = 45;//3.eleman

            //Console.WriteLine("{0} {1}",sayi1,sayi2);

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]); 
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            string[] isimler = new string[172];
            int personelSayisi = 172;
            double[] maaslar = new double[personelSayisi];
            DateTime[] dogumTarihi = new DateTime[personelSayisi];

            Console.WriteLine("------------Diziyi for ile listelemek----------");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Dizinin"+i+"index'i yani" + (i + 1) + ".elemanı:" + numbers[i]);
            }

            //Dizinin eleman sayısı

            int elemanSayisi1 = sayilar.Length;
            int elemanSayisi2 = sayilar.Count();

            Console.WriteLine("Sayılar dizisi için eleman sayısı: "+elemanSayisi1);
            int[] islem = new int[6];
            Console.WriteLine("Sayılar için eleman sayısı: "+islem.Count());

            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine(islem[i]);
            }

            //bir int dizi elemanları atanmadıysa int için değer 0 atanır

            int elSayisi = islem.Length;
            islem[0] = 475;
            islem[1] = 75;
            islem[2] = 5;
            islem[3] = 50;
            islem[4] = 71;
            islem[5] = 114;
            Console.WriteLine("------------Eleman atamsaı yapıldıktan sonra islem dizisi--------");
            for(int i = 0; i < elSayisi; i++)
            {
                Console.WriteLine(+i+1+".eleman:"+islem[i]);
            }

            //dizi eleman sayısı 6 ama ben 7 elemanı eklersem ne olur?
            //islem[6] = 301;//index was bound.... şeklinde hata verir, bu da dizinin sayısı aşıldı,eklenmez anlamına geliyor

            for (int i = 0;i<elSayisi;i++)
            {
                Console.WriteLine(islem[i]);
            }
            Console.WriteLine("--------Tersten--------");
            //tersten dizi eleman sayısı listelemek
            for(int i = islem.Length - 1; i >= 0; i--)
            {
                Console.Write(islem[i]+",");
            }




        }
    }
}
