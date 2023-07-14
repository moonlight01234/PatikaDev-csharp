namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x = 5;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //mantıksal operatörler
            bool issucces = true;
            bool isCompleted = false;

            if (issucces && isCompleted)
                Console.WriteLine("perfect");
            if (issucces || isCompleted)
                Console.WriteLine("great");
            if (issucces && !isCompleted)
                Console.WriteLine("fine");

            //ilişkisel operatörler
            int a = 3;
            int b = 5;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =++sayi1;
            Console.WriteLine(sonuc1);
        }
    }
}
