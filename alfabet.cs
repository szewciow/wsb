using System;

namespace alfabet
{
    class Program
    {
        static void Main(string[] args)
        {

            for (char a = 'A'; a != 'Z'; a++)
            { Console.Write(a + " "); 
            }
            Console.WriteLine("");

            for (char b = 'Z'; b != 'A'; b--)
            {
                Console.Write(b+" ");
            }
        }
    }
}
