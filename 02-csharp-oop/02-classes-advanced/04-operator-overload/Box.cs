using System;

namespace DSS.OperatorOverload
{
    public class Box
    {
        private double length;    // Length of a box
        private double breadth;   // Breadth of a box
        private double height;    // Height of a box

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
        public static bool operator ==(Box lhs, Box rhs)
        {
            if (lhs.length == rhs.length && lhs.height == rhs.height
                && lhs.breadth == rhs.breadth)
            {

                return true;
            }
            return false;
        }
        public static bool operator !=(Box lhs, Box rhs)
        {
            if (lhs.length != rhs.length || lhs.height != rhs.height ||
                lhs.breadth != rhs.breadth)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Box lhs, Box rhs)
        {
            if (lhs.length < rhs.length && lhs.height < rhs.height
                && lhs.breadth < rhs.breadth)
            {

                return true;
            }
            return false;
        }
        public static bool operator >(Box lhs, Box rhs)
        {
            if (lhs.length > rhs.length && lhs.height >
                rhs.height && lhs.breadth > rhs.breadth)
            {

                return true;
            }
            return false;
        }
        public static bool operator <=(Box lhs, Box rhs)
        {
            if (lhs.length <= rhs.length && lhs.height
                <= rhs.height && lhs.breadth <= rhs.breadth)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(Box lhs, Box rhs)
        {
            if (lhs.length >= rhs.length && lhs.height
                >= rhs.height && lhs.breadth >= rhs.breadth)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }

        public override bool Equals(object obj)
        {
            if (obj is Box)
            {
                return this == (Box)obj;
            }
            return false;
        }


        public override int GetHashCode()
        {
            return 5 * (length).GetHashCode()
                + 7 * (breadth).GetHashCode()
                + 11 * (height).GetHashCode();
        }

    }
}