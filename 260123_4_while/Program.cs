namespace _260123_4_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ardışık işlemleri koşula bağlı ya da koşulsuz yapmak için döngüler kullanılır
            1-while
            2-do while
            3-for
            4-foreach             
             */


            int sayi = 0;
            //Döngü her true olduğunda bu alandaki kodlar okunacaktır
            while (sayi < 10)
            {
                Console.WriteLine(sayi);
                sayi++;//0+1=1,1+1=2,..9+1=10
                //sayi bir sayaçtır döngü için . Burda sayaç sürekli arttırma işlemi yapmış
            }
        }
    }
}
