using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia1
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            /*
             *
             *
             */
            Console.WriteLine("Janusz");


            //zmienne i typy danych
            int x=10;
            Console.WriteLine(x);
            int x1, y = 10, z = 15;
            x1 = 10;
            //konkatenacja
            Console.WriteLine("y= " + y + "\nz= " + z);

            int a = 10;
            int b = a;
            //alternatywny sposób deklaracji zmiennej
            int c = new int();//wartość domyślna ==> null (brak referencji)

            Console.Write("Podaj imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("twoje imie " + name);

            float f = 10.55F;
            Console.WriteLine("float" + f);

            double y2 = 15.95;
            Console.WriteLine("zmienna double " + y2);

            //program co oblicza pole prostokąta
            Console.Write("POdaj bok a ");
            string a1 = Console.ReadLine();
            double a2 = double.Parse(a1);
            Console.Write("POdaj bok b ");
            double a3 = double.Parse(Console.ReadLine());

            double result = a2 * a3;
            Console.Write("Wynik: "+ result);

            //drugi sposob
            a2 *= a3;
            Console.Write("Wynik:"+a2);

            //trzeci sposob
            Console.Write("Wynik "+a2*a3);

            Console.ReadKey();
        }
    }
}
