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
            int a = 3;
            Console.WriteLine("Zmienna a przed wywołaniem funkcji: {0}:", a);
            increment(ref a);
            Console.WriteLine("Zmienna a po wwołaniu funkcji: {0}:", a);

            Console.ReadKey();
        }

        static void increment(int x)
        {
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji: {0}:", x);

        }

    }
}
