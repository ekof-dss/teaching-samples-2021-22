namespace DSS.PropertyHiding
{

    public class Employee
    {
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
    }

    public class Manager : Employee
    {
        private string fullName;

        // Notice the use of the new modifier:
        public new string FullName
        {
            get { return fullName; }
            set { fullName = "manager " + value; }
        }
    }

    class Program
    {
        static void Main()
        {
            Manager d1 = new Manager();

            // Derived class property.
            d1.FullName = "proffesor Xavier";

            // Base class property.
            ((Employee)d1).FullName = "Storm";

            System.Console.WriteLine("Full name from derived class: {0}", d1.FullName);
            System.Console.WriteLine("Full name from superclass: {0}", ((Employee)d1).FullName);
        }
    }
}


