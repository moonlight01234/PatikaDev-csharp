using System.Collections;

namespace ConsoleApp
{
    internal class soru3
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("bir kelime giriniz:");
            string[] kelime = Console.ReadLine().Split();

            for(int i = 0; i < kelime.Length; i++)
            {
                kelime[i] = kelime[i].ToLower();
            }
            List<char> sesli = new List<char>();

           for(int i = 0; i < kelime.Length; i++)
            {
                for(int j = 0; j < kelime[i].Length; j++)
                {
                    if (kelime[i][j] == 'a' || kelime[i][j] == 'e' || kelime[i][j] == 'ı' || kelime[i][j] == 'i' || kelime[i][j] == 'u' || kelime[i][j] == 'ü' || kelime[i][j] == 'o' || kelime[i][j] == 'ö')
                    {
                        sesli.Add(kelime[i][j]);
                    }
                }
            }

            foreach (var item in sesli)
                Console.WriteLine(item);

        }

    }    
}
