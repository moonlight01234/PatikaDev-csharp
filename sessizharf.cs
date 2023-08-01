namespace ConsoleApp
{    
    internal class sessizharf
    {       
        static void Main(string[] args)
        {
            Console.Write("bir yazı giriniz:");
            string[] ifadeler = Console.ReadLine().Split();            
            int sayac;
            for(int i = 0; i < ifadeler.Length; i++)
            {
                ifadeler[i] = ifadeler[i].ToLower();
            }
            
            for (int i = 0; i < ifadeler.Length; i++)
            {
                sayac = 0;            
                for(int j = 0; j < ifadeler[i].Length-1; j++)
                {
                    if (!((ifadeler[i][j].Equals('a')) || ifadeler[i][j].Equals('e') || ifadeler[i][j].Equals('i') || ifadeler[i][j].Equals('ı') || ifadeler[i][j].Equals('u') || ifadeler[i][j].Equals('ü') || ifadeler[i][j].Equals('o') || ifadeler[i][j].Equals('ö')))
                    {
                        if(!(ifadeler[i][j+1].Equals('a') || ifadeler[i][j+1].Equals('e') || ifadeler[i][j + 1].Equals('i') || ifadeler[i][j + 1].Equals('ı') || ifadeler[i][j + 1].Equals('u') || ifadeler[i][j + 1].Equals('ü') || ifadeler[i][j + 1].Equals('o') || ifadeler[i][j + 1].Equals('ö')))
                        {
                            sayac=1;
                            
                            break;
                        }
                                                
                    }

                }
                if (sayac==1)
                {
                    Console.WriteLine("true");

                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }

    }        
}
