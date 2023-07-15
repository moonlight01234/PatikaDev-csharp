namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int a = int.Parse("test");
            }

            catch(FormatException e)
            {
                Console.WriteLine("hata");
            }

        }
    }
}
