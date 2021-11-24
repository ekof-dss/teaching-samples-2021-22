using System;

namespace DSS.SimpleProperty
{
    internal class Message
    {
        public string Contents
        {
            get;
            set;
        }

        public void WriteToConsole()
        {
            Console.WriteLine(Contents);
        }
    }
}