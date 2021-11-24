
using System;

namespace DSS.SimpleProperty
{
    class Program
    {
        static void Main()
        {
            Message p = new Message();
            Console.WriteLine("Contents of the message after creation: {0}", p.Contents);

            p.Contents = "Mickey Mouse";
            Console.WriteLine("Contents of the message after property set: {0}", p.Contents);
            Console.Write("Alternative display of the message: ");
            p.WriteToConsole();
        }

    }
}



