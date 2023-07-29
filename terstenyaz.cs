namespace ConsoleApp
{    
    internal class terstenyaz
    {       
        static void Main(string[] args)
        {
            Console.Write("bi yazı giriniz:");
            string[] yazi = Console.ReadLine().Split();
            for(int i = 0; i<yazi.Length; i++)
            {
                char[] charArray = yazi[i].ToCharArray();
                Array.Reverse(charArray);
                Console.Write(new string(charArray)+" ");
            }
        }

    }         
}
