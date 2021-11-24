
using System;

namespace DSS.MethodOverride
{
    // parent class 
    public class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("I am instance of the class Parent.");
        }
    }

    // derived class 
    public class Child : Parent
    {
        // virtual method 
        public override void Show()
        {
            Console.WriteLine("I am instance of the class Child.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Parent obj;

            obj = new Parent();
            obj.Show();

            obj = new Child();
            obj.Show();
        }

    }
}
