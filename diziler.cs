namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "kuş", "köpek" };

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("dizinin eleman sayısını giriniz:");
            int diziuzunluğu = Convert.ToInt32(Console.ReadLine());
            int[] sayidizisi = new int[diziuzunluğu];

            for(int i = 0; i < diziuzunluğu; i++)
            {
                Console.WriteLine("{0}. sayısını giriniz:",i+1);
                sayidizisi[i] = Convert.ToInt32(Console.ReadLine());

            }
            int toplam = 0;
            foreach(var item in sayidizisi)
            {
                toplam += item;
            }
            Console.WriteLine(toplam);
        }
    }
}
