namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mounth = DateTime.Now.Month;

            switch(mounth)
            {
                case 1:
                    Console.WriteLine("ocak");
                    break;

                case 2:
                    Console.WriteLine("şubat");
                    break;

                case 3:
                    Console.WriteLine("mart");
                    break;
            }

            switch (mounth)
            {
                case 12:
                case 2:
                case 1:
                    Console.WriteLine("kış");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("bahar");
                    break;
            }
        }
    }
}
