using System;

namespace DDD.ArrayWrite
{
    public static class WriteThings
    {
        public static void WriteToConsole(this string[] sArr)
        {
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.Write(sArr[i] + " ");
            }
            Console.WriteLine();

        }

    }
}