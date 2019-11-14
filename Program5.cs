using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcje5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 10;
            Console.WriteLine("Wartosci tablicy przed wywołaniem funkcji: {0} i {1}",tab[0],tab[1]);
            Tab1(tab);
            ShowTab(tab);
            Console.ReadKey();
        }

        static void Tab1(int[] tab)
        {
            tab[0] = 50;
            tab[1] = 100;
            Console.WriteLine("wartości tablicy wewnątrz funkcji{0} i {1}",tab[0],tab[1]);
        }

        static void ShowTab(int[] tab)
        {
            Console.WriteLine("Wartości w tablicy:");
            foreach(int item in tab)
            {
                Console.Write("{0}\t",item);
            }
        }
    }
}
