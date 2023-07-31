namespace ConsoleApp
{    
    internal class karakterdegistirme
    {       
        static void Main(string[] args)
        {
            Console.Write("bir yazı giriniz:");
            string[] ifadeler = Console.ReadLine().Split();
            char[] harfler;
            char temp;
            for (int i = 0; i < ifadeler.Length; i++)
            {
                harfler = ifadeler[i].ToCharArray();
                temp = harfler[0];
                harfler[0] = harfler[harfler.Length - 1];
                harfler[harfler.Length - 1] = temp;
                Console.Write(new string(harfler) + " ");
            }

        }

    }        
}
