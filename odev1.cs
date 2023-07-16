namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //soru1();

            //soru2();

            //soru3();

            //soru4();

        }

        private static void soru4()
        {
            // 4.soru
            Console.WriteLine("bir cümle giriniz:");
            List<string> cumle = Console.ReadLine().TrimEnd().Split(' ').ToList();

            Console.WriteLine(cumle.Count());

            int count = 0;
            foreach (var item in cumle)
            {
                count += item.Count();
            }
            Console.WriteLine(count);
        }

        private static void soru3()
        {
            // 3.soru
            Console.WriteLine("pozitif bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> arr = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("bir kelime giriniz:");
                arr.Add(Console.ReadLine());
            }

            arr.Reverse();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void soru2()
        {
            // 2.soru
            Console.WriteLine("pozitif bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pozitif bir sayı giriniz:");
            int m = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("pozitif bir sayı giriniz:");
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var item in arr)
            {
                if (item % m == 0 || item == m)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void soru1()
        {
            // 1.soru
            Console.WriteLine("bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("bir sayı giriniz:");
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }    
}
