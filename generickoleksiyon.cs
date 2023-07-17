namespace ConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<int> sayiDizisi = new List<int>();
            sayiDizisi.Add(23);
            sayiDizisi.Add(10);
            sayiDizisi.Add(4);
            sayiDizisi.Add(5);
            sayiDizisi.Add(92);
            sayiDizisi.Add(34);

            List<string> renkDizisi = new List<string>();
            renkDizisi.Add("kırmızı");
            renkDizisi.Add("mavi");
            renkDizisi.Add("sarı");
            renkDizisi.Add("beyaz");
            renkDizisi.Add("siyah");
            renkDizisi.Add("mor");


            Console.WriteLine(sayiDizisi.Count);
            Console.WriteLine(renkDizisi.Count);

            foreach(var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            foreach (var item in renkDizisi)
            {
                Console.WriteLine(item);
            }

            sayiDizisi.ForEach(sayi => Console.WriteLine(sayi));
            renkDizisi.ForEach(renk => Console.WriteLine(renk));



        }

    }    
}
