using System.Collections;

namespace ConsoleApp5
{
    internal class soru2
    {  
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("sayi giriniz:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(sayilar);
            int buyuk=0;
            int kucuk=0;

            for(int i = sayilar.Length-3; i <sayilar.Length; i++)
            {
                buyuk += sayilar[i];
               
            }

            for (int i = 0; i < 3; i++)
            {
                kucuk+= sayilar[i];
               
            }

            Console.WriteLine((double)buyuk / (double)3 + kucuk / 3);

        }

    }    
}
