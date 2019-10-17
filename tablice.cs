using System;

namespace tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //w 10 elementowej tablicy jednowymiarowej
            // object nazwie tab umieszcza liczby całkowite z przedziału od 1 do 10

            int n = 10, i;
            //deklaracja tablicy o nazwie tab typu całkowitego o rozmiarze n=10
            int[] tab = new int[n];
            for (i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }
            for (i = 0; i < tab.Length; i++)
            {
                Console.Write("{0} ", tab[i]);
            }





            //Napisz program w 5 elementowej tablicy jednowymiarowej o nazwie colors
            //umieszcza nazwy kolorow podane z klawiatury przez uzytkownika(for)
            //wyswietl kolory w formacie(while)
            //kolor1: red
            //kolor2: yellow
           
            string[] colors = new string[5];
            string color;
            int x = 1;
            for (i= 0; i < colors.Length; i++) 
            { Console.WriteLine("Podaj kolor:");
               color = Console.ReadLine();
                colors[i]= color;
            }
            while (x < colors.Length) 
            {
                Console.WriteLine(x);
            }

        }
    }
}
