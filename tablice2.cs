using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabliceNo._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // typ wartościowy

            int a = 10;
            int b = a;
            a--;
            b++;

            Console.WriteLine("zmienna a: {0}", a);//9
            Console.WriteLine("zmienna b: {0}", b);//10


            //typ referencyjny
            int[] tabA = { 2, 2, 2 };
            int[] tabB = tabA;
            tabA[2] = 10;
            tabB[0] = 8;

            Console.WriteLine("Wyświetlanie tablice A:");
            foreach (int item in tabA)
            {
                Console.Write("{0}", item);
                
            }


            Console.WriteLine("Wyświetlanie tablice B:");
            foreach (int item in tabB)
            {
                Console.Write("{0}", item);

            }

            Console.WriteLine();


            //kopiowanie tablicy

            int[] tab = {1,2,3,4,5 };
            int[] tabCopy = new int[5];
           
            foreach (int item in tabCopy)
            {
                Console.Write("{0}", item);

            }

            tab.CopyTo(tabCopy, 0);

            foreach (int item in tabCopy)
            {
                Console.Write("{0}", item);

            }


            //2 sposób kopiowania tablicy
            int[] tabCopy2 = new int[5];

            Array.Copy(tab, tabCopy2, tab.Length);
            Array.Copy(tab, tabCopy2, tab.Length,3);

            );

            foreach (int item in tabCopy)
            {
                Console.Write("{0}", item);

            }



            Console.ReadKey();



        }
    }
}
