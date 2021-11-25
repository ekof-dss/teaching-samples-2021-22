using System;

namespace DDD.ArrayWrite
{
    class Program
    {
        static void WriteToConsole(byte[] bArr)
        {
            for (int i = 0; i < bArr.Length; i++)
            {
                Console.Write(bArr[i] + " ");
            }
            Console.WriteLine();
        }

        static void WriteToConsole(string[] sArr)
        {
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.Write(sArr[i] + " ");
            }
            Console.WriteLine();
        }

        static void WriteToConsole(int[] iArr)
        {
            foreach (int i in iArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            byte[] bytA = new byte[10];
            bytA[2] = 45;
            WriteToConsole(bytA);

            String s = " special";
            String[] seasons = { " spring", " autumn", s + " witner", " summer" };
            WriteToConsole(seasons);

            int[] arr = { 24, 48, 96, 192, 36, 72, 144 };
            WriteToConsole(arr);

            string[] strA = new string[40];
            strA[2] = "mickey";
            strA[3] = "mouse";
            strA[4] = "donald";
            strA[5] = "duck";
            strA[6] = "goofy";
            strA.WriteToConsole();

        }
    }
}
