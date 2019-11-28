using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktury
{
    class Program
    {
        public struct Punkt
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt();
            punkt1.x = 5;
            punkt1.x = 15;

            Punkt punkt2;
            //Punkt punkt2=new Punkt();
            punkt2.x = 1;
            punkt2.y = 2;



            Console.WriteLine("Punkt1: x={0}, y={0}",punkt1.x,punkt1.y);
            Console.WriteLine("Punkt2: x={0}, y={0}",punkt2.x,punkt2.y);

            Console.ReadKey();
        }
    }
}
