
using System;
using System.Text;

namespace DSS.OptionalParams
{
    class Program
    {
        static void WriteStartFinish(int startWith = 40, int finishWith = 42)
        {
            int i = startWith;
            while (i <= finishWith)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void WriteMultiLpleines(int numberOfLines = 2)
        {
            for (int i = 0; i < numberOfLines; i++)
                Console.WriteLine("-- " + i + " --");
        }

        static int CountLetters(string s)
        {
            int ret = 0;
            foreach (char ch in s)
            {
                if (ch >= 'a' && ch <= 'z')
                    ret++;
                if (ch >= 'A' && ch <= 'Z')
                    ret++;
            }
            return ret;
        }

        static string Concatenate(string s, int brojPonavljanja = 2)
        {
            if (brojPonavljanja <= 1)
                return s;
            StringBuilder builder = new StringBuilder(s);
            for (int i = 1; i < brojPonavljanja; i++)
            {
                builder.Append(s);
            }
            return builder.ToString();
        }

        static public void ShowData(string fname = "John", int age = 20,
            string lname = "Doe")
        {
            Console.WriteLine("Full name: {0} {1}", fname, lname);
            Console.WriteLine("Age: {0}", age);
        }

        static void Main(string[] args)
        {
            WriteStartFinish(35, 40);
            WriteStartFinish();
            Console.WriteLine("---");

            WriteStartFinish(finishWith: 35, startWith: 40);
            WriteStartFinish(finishWith:35);
            Console.WriteLine("---");

            WriteMultiLpleines(3);
            WriteMultiLpleines();
            Console.WriteLine("---");

            int z = CountLetters("123 Mickey Maus 123");
            Console.WriteLine(z);
            Console.WriteLine(Concatenate("Mickey Maus ", 4));
            Console.WriteLine(Concatenate("Donald Duck "));
            Console.WriteLine(Concatenate(brojPonavljanja:3, s: "Peter Duck "));
            Console.WriteLine("---");

            ShowData("Ronald", 90, "Duck");
            ShowData("Mickey", 95);
            ShowData("Ronald");
            ShowData();
            ShowData(lname: "Duck", fname: "Donald");
            ShowData(lname: "Duck");
            Console.WriteLine("---");
        }
    }
}

