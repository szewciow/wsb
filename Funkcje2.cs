using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcje2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz funkcje, ktora napisze czy liczba jest parzysta/nieparzysta
            //Funkcja zwraca string (Liczba parzysta/nieparzysta)

            //Napisz funkcje, ktora wyswietli sume cyfr nw liczbie 
            Console.WriteLine(Sum(1234));
            Console.ReadKey();
            
        }

        static int Sum(int a)
        {
            int suma=0;
            do
            {
                suma = suma + a % 10;
                a /= 10;

            } while (a!=0);

            return suma;
        }



        static string Licz(int a)
        {
            string parzystosc;
            if (a % 2 == 0)
            {
                parzystosc = "Liczba parzysta";
            }
            else
            {
                parzystosc = "Liczba nieparzysta";
            }
            return parzystosc;
        }
    }

}
