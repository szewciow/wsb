using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki
    //kod niebezpieczny trzeba dodac ze unsafe
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            char* x;
            char letter = 'x';
            x = &letter;
            //przechowujemy w x adres zmiennej letter za pomocą &
            letter = 'a';

            Console.WriteLine("Znaki: {0}", letter);
            Console.WriteLine("Znaki: {0}", *x);
            Console.WriteLine("Adres w pamięci zmiennej letter: {0}", (int)x);
            Console.WriteLine("Adres w pamięci zmiennej letter: {0:x}", (int)x);  //{0:x}hexadecimal

            int test = 10;
            Console.WriteLine(Convert.ToString(test, 8));

            double number;
            double* numberAdres;

            number = 10;
            numberAdres = &number;
            Console.WriteLine("LIczba wynosi {0}", number);
            Console.WriteLine("LIczba wynosi {0}", numberAdres->ToString()); //to samo co z gwiazdką 


            Console.ReadKey();
        }
    }
}
