using System.Globalization;

namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for(int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);

            islemler instante = new islemler();
            Console.WriteLine(instante.expo(3, 4));
            string ifade = "elif";
            bool sonuc = ifade.checkspaces();
            Console.WriteLine(sonuc);
        }

    }
    public class islemler
    {
        public int expo(int sayi,int us)
        {
            if (us < 2)
            {
                return sayi;
            }
            return expo(sayi,us-1)*sayi;
        }
    }
    public static class extension
    {
        public static bool checkspaces (this string param)
        {

            return param.Contains(" ");
        }
    }
}
