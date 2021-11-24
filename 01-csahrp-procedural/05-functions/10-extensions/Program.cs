
using System;

namespace DSS.ExtensionMethods
{
    partial class Program
    {
        static void WriteMultipleLines(int z)
        {
            for (int i = 0; i < z; i++)
                Console.WriteLine("-- " + i + " --");
        }

        static void Main(string[] args)
        {
            int z = 2;
            WriteMultipleLines(z);
            Console.WriteLine("Hello World!");
            WriteMultipleLines(z);

            z = Extension.NumberOfLetters("123 Mickey Maus 123");
            Console.WriteLine(z);
            Console.WriteLine(Extension.Concatenate("Mickey Maus ", 2));
            Console.WriteLine(Extension.Concatenate("Mickey Maus ", 4));

            z = "123 Mickey Maus 123".NumberOfLetters();
            Console.WriteLine(z);
            Console.WriteLine("Mickey Maus  tla la la...".Concatenate(2));
            Console.WriteLine("Mickey Maus ".Concatenate(4));
        }

    }
}
