using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabliczki2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[,] values = new int[,]
                {
                    {1,2,3,4 },
                    { 5,6,7,8},
                    {9,10,11,12 },
                    {13, 14, 15, 16 },
                };

            for (int i = 0; i <values.GetLength(0); i++)
            { 
                for (int b = 0; b <values.GetLength(1); b++) 
                {
                    Console.Write("{0}\t ",values[i,b]); 
                }
                Console.WriteLine("");
            }
            Console.ReadKey();*/

            /*int[,] values = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    values[i,j] = i * 3 + j;
                }
            }


            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int b = 0; b < values.GetLength(1); b++)
                {
                    Console.Write("{0}\t ", values[i, b]);
                }
                Console.WriteLine("");
            }*/


            //tablice nieregularne

            string[][] country = new string[4][];

            Console.WriteLine("Rozmiar zewnętrznego wymiaru tablicy nieregularnej: {0}", country.Length);


            int[][] number = new int[3][]
                {
                    new int[]{ 1,2},
                    new int[]{ 3, 4, 5, 6},
                    new int[]{ 7},
                };

            /*Wyświetl zawartość tablicy number
             * 
             * number[0,0]=1
             * number[0,1]=2
             * 
             * number[1,0]=3
             * number[1,1]=4
             * number[1,2]=5
             * number[1,3]=6
             * 
             * number[2,0]=6*/

            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int b = 0; b < number[i].Length; b++)
                {
                    Console.Write("number[{0}][{1}]={2} ", number[i, b]);
                }
                Console.WriteLine("");
            }


            //uproszczone wyrażenia inicjalizacji tablic

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine(vowels[0]);//a

            byte[,] age =
                {
                { 20,30},
                {15, 35 },
                {25, 35}
            };
            Console.WriteLine(age[2, 0]);

            string[][] name =
                {
                    new string[] ("Katarzyna"),
                    new string[] ("Krzysztof", "anna"),
                    new string[]("Paweł")
                };
            Console.WriteLine(name[1][1]);//anna

            //ilosc wymiarow
            Console.WriteLine("Samogłoski: {0}", vowels.Rank);
            Console.WriteLine("Wiek: {0}", age.Rank);
            Console.WriteLine("Imiona: {0}", name.Rank);


            Console.ReadKey();
        }
    }

}
