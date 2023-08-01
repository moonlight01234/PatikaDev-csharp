namespace ConsoleApp
{    
    internal class ucgencizme
    {
        
        public static void ucgenyazma(int n)
        {
            int sayi = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                if (i == n - 1)
                {
                    for (int z = 0; z < sayi; z++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("*");
                    sayi =sayi+2;
                }
                else if(i!=0 )
                {
                    for (int z = 0; z<sayi; z++)
                    {
                        Console.Write(" ");

                    }
                    Console.Write("*");
                    sayi =sayi+2;
                }
               
                
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("boyut:");
            int boyut = Convert.ToInt32(Console.ReadLine());
            ucgenyazma(boyut);

        }

      
    }        
}
