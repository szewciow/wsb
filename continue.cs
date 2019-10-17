using System;

namespace choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            //continue
            int j = 1;
            for (; j<= 10; j++)
            { if (j == 2 || j == 5 || j == 7)
                    continue;
                else
                    Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
    }
}
