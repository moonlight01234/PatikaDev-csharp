namespace ConsoleApp
{
    internal class dairecizme
    {
        public static void daireyazma(int n)
        {
            int sayi = (int)Math.Ceiling((double)n / 2);
            int sayac1 = 0;
            int sayac2 = 0;
            int temp = 0;

            for (int j = 0; j < Math.Ceiling((double)n / 2); j++)
            {
                Console.Write("  ");
                sayac1 = sayac1 + 1;
            }
            for (int j = 0; j < (2 * n) - (2 * (Math.Ceiling((double)n / 2))); j++)
            {
                Console.Write(" *");
                sayac2 = sayac2 + 1;
               
            }
            Console.WriteLine();
            sayi--;

            temp = sayac1;
            while (temp-1 > 0)
            {
                for (int j = 0; j < sayi; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(" *");
                for (int j = 0; j < (2 * n) - (2 * (sayi)) - 2; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(" *");

                Console.WriteLine();
                sayi--;
                temp--;
            }

            while (sayac2-1 > 0)
            {
                Console.Write(" *");
                for(int i = 0; i < 2*n-2; i++)
                {
                    Console.Write("  ");
                }
                Console.Write(" *");
                sayac2--;
                Console.WriteLine();
            }
            while (sayac1 > 0)
            {
                for (int j = 0; j < sayi; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(" *");
                for (int j = 0; j < (2 * n) - (2 * (sayi)) - 2; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(" *");

                Console.WriteLine();
                sayi++;
                sayac1--;
            }
            for (int j = 0; j < Math.Ceiling((double)n / 2); j++)
            {
                Console.Write("  ");
                sayac1 = sayac1 + 1;
            }
            for (int j = 0; j < (2 * n) - (2 * (Math.Ceiling((double)n / 2))); j++)
            {
                Console.Write(" *");
                sayac2 = sayac2 + 1;

            }

        }
        static void Main(string[] args)
        {
            Console.Write("boyut:");
            int boyut = Convert.ToInt32(Console.ReadLine());
            daireyazma(boyut);
        }
    }
}
