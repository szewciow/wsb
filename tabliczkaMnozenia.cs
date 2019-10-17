using System;

namespace tabliczkaMnozenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1, z;
           
            do
            {
                do {
                    z = x * y;
                    Console.Write(z+"\t");
                    y++;
                } while (y <= 10);
                y = 1;
                Console.WriteLine("");
                x++;
            } while (x <= 10);
        }
    }
}
