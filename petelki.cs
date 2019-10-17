using System;

namespace petelki
{
    class Program
    {
        static void Main(string[] args)
        {
            /* za pomocą instrukcji do while dla danych wartości zmieniających się w przedziale od 0 do 15
             * oblicza wartości funkcji y=4x
              */
            int x=0,y=0;
            do
            {
                Console.WriteLine("x: {0} y: {1}", x, y);
                x++;
                y = 4 * x;

            } while (x<= 15);
        }
    }
}
