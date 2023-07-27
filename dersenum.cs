namespace ConsoleApp
{    
    internal class dersenum
    {       
        static void Main(string[] args)
        {
            int hava = 32;

            if (hava <= (int)havaDurumu.normal)
            {
                Console.WriteLine("hava biraz daha ısınsın.");
            }

            else
            {
                Console.WriteLine("dışarı çıkılabilir.")
            }
        }
              
    } 
    enum gunler
    {
        pazartesi=1,

        sali,

        carsamba,

        persembe,

        cuma,

        cumartesi,

        pazar
    }

    enum havaDurumu
    {
        soguk=5,

        normal=20,

        sicak=25,

        coksicak=30
    }
        
}
