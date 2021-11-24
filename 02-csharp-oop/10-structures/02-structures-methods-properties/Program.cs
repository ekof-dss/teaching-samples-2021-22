/*

In C#, struct is the value type data type that represents data structures. It can contain a parameterized constructor, static 
constructor, constants, fields, methods, properties, indexers, operators, events, and nested types.

struct can be used to hold small data values that do not require inheritance, e.g. coordinate points, key-value pairs, and 
complex data structure. 

*/


using System;

namespace RS2.StructuresMethodsProperties
{
    struct Coordinate
    {
        private int _x;
        private int _y;

        public int x {
            get { return _x; }
            set { _x = value; } 
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SetOrigin()
        {
            _x = 0;
            _y = 0;
        }

        public static Coordinate GetOrigin()
        {
            return new Coordinate();
        }

    }

    class Program
    {
        static void Main()
        {
            Coordinate point = new Coordinate(10,20);
            Console.WriteLine(point.x);  
            Console.WriteLine(point.y);
            Console.WriteLine("---");

            point.SetOrigin();
            point.x += 2;
            point.y -= 3;
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine("---");

            Coordinate point2 = Coordinate.GetOrigin();
            Console.WriteLine(point2.x);
            Console.WriteLine(point2.y);
            Console.WriteLine("---");

        }

    }
}

