namespace _260130_4_dizi_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dizi = new double[6];
           
            
            //dizi[0] = 12;
            //dizi[1] = 13;
            //dizi[2] = 14;
            //dizi[3] = 15;
            //dizi[4] = 16;
            //dizi[5] = 17;

            for (int i = 0; i < dizi.Length; i++) 
            {
                Console.WriteLine(i + 1 + ".eleman:");
                dizi[i]=double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine(i + 1 + ".eleman:" +dizi[i]);              
            }

                
            
        }
    }
}
