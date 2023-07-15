namespace ConsoleApp5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı giriniz:");
            int sayac =int.Parse( Console.ReadLine());
            for(int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            int tektoplam = 0, cifttoplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    tektoplam += 1;
                }
                else
                {
                    cifttoplam += 1;
                }
            }

            Console.WriteLine(tektoplam);
            Console.WriteLine(cifttoplam);
        }
    }
}
