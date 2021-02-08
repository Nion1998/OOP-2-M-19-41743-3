using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Triangle
    {

        private int x;
        private int y;
        private int z;

        public Triangle()
        {
            Console.WriteLine(" Default Constructor");
        }

        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public int Z
        {
            set { z = value; }
            get { return z; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("X is :" + x);
            Console.WriteLine("Y is :" + y);
            Console.WriteLine("Z is :" + z);
            Console.WriteLine("The Triange is :" + TestTriangle());


        }

        private string TestTriangle()
        {
            if (x == y && x == z)
                return " equilateral";
            else if (x == y || x == z || y == z)
                return " isosceles";
            else
                return " scalene ";

        } 
    }
}
