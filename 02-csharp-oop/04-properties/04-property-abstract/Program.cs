namespace DSS.PropertyAbstract
{

    abstract class Shape
    {
        public abstract double Area
        {
            get;
            set;
        }
    }

    class Square : Shape
    {
        private double side;

        public double Side
        {
            get { return side; }
        }

        public Square(double a)
        {
            side = a;
        }

        public override double Area
        {
            get { return side * side; }
            set { side = System.Math.Sqrt(value); }
        }
    }

    class Cube : Shape
    {
        private double side;
        public double Side
        {
            get { return side; }
        }

        public Cube(double a)
        {
            side = a;
        }

        public override double Area
        {
            get { return 6 * side * side; }
            set { side = System.Math.Sqrt(value / 6); }
        }
    }

    class Program
    {
        static void Main()
        {
            System.Console.Write("Length of the side: ");
            double side = double.Parse(System.Console.ReadLine());

            Square sq = new Square(side);
            Cube cu = new Cube(side);

            System.Console.WriteLine("Area of the square = {0:F2}", sq.Area);
            System.Console.WriteLine("Area of the cube = {0:F2}", cu.Area);
            System.Console.WriteLine();

            System.Console.Write("Area of the shape: ");
            double area = double.Parse(System.Console.ReadLine());

            sq.Area = area;
            cu.Area = area;

            System.Console.WriteLine("Ivica kvadrata = {0:F2}", sq.Side);
            System.Console.WriteLine("Ivica kocke = {0:F2}", cu.Side);
        }
    }
}



