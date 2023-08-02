namespace ConsoleApp
{
    internal class algoritmadersi2
    {
       
        static void Main(string[] args)
        {
            Console.Write("sayılar girin:");
            string[] dizi = Console.ReadLine().Split();
            int[] sayilar=new int[dizi.Length];
            for(int i = 0; i < dizi.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(dizi[i]);
            }

            for(int i = 0; i < sayilar.Length; i=i+2)
            {
                if (sayilar[i] == sayilar[i + 1])
                {
                    Console.Write(Math.Pow(sayilar[i]*2, 2));
                }
                else
                {
                    Console.Write(sayilar[i] + sayilar[i + 1] + " ");
                }
                
            }
        }
    }
}
