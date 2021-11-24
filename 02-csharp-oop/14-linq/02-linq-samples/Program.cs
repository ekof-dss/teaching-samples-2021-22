/*
 */

using System;
using System.Collections.Generic;
using System.Linq;

IList<Student> studentList = new List<Student>() {
    new Student() { StudentId = 1, StudentName = "John", Age = 18, StandardId = 1 } ,
    new Student() { StudentId = 2, StudentName = "Steve",  Age = 21, StandardId = 1 } ,
    new Student() { StudentId = 3, StudentName = "Bill",  Age = 18, StandardId = 2 } ,
    new Student() { StudentId = 4, StudentName = "Ram" , Age = 20, StandardId = 2 } ,
    new Student() { StudentId = 5, StudentName = "Ron" , Age = 21 }
};

IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardId = 1, StandardName = "Standard 1"},
    new Standard(){ StandardId = 2, StandardName = "Standard 2"},
    new Standard(){ StandardId = 3, StandardName = "Standard 3"}
};

// LINQ filter on combined criteria (query sintax)
Console.WriteLine("LINQ filter on combined criteria (query sintax)");
var teenStudentsName = from s in studentList
                       where s.Age > 12 && s.Age < 20
                       select new { StudentName = s.StudentName };
teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
Console.WriteLine("---");

// LINQ filter on combined criteria (method sintax)
Console.WriteLine("LINQ filter on combined criteria (method sintax)");
teenStudentsName = studentList.Where(s => s.Age > 12 && s.Age < 20)
    .Select(s => new { StudentName = s.StudentName });
teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
Console.WriteLine("---");

// LINQ multiple filter and select (query sintax)
Console.WriteLine("LINQ multiple filter and select (query sintax)");
var studentNames2 = from s in studentList
                    where s.Age > 18
                    where s.StandardId > 0
                    select s.StudentName;
studentNames2.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine("---");

// LINQ multiple filter and select (method sintax)
Console.WriteLine("LINQ multiple filter and select (method sintax)");
studentNames2 = studentList.Where(s => s.Age > 18)
                              .Select(s => s)
                              .Where(st => st.StandardId > 0)
                              .Select(s => s.StudentName);
studentNames2.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine("---");

// LINQ that returns collection of anonymous objects (query sintax)
Console.WriteLine("LINQ that returns collection of anonymous objects (query sintax)");
var teenStudentsName2 = from s in studentList
                        where s.Age > 12 && s.Age < 20
                        select new { ImeStudenta = s.StudentName + "2" };
teenStudentsName2.ToList().ForEach(s => Console.WriteLine(s.ImeStudenta));
Console.WriteLine("---");

// LINQ that returns collection of anonymous objects (method sintax)
Console.WriteLine("LINQ that returns collection of anonymous objects (method sintax)");
teenStudentsName2 = studentList.Where(s => s.Age > 12 && s.Age < 20)
    .Select(s => new { ImeStudenta = s.StudentName + "3" });
teenStudentsName2.ToList().ForEach(s => Console.WriteLine(s.ImeStudenta));
Console.WriteLine("---");

// LINQ group by (query sintax)
Console.WriteLine("LINQ group by (query sintax)");
var studentsGroupByStandard = from s in studentList
                              group s by s.StandardId into sg
                              orderby sg.Key
                              select new { StandardId = sg.Key, Students = sg };
foreach (var group in studentsGroupByStandard)
{
    Console.WriteLine("StandardId {0}:", group.StandardId);
    group.Students.ToList().ForEach(st => Console.WriteLine(st.StudentName));
}
Console.WriteLine("---");

// LINQ group by (method sintax)
Console.WriteLine("LINQ group by (method sintax)");
studentsGroupByStandard = studentList.GroupBy(s => s.StandardId)
    .OrderBy(sg => sg.Key)
    .Select(sg => new { StandardId = sg.Key, Students = sg });
foreach (var group in studentsGroupByStandard)
{
    Console.WriteLine("StandardId {0}:", group.StandardId);
    group.Students.ToList().ForEach(st => Console.WriteLine(st.StudentName));
}
Console.WriteLine("---");

// LINQ filter then group by (query sintax)
Console.WriteLine("LINQ filter then group by (query sintax)");
var studentiGrupisaniPoStandardu2 = from s in studentList
                                    where s.StandardId > 0
                                    group s by s.StandardId into sg
                                    orderby sg.Key
                                    select new { StandardId = sg.Key, GrupaStudenata = sg };
foreach (var group in studentiGrupisaniPoStandardu2)
{
    Console.WriteLine("StandardId {0}:", group.StandardId);
    group.GrupaStudenata.ToList().ForEach(st => Console.WriteLine(st.StudentName));
}
Console.WriteLine("---");

// LINQ filter then group by (method sintax)
Console.WriteLine("LINQ filter then group by (method sintax)");
studentiGrupisaniPoStandardu2 = studentList.Where(s => s.StandardId > 0)
    .GroupBy(s => s.StandardId)
    .OrderBy(sg => sg.Key)
    .Select(sg => new { StandardId = sg.Key, GrupaStudenata = sg });
foreach (var group in studentiGrupisaniPoStandardu2)
{
    Console.WriteLine("StandardId {0}:", group.StandardId);
    group.GrupaStudenata.ToList().ForEach(st => Console.WriteLine(st.StudentName));
}
Console.WriteLine("---");

// LINQ inner join (query sintax)
Console.WriteLine("LINQ inner join (query sintax)");
var studentsWithStandard = from std in standardList
                           join stu in studentList
                           on std.StandardId equals stu.StandardId
                           select new
                           {
                               StudentName = stu.StudentName,
                               StandardName = std.StandardName
                           };

studentsWithStandard.ToList().ForEach(s => Console.WriteLine("{0} is in {1}", s.StudentName, s.StandardName));
Console.WriteLine("---");

// LINQ inner join (method sintax)
Console.WriteLine("LINQ inner join (method sintax)");
studentsWithStandard = standardList.Join(studentList,
    std => std.StandardId,
    stu => stu.StandardId,
    (std, stu) => new
    {
        StudentName = stu.StudentName,
        StandardName = std.StandardName
    })
    .OrderBy(rec => rec.StandardName)
    .ThenBy(rez => rez.StudentName);
foreach (var group in studentsWithStandard)
{
    Console.WriteLine("{0} is in {1}", group.StudentName, group.StandardName);
}
Console.WriteLine("---");

// LINQ left outer join (query sintax)
Console.WriteLine("LINQ left outer join (query sintax)");
var studentsWithStandard9 = from std in standardList
                            join stu in studentList on std.StandardId equals stu.StandardId into jn
                            from subjn in jn.DefaultIfEmpty()
                            select new { std, subjn };

foreach (var x in studentsWithStandard9)
{
    string studentName = "None";
    if (x.subjn != null)
        if (x.subjn.StudentName != null)
            studentName = x.subjn.StudentName;
    Console.WriteLine("{0} is in {1}", studentName, x.std.StandardName);
}
Console.WriteLine("---");

// LINQ left outer join (method sintax)
Console.WriteLine("LINQ left outer join (method sintax)");
var studentsWithStandard2 = standardList.GroupJoin(
    studentList,
    std => std.StandardId,
    stu => stu.StandardId,
    (std, stu) => new
    {
        Student = stu,
        Standard = std
    })
    .SelectMany(x => x.Student.DefaultIfEmpty(),
    (std, stu) => new
    {
        Student = stu,
        Standard = std
    });
foreach (var x in studentsWithStandard2)
{
    string studentName = "None";
    if (x.Student != null)
        if (x.Student.StudentName != null)
            studentName = x.Student.StudentName;
    Console.WriteLine("{0} is in {1}", studentName, x.Standard.Standard.StandardName);
}
Console.WriteLine("---");

// LINQ nested query (query sintax)
Console.WriteLine("LINQ nested query (query sintax)");
var nestedQueries = from s in studentList
                    where s.Age > 18 && s.StandardId ==
                        (from std in standardList
                         where std.StandardName == "Standard 1"
                         select std.StandardId).FirstOrDefault()
                    select s;
nestedQueries.ToList().ForEach(s => Console.WriteLine(s.StudentName));
Console.WriteLine("---");
