using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace funkcje3
{
    class Program
    {
        static void Main(string[] args)
        {
            //gdy nie dajemy wartosci liczbie odrazu to wtedy out nie ref bo ref potrzebuje wartosci początkowej, out nie moze miec wartosci początkowej, i z tym ref to tak ze działa wszedzie nie tylko lokalnie
            int a;
           
            increment(out a);
            Console.WriteLine("Zmienna a po wwołaniu funkcji: {0}:", a);

            Console.ReadKey();
        }

        static void increment(out int x)
        {
            x = 1;
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji: {0}:", x);

        }

    }
}
