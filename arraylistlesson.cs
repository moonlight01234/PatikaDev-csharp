using System.Collections;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("ayşe");
            liste.Add(10);
            liste.Add(true);
            liste.Add('A');

            Console.WriteLine(liste[1]);

            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            string[] renkler = { "kırmızı", "mavi", "sarı" };
            List<int> sayilar = new List<int>() {1,8,2,10,5,6 };
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(liste.BinarySearch(8));

            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


        }

    }    
}
