/*

LINQ (Language Integrated Query) is uniform query syntax in C# and VB.NET to retrieve data from different sources and formats. 
It is integrated in C# or VB, thereby eliminating the mismatch between programming languages and databases, as well as providing 
a single querying interface for different types of data sources.

For example, SQL is a Structured Query Language used to save and retrieve data from a database. In the same way, LINQ is a 
structured query syntax built in C# and VB.NET to retrieve data from different types of data sources such as collections, 
ADO.Net DataSet, XML Docs, web service and MS SQL Server and other databases.

LINQ queries return results as objects. It enables you to uses object-oriented approach on the result set and not to worry about 
transforming different formats of results into objects.

Advantages of LINQ

Familiar language: Developers don’t have to learn a new query language for each type of data source or data format.

Less coding: It reduces the amount of code to be written as compared with a more traditional approach.

Readable code: LINQ makes the code more readable so other developers can easily understand and maintain it.

Standardized way of querying multiple data sources: The same LINQ syntax can be used to query multiple data sources.

Compile time safety of queries: It provides type checking of objects at compile time.

IntelliSense Support: LINQ provides IntelliSense for generic collections.

Shaping data: You can retrieve data in different shapes.
 
 */

using System;
using System.Linq;

namespace RS2.SimpleLinq
{
    // delegat koji predstavlja uslov
    delegate bool FindStudent(Student std);

    class Student
    {
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }

    static class StudentExtension
    {
        public static Student[] Uslov1(this Student[] stdArray, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach (Student std in stdArray)
                if (del(std))
                {
                    result[i] = std;
                    i++;
                }

            return result;
        }


        public static Student[] Uslov2(this Student[] stdArray, Predicate<Student> predikat)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach (Student std in stdArray)
                if (predikat(std))
                {
                    result[i] = std;
                    i++;
                }
            return result;
        }
        public static void PrikaziNaKonzoli(this Student[] stdArray)
        {
            foreach (Student s in stdArray)
                if (s != null)
                    Console.WriteLine("{0} - {1}, {2}", s.StudentId, s.StudentName, s.Age);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Student[] sviStudenti = {
            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
            new Student() { StudentId = 6, StudentName = "Chris",  Age = 17 } ,
            new Student() { StudentId = 7, StudentName = "Rob", Age = 19  }
            };

            // Use extension function and anonimous delegate to find students within age interval
            Student[] students = sviStudenti.Uslov1(delegate (Student std)
            {
                return std.Age > 12 && std.Age < 20;
            });
            students.PrikaziNaKonzoli();
            Console.WriteLine("---");

            // Use extension function and anonimous delegate to find first student whose StudentId is 5
            students = sviStudenti.Uslov1(delegate (Student std)
            {
                return std.StudentId == 5;
            });
            students.PrikaziNaKonzoli();
            Console.WriteLine("---");

            // Use extension function and lambda expession delegate to find first student whose name is Bill 
            students = sviStudenti.Uslov1(std => std.StudentName == "Bill");
            students.PrikaziNaKonzoli();
            Console.WriteLine("---");

            // Use extension function and lambda expression predicate to find students within age interval
            students = sviStudenti.Uslov2(std => std.Age > 12 && std.Age < 20);
            students.PrikaziNaKonzoli();
            Console.WriteLine("---");

            // Use LINQ (method syntax) to find students within age interval  
            students = sviStudenti.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            students.PrikaziNaKonzoli();
            Console.WriteLine("---");

            // Use LINQ (query syntax) to find students within age interval  
            var studentiEnum = from s in sviStudenti
                       where(s.Age > 12 && s.Age < 20)
                       select s;
            studentiEnum.ToArray().PrikaziNaKonzoli();
            Console.WriteLine("---");

            // Use LINQ (method syntax) to find first student whose name is Bill 
            Student bill = sviStudenti.Where(s => s.StudentName == "Bill").FirstOrDefault();
            Console.WriteLine("{0} - {1}, {2}", bill.StudentId, bill.StudentName, bill.Age);
            Console.WriteLine("---");

            // Use LINQ (query syntax) to find first student whose name is Bill 
            studentiEnum = from s in sviStudenti
                           where s.StudentName == "Bill"
                           select s;
            bill = studentiEnum.FirstOrDefault();
            Console.WriteLine("{0} - {1}, {2}", bill.StudentId, bill.StudentName, bill.Age);
            Console.WriteLine("---");


            // Use LINQ (method syntax) to find student whose StudentId is 5
            Student student5 = sviStudenti.FirstOrDefault(s => s.StudentId == 5);
            Console.WriteLine("{0} - {1}, {2}", student5.StudentId, student5.StudentName, student5.Age);
            Console.WriteLine("---");

            // Use LINQ (query syntax) to find student whose StudentId is 5
            studentiEnum = from s in sviStudenti
                           where s.StudentId == 5
                           select s;
            student5 = studentiEnum.FirstOrDefault();
            Console.WriteLine("{0} - {1}, {2}", student5.StudentId, student5.StudentName, student5.Age);
            Console.WriteLine("---");

        }

    }
}




