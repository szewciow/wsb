using System;

namespace liczby_pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            string p1 = Console.ReadLine();
            ulong p;
            if (ulong.TryParse(p1, out p))
            { 
                for (ulong i = 2; i<= p-1; i++)
                { if (p % i == 0)
                    {
                        Console.WriteLine("Liczba NIE jest liczbą pierwszą.");
                    }
                } Console.WriteLine("Liczba jest liczbą pierwszą.");
            }

            else {
                Console.WriteLine("Podano złe dane.");
            }
        }
    }
}
