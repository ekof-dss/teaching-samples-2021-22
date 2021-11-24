/*

In C#, struct is the value type data type that represents data structures. It can contain a parameterized constructor, static 
constructor, constants, fields, methods, properties, indexers, operators, events, and nested types.

struct can be used to hold small data values that do not require inheritance, e.g. coordinate points, key-value pairs, and 
complex data structure. 

*/


using System;

namespace RS2.StructuresEvents
{
    public enum Dimension { X, Y };

    public class CoordinatesChangedEventArgs : EventArgs
    {
        public CoordinatesChangedEventArgs( Dimension dim, int newVal)
        {
            Dimension = dim;
            NewValue = newVal;
        }

        public Dimension Dimension { get; set; }
        public int NewValue { get; set; }
    }

    struct Coordinate
    {
        public event Action<CoordinatesChangedEventArgs> CoordinatesChanged;

        private int _x;
        private int _y;

        public int x
        {
            get { return _x; }
            set
            {
                _x = value;
                CoordinatesChanged(new CoordinatesChangedEventArgs(Dimension.X, _x));
            }
        }
        public int y
        {
            get { return _y; }
            set
            {
                _y = value;
                CoordinatesChanged(new CoordinatesChangedEventArgs(Dimension.Y, _y));
            }
        }

        public void SetOrigin()
        {
            x = 0;
            y = 0;
        }

    }

    class Program
    {
        static void StructEventHandler(CoordinatesChangedEventArgs ccea)
        {
            Console.WriteLine("EH: Coordinate {0} changed to {1}", ccea.Dimension, ccea.NewValue);
        }

        static void Main()
        {
            Coordinate point = new Coordinate();
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine("---");

            point.CoordinatesChanged += StructEventHandler;

            point.x += 2;
            point.y -= 3;
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine("---");

            point.SetOrigin();            
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine("---");
        }

    }
}

