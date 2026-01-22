namespace _260122_1_if_elseif_else_fatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
        START:
            double fatura = 0;
            Console.WriteLine("Aylık KW Harcamanız nedir?");
            double kw=double.Parse(Console.ReadLine());
            
           
            if (kw>0 && kw<=100)
            {
                fatura = kw * 0.95;
                Console.WriteLine("kw {0},Fatura:{1}"+kw,fatura);

            }
            else if(kw>100 && kw <= 150)
            {
                double ilk100 = 85;
                double sonDeger = (kw - 100) * 0.98;
                fatura= ilk100 + sonDeger;
                Console.WriteLine("kw {0},Fatura:{1}" + kw, fatura);
            }
            else if(kw>150 &&  kw <= 275)
            {
                double ilk100 = 130;
                double sonDeger = (kw - 100) * 1.05;
                fatura = ilk100 + sonDeger;
                Console.WriteLine("kw {0},Fatura:{1}" + kw,fatura);

            }
            else if(kw>275 && kw <= 400)
            {
                double ilk100 = 250;
                double sonDeger = (kw - 100) * 1.25;
                fatura = ilk100 + sonDeger;
                Console.WriteLine("kw {0},Fatura:{1}" + kw, fatura);

            }
            else if(kw>400 && kw <= 600)
            {
                double ilk100 = 430;
                double sonDeger = (kw - 100) * 1.45;
                fatura = ilk100 + sonDeger;
                Console.WriteLine("kw {0},Fatura:{1}" + kw, fatura);

            }
            else
            {
                double ilk100 = 750;
                double sonDeger = (kw - 100) * 1.55;
                fatura = ilk100 + sonDeger;
                Console.WriteLine("kw {0},Fatura:{1}" + kw, fatura);

            }
            goto START;

            
            
            
            



        }
    }
}
