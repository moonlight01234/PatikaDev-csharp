namespace ConsoleApp
{    
    internal class algoritmadersi
    {       
        static void Main(string[] args)
        {
            Console.Write("bir yazı giriniz:");
            string[] ifadeler = Console.ReadLine().Split(','); 
            for(int i = 0; i < ifadeler.Length; i++)
            {
                try
                {
                    if (Convert.ToInt32(ifadeler[i]) != null)
                    {
                        continue;
                    }
                }
                
                catch(System.FormatException)
                {
                    Console.Write(ifadeler[i]+" ");
                }
            }
        }

    }        
}
