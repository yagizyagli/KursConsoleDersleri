namespace _260129_6_for_dik_ucgen_ters_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "*";
            for (int i = 0; i < 10; i++) 
            {
            
                Console.Write(metin);
                
                for(int j =i;  j >=0; j--)
                {
                    
                    Console.Write("{0},",j);
                }
                Console.WriteLine();
                metin += "*";

            }
        }
    }
}
