using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp5
{
    
    
    internal class erisimbelirleyici
    {       
        static void Main(string[] args)
        {

            calisan cl1 = new calisan("elif","tilki",1,"IT");
            
            cl1.calisanbilgileri();

            calisan cl2 = new calisan();
            cl2.Ad = "deniz";
            cl2.Soyad = "arda";
            cl2.No = 2;
            cl2.Departman = "IT";

            cl2.calisanbilgileri();

        }

    } 
    
    class calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public calisan()
        {

        }
        public void calisanbilgileri()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Soyad);
            Console.WriteLine(No);
            Console.WriteLine(Departman);
            
        }
    }
}
