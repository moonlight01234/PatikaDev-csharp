namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1, toplam = 0 ;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            string[] arabalar = { "BMW", "opel", "toyota","ford" };

            foreach(var item in arabalar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
