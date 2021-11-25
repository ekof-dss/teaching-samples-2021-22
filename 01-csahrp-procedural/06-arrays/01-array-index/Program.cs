using System;

namespace DSS.ArrayIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strA = new string[40];
            strA[2] = "mickey";
            strA[3] = "mouse";

            byte[] bytA = new byte[10];
            bytA[2] = 45;

            String s = " special";
            String[] seasons = { " spring", " autumn", s + " witner", " summer" };
            System.Console.WriteLine(seasons);
            System.Console.WriteLine(seasons[1]);
            System.Console.WriteLine(seasons[2]);
            System.Console.WriteLine();

            int[] arr = {24, 48, 96, 192, 36, 72, 144 };
            System.Console.WriteLine(arr[0]);
            System.Console.WriteLine(arr[1]+arr[2]);
            System.Console.WriteLine(arr[11]); 
            System.Console.WriteLine(arr[arr.Length-1]);
            System.Console.WriteLine(arr);
        }
    }
}
