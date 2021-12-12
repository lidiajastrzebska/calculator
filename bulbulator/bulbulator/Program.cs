using System;

namespace bulbulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bulbulator bul1 = new bulbulator();
                Console.WriteLine();
                Console.WriteLine("insert two numbers");
                int n = Convert.ToInt32(Console.ReadLine());
                int k = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1. dod");
                Console.WriteLine("2. odjm");
                Console.WriteLine("3. mnoz");
                Console.WriteLine("4. dziel");

                int m = Convert.ToInt32(Console.ReadLine());

                if (m == 1)
                {
                    Console.WriteLine(bul1.dodawanie(n,k));
                }
                if (m == 2)
                {
                    Console.WriteLine(bul1.odejmowanie(n, k));
                }
                if (m == 3)
                {
                    Console.WriteLine(bul1.mnozenie(n, k));
                }
                if (m == 4)
                {
                    Console.WriteLine(bul1.dzielenie(n, k));
                }

                Console.ReadKey();
            }
        }
    }
}
