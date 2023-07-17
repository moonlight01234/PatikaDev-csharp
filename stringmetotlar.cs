namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "dersimiz c# hosgeldiniz";
            string degisken2 = "c#";

            Console.WriteLine(degisken.Length);

            Console.WriteLine(degisken.ToUpper());

            Console.WriteLine(degisken.ToLower());

            Console.WriteLine(String.Concat(degisken,"merhaba"));

            Console.WriteLine(degisken.CompareTo(degisken2));

            Console.WriteLine(String.Compare(degisken,degisken2,true));

            Console.WriteLine(String.Compare(degisken,degisken2,false));

            Console.WriteLine(degisken.Contains(degisken2));

            Console.WriteLine(degisken.EndsWith("hosgoldeniz"));

            Console.WriteLine(degisken.StartsWith("merhaba"));

            Console.WriteLine(degisken.IndexOf("c#"));

            Console.WriteLine(degisken.Remove(10));

            Console.WriteLine(degisken.Reverse());

        }

    }    
}
