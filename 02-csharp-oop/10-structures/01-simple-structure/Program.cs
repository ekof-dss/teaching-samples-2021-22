/*

In C#, struct is the value type data type that represents data structures. It can contain a parameterized constructor, static 
constructor, constants, fields, methods, properties, indexers, operators, events, and nested types.

struct can be used to hold small data values that do not require inheritance, e.g. coordinate points, key-value pairs, and 
complex data structure. 

*/


using System;

namespace RS2.SimpleStructure
{
    struct Coordinate
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main()
        {
            Coordinate point1 = new Coordinate();
            Console.WriteLine(point1.x);  
            Console.WriteLine(point1.y);
            Console.WriteLine("---");

            point1.x = 5;
            point1.y = -7;
            Console.WriteLine(point1.x);
            Console.WriteLine(point1.y);
            Console.WriteLine("---");

            Coordinate point2;
            //Sledeca linija prouzrokuje gresku pri prevodjenju
            //Console.Write(point2.x);   

            point2.x = 10;
            point2.y = 20;
            Console.WriteLine(point2.x);   
            Console.WriteLine(point2.y);
            Console.WriteLine("---");
        }

    }
}

