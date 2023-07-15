namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "elif";
            char f = 't';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            float z = 10.3f;
            byte v = (byte)z;
            Console.WriteLine("z:"+z);


            string s1 = "10", s2 ="20";
            int sayi1, sayi2,toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam:" + toplam);

        }
    }
}
