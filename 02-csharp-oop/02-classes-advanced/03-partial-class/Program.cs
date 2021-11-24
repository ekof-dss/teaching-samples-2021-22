
using System;

namespace DSS.PartiallClass
{
    public partial class Program
    {
        static void WriteMultipleLines(int z)
        {
            for (int i = 0; i < z; i++)
                Console.WriteLine("-- " + i + " --");
        }

        public static void Main(string[] args)
        {
            WriteTo42();
            int z = 2;
            WriteMultipleLines(z);
            Console.WriteLine("Hello World!");
            WriteMultipleLines(z);
        }

    }
}
