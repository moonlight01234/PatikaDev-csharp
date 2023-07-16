namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outsayi);
            if (sonuc)
            {
                Console.WriteLine("başarılı");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("başarısız");
            }

            metotlar instance = new metotlar();
            instance.topla(4, 5, out int toplamsonuc);
            Console.WriteLine(toplamsonuc);

            int ifade = 999;
            instance.ekranaYazdir(ifade);

        }

    }
    class metotlar
    {
        public void topla(int a,int b,out int toplam)
        {
            toplam = a + b;
        }
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
    
}
