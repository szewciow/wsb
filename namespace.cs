using System;
using First_name;


using Outer.Middle.Inner;

namespace @namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*gdy używamy bibliotek to using system
            System.Console.WriteLine();*/

            First_name.name_1 ob1 = new First_name.name_1();
            ob1.Show();

            name_2 ob2 = new name_2();
            ob2.Show();

            Prog ob3 = new Prog();
            Console.WriteLine(ob3.Add(3, 5));






            Console.ReadKey();
        }
    }
}

namespace First_name
{
    class name_1
    {
        public void Show()
        {
            Console.WriteLine("PIerwsza przestrzeń nazw");
        }
    }

}

namespace Second_name
{
    class name_1
    {
        public void Show()
        {
            Console.WriteLine("Druga przestrzeń nazw");
        }
    }

}


namespace Outer
{
    namespace Middle
    { namespace Inner
        { class Prog
            {
                public int x, y;

                public int Add(int x, int y)
                {
                    return x + y;
                }
            }
        }
    }




       
}
