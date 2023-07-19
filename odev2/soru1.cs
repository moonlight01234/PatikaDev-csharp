using System.Collections;

namespace ConsoleApp
{
    internal class soru1
    {    static bool asalmi(int n)
        {
            int sayac = 0;
            if(n==0 || n == 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            else
            {
                for(int i = 3; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sayac = 1;
                        break;
                    }
                }
                if (sayac == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList notasal = new ArrayList();
            int sayi;
            int count = 0;
            while(count<20)
            {
                try
                {
                    Console.WriteLine("pozitif sayı giriniz:");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi < 0)
                    {
                        throw new Exception();
                    }

                    if (asalmi(sayi))
                    {
                        asal.Add(sayi);
                    }
                    else
                    {
                        notasal.Add(sayi);
                    }
                    ++count;
                }

                catch (Exception)
                {
                    Console.WriteLine("hata");                    
                }
                
            }
            int ortasal = 0;
            asal.Sort();
            asal.Reverse();
            foreach (var item in asal)
            {
                ortasal += (int)item;
                Console.WriteLine("asal: "+item);
            }
            int ortnotasal = 0;
            notasal.Sort();
            notasal.Reverse();
            foreach (var item in notasal)
            {
                ortnotasal += (int)item;
                Console.WriteLine("asal değil: "+item);
            }

            Console.WriteLine("asal elema sayısı: "+asal.Count);
            Console.WriteLine("asal olmayan eleman sayısı: "+notasal.Count);

            Console.WriteLine("asal ortalama: "+ortasal / asal.Count);
            Console.WriteLine("asal olmayanların ortalama: "+ortnotasal / notasal.Count);

        }

    }    
}
