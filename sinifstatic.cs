namespace ConsoleApp
{    
    internal class sinifstatic
    {       
        static void Main(string[] args)
        {
            Console.WriteLine(calisan.Calisansayisi);

            calisan cl = new calisan("elif");
            Console.WriteLine(calisan.Calisansayisi);
        }
              
    } 
    class calisan
    {
        private static int calisansayisi;
        public static int Calisansayisi
        {
            get => calisansayisi;
            set => calisansayisi = value;
        }

        private string isim;

        static calisan()
        {
            calisansayisi = 0;
        }

        public calisan(string isim)
        {
            this.isim = isim;
            calisansayisi += 1;
        }
    }   
        
}
