namespace _260129_7_ters_dik_ucgen_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *
            **
           *** 
          **** 
         ***** 
        ******
      ********
             */

            string yildiz = "*";
            for (int i = 0; i <=15; i++) 
            {
                Console.Write(yildiz);
                for (int j = 15; j > i; j--)
                {
                    Console.WriteLine(" ");
                }
                Console.WriteLine(yildiz);
                yildiz += "*";
            }

        }
    }
}
