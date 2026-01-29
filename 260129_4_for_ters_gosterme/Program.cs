namespace _260129_4_for_ters_gosterme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=40; i++) 
            {
                Console.WriteLine(i+"=>");
                for(int k = i; k>=0; k--)
                {
                    Console.Write(k+",");
                }
                Console.WriteLine("\n");
            }            
        }
    }
}
