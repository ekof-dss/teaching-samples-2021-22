/*

The lambda expression is a shorter way of representing anonymous method using some special syntax. 

Any lambda expression can be converted to a delegate type. The delegate type to which a lambda expression can be converted is 
defined by the types of its parameters and return value. 

If a lambda expression doesn't return a value, it can be converted to one of the Action delegate types; otherwise, it can be 
converted to one of the Func delegate types. 

For example, a lambda expression that has two parameters and returns no value can be converted to an Action<T1,T2> delegate. 

A lambda expression that has one parameter and returns a value can be converted to a Func<T,TResult> delegate. 

*/

using System;

namespace RS2.SimpleLambda
{

    public class Program
    {
        public class Student
        {
            private string name;
            private int age;

            public Student(string name = "XXX", int age = 18)
            {
                this.name = name;
                this.age = age;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }
        }

        static void Main(string[] args)
        {
            // akcija preko lambde
            Action linija = () => Console.WriteLine();

            // jos jedna akcija preko lambde
            Action<string> upisiPaLinija = x => Console.WriteLine(x);

            // funkcija preko lambda izraza
            Func<int, int> square = x => x * x;
            upisiPaLinija(square(5).ToString());
            linija();

            // jos jedna funkcija preko lambda izraza
            Func<decimal, decimal, decimal, decimal> add3d = (x, y, z) => (x + y + z);
            decimal res = add3d(10.5M, 10M, 10.48M);
            Console.WriteLine(res);
            linija();

            // predikat preko delegata
            Predicate<Student> upitTeen = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

            // isti predikat preko lambda izraza
            upitTeen = s => (s.Age > 12 && s.Age < 20);

            // koriscenje pretikata
            Student[] studenti =
            {
                new Student("Zeljko Sasic", 22),
                new Student("Mitar Miric", 19),
                new Student("Dragana Mirkovic", 15)
            };
            foreach( Student s in studenti)
            {
                if (upitTeen(s))
                    Console.WriteLine("Student {0}, godina {1}", s.Name, s.Age);
            }
            linija();
        }
    }

}

