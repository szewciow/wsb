using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź liczbe całkowitą: ");
            string x = Console.ReadLine();
            //int number = uint.Parse(x);

            try
            {
                uint number = uint.Parse(x);
            }
            catch (SystemException e)
            { //COnsole.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
             

            Console.ReadKey();

        }
    }
}
