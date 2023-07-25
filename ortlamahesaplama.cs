namespace ConsoleApp5
{    
    internal class ortalamahesaplama
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            List<int> dizi = new List<int>();

            newclass nc = new newclass();

            nc.fibonacci(sayi, dizi);
        }
        
        class newclass
        {
            public void fibonacci(int n, List<int> ints)
            {
                ints.Add(1);
                ints.Add(1);
                for (int i = 0; i < n - 2; i++)
                {
                    ints.Add(ints[i] + ints[i + 1]);
                }
                int toplam = 0;
                foreach (var item in ints)
                {
                    toplam += item;
                }
                Console.WriteLine((double)toplam / n);
            }
        }
    } 
        
}
