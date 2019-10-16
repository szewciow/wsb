using System;

namespace gwizd
{
    class Program
    {
        static void Main(string[] args)
        {
            string z;
            z = Console.ReadLine();
            int w;
            if (int.TryParse(z, out w))
            {
                for (int a = 1; a <= w; a++)
                {
                    for (int b = 0; b < a; b++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
    }
}
