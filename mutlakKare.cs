namespace ConsoleApp
{    
    internal class mutlakKare
    {       
        static void Main(string[] args)
        {
            Console.Write("sayılar giriniz:");
            string[] diziInput =Console.ReadLine().Split() ;
            int[] numbers = new int[diziInput.Length];
            int kToplam = 0;
            int bToplam = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(diziInput[i]);
                if (67 < numbers[i])
                {
                   bToplam +=(int)Math.Pow( Math.Abs(numbers[i] - 67),2);
                }

                else if (67 > numbers[i])
                {
                   kToplam+= 67-numbers[i];
                }
   
            }

            Console.WriteLine(kToplam);
            Console.WriteLine(bToplam);
        }

    }        
}
