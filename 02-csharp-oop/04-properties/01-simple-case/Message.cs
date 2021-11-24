using System;

namespace DSS.SimpleProperty
{
    internal class Message
    {
        private string contents = "XXX";

        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }

        public void WriteToConsole()
        {
            Console.WriteLine(contents);
        }
    }
}