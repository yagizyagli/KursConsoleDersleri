namespace _260115_3_Mantiksal_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3 Mantıksal Operatörler
             && ->=and
             || ->= or
             bilgisayarda true=1 false=0 dır
             and işleminde çarpma işlemi olur 1*0 false olur yalnızca true true olursa doğru olur 0 yutan eleman olduğu için 
             or işleminde toplama işlemi olur 1+0 true olur  toplama olduğu için sadece false false kabul etmez 0+0->0 dır. true false kabul eder
             */

            bool sonuc = 10 > 5 && 20 > 15;
            Console.WriteLine("10>5 && 20>15 işlem sonucu:"+sonuc);
            sonuc = 10 > 5 && 0 >= 2;
            Console.WriteLine("10>5 && 0>=2:"+sonuc);
            sonuc = 10 > 5 || 0 >= 2;
            Console.WriteLine("10>5 || 0>=2:"+sonuc);//True 
            
        }
    }
}
