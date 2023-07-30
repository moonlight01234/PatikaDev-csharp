namespace ConsoleApp
{
    internal class alanhesaplama
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-üçgen\n2-daire\n3-kare\n4-dikdörtgen");
            Console.Write("işlem yapmak istediğiniz şekil:");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.Write("kenar1:");
                int kenarr1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("kenar2:");
                int kenarr2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("kenar3:");
                int kenarr3 = Convert.ToInt32(Console.ReadLine());
                ucgen ucg = new ucgen(kenarr1, kenarr2, kenarr3);
                ucg.cevre();
                ucg.alan();
            }

            if (secim == 2)
            {
                Console.Write("yarıçap:");
                int yaricapp = Convert.ToInt32(Console.ReadLine());
                Console.Write("yükseklik:");
                int yksklk = Convert.ToInt32(Console.ReadLine());
                daire dr= new daire(yaricapp, yksklk);
                dr.cevre();
                dr.alan();
                dr.hacim();

            }

            if (secim == 3)
            {
                Console.Write("kenar:");
                int kenarr = Convert.ToInt32(Console.ReadLine());
                kare kr = new kare(kenarr);
                kr.cevre();
                kr.alan();
                kr.hacim();

            }

            if (secim == 4)
            {
                Console.Write("uzun kenar:");
                int ukenarr = Convert.ToInt32(Console.ReadLine());
                Console.Write("kısa kenar:");
                int kkenarr = Convert.ToInt32(Console.ReadLine());
                Console.Write("yükseklik:");
                int yksklk = Convert.ToInt32(Console.ReadLine());
                dikdortgen dk = new dikdortgen(ukenarr, kkenarr, yksklk);
                dk.cevre();
                dk.alan();
                dk.hacim();

            }



        }
    }

    class kare
    {
        private int Kenar;

        public kare(int kenar)
        {
            Kenar = kenar;
                
        }
        public void cevre()
        {
            Console.WriteLine("çevre:{0}",Kenar*4);
        }

        public void alan()
        {
            Console.WriteLine("alan:{0}",Kenar * Kenar);
        }

        public void hacim()
        {
            Console.WriteLine("hacim:{0}",Kenar * Kenar * Kenar);
        }
    }

    class dikdortgen
    {
        private int Ukenar;
        private int Kkenar;
        private int Yukseklik;

        public dikdortgen(int ukenar,int kkenar,int yukseklik)
        {
            Ukenar=ukenar;
            Kkenar = kkenar;
            Yukseklik = yukseklik;

        }
        public void cevre()
        {
            Console.WriteLine("çevre:{0}",(2*Ukenar)+(2*Kkenar));
        }

        public void alan()
        {
            Console.WriteLine("alan:{0}",Ukenar * Kkenar);
        }

        public void hacim()
        {
            Console.WriteLine("hacim:{0}",Yukseklik*Kkenar*Ukenar);
        }
    }

    class ucgen
    {
        private int Kenar1;
        private int Kenar2;
        private int Kenar3;
        

        public ucgen(int kenar1,int kenar2,int kenar3)
        {
            Kenar1 = kenar1;
            Kenar2 = kenar2;
            Kenar3 = kenar3;
            

        }
        public void cevre()
        {
            Console.WriteLine("çevre:{0}", Kenar1+Kenar2+Kenar3);
        }

        public void alan()
        {
            Console.WriteLine("alan:{0}",Math.Sqrt(((Kenar1 + Kenar2 + Kenar3)/2)* (((Kenar1 + Kenar2 + Kenar3) / 2)-Kenar1)* (((Kenar1 + Kenar2 + Kenar3) / 2) - Kenar2)* (((Kenar1 + Kenar2 + Kenar3) / 2) - Kenar3)));
        }

    }

    class daire
    {
        private int yariCap;
        private int Yukseklik;

        public daire(int yaricap, int yukseklik)
        {
            yariCap = yaricap;
            Yukseklik = yukseklik;

        }
        public void cevre()
        {
            Console.WriteLine("çevre:{0}", 2*Math.PI*yariCap);
        }

        public void alan()
        {
            Console.WriteLine("alan:{0}", Math.PI*yariCap*yariCap);
        }

        public void hacim()
        {
            Console.WriteLine("hacim:{0}", Math.PI * yariCap * yariCap*Yukseklik);
        }
    }

}
