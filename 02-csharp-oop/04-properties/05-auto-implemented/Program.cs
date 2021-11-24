
using System;

namespace DSS.SimpleProperty
{
    class Program
    {
        static void Main()
        {
            Message p = new Message();
            p.Contents = "Mickey Mouse";
            Console.WriteLine("Message contents after propery set: {0}", p.Contents);
            Console.Write("Alternative display of the message contens: ");
            p.WriteToConsole();
        }

    }
}



