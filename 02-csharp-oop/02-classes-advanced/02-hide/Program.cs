
using System;

namespace DSS.MethodNewHide
{
    // superclass 
    public class Parent
    {
        public void Show()
        {
            Console.WriteLine("I am instance of the class Parent.");
        }
    }

    // subclass
    public class Child : Parent
    {
        public new void Show()
        {
            Console.WriteLine("I am instance of the class Child.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            // obj = new Parent();
            // obj.Show();

            // obj = new Child();
            // obj.Show();

            // Child obj2 = new Child();
            // obj2.Show();

            Child obj2 = new Child();
            obj2.Show();

            Parent obj = obj2;
            obj.Show();

        }

    }
}
