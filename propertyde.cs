
namespace ConsoleApp
{    
    internal class propertyde
    {       
        static void Main(string[] args)
        {
            ogrenci ogr = new ogrenci();
            ogr.Isim = "elif";
            ogr.Soyisim = "gkdk";
            ogr.Ono = 1;
            ogr.Sinif = 12;
            ogr.ogrencibilgileri();
            
        }
              
    } 

    class ogrenci
    {
        private string isim;
        private string soyisim;
        private int  ono;
        private int sinif;


        public string Isim
        {
            get
            {
                return isim;
            }

            set
            {
                isim = value;
            }
        }

        public string Soyisim { get => soyisim; set =>soyisim= value; }

        public int Ono { get => ono; set => ono= value; }

        public int Sinif { get => sinif; set => sinif = value; }
        public ogrenci(string isim,string soyisim,int ono,int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            Ono = ono;
            Sinif = sinif;
        }

        public ogrenci()
        {
            
        }

        public void ogrencibilgileri()
        {
            Console.WriteLine(Isim);
            Console.WriteLine(Soyisim);
            Console.WriteLine(Ono);
            Console.WriteLine(Sinif);
        }
    }
    
        
}
