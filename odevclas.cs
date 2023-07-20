using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp5
{
    
    
    internal class odevclas
    {       
        static void Main(string[] args)
        {

            calisan cl1 = new calisan();
            cl1.ad = "elif";
            cl1.soyad = "tilki";
            cl1.no = 1;
            cl1.departman = "IT";

            cl1.calisanbilgileri();

            calisan cl2 = new calisan();
            cl2.ad = "deniz";
            cl2.soyad = "arda";
            cl2.no = 2;
            cl2.departman = "IT";

            cl2.calisanbilgileri();

        }

    } 
    
    class calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        public void calisanbilgileri()
        {
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(no);
            Console.WriteLine(departman);
            
        }
    }
}
