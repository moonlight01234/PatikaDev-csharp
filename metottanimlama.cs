namespace ConsoleApp5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            Console.WriteLine(a + b);

            int sonuc = topla(a,b);
            Console.WriteLine(sonuc);
            metotlar ornek = new metotlar();
            ornek.ekranaYazdir(Convert.ToString(sonuc));

        }

        static int topla(int a,int b)
        {
            return a + b;
        }
    }
    class metotlar
    {
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
    }
}
