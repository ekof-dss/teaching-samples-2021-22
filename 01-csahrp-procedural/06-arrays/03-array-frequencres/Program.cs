using System;

namespace DSS.ArrayFrequences
{
    class Program
    {
        static int CalculateLowerBound(int[] data)
        {
            int ret = data[0];
            for (int i = 1; i < data.Length; i++)
                if (data[i] < ret)
                    ret = data[i];
            return ret;
        }

        static int CalculateUpperBound(int[] data)
        {
            int ret = data[0];
            for (int i = 1; i < data.Length; i++)
                if (data[i] > ret)
                    ret = data[i];
            return ret;
        }

        static void CalculateFrequences(int[] data, int[] freq, int lowerBound)
        {
            for (int i = 0; i < freq.Length; i++)
                freq[i] = 0;
            foreach (int x in data)
                freq[x - lowerBound]++;
        }

        static void WriteFrequncesNumeric(int[] freq, int lb)
        {
            for (int i = 0; i < freq.Length; i++)
                System.Console.Write("{0}:{1} {2}", (i + lb), freq[i],
                    ((i + 1) % 8 == 0) ? "\n" : "\t");
        }

        static void WriteFrequncesGraph(int[] freq, int lb)
        {
            for (int i = 0; i < freq.Length; i++)
            {
                System.Console.Write("{0}:", i + lb);
                for (int j = 0; j < freq[i]; j++)
                    System.Console.Write("*");
                System.Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] results =
                    {7, 2, 3, 3, 3, 4, 9, 7, 6, 3, 4, 5, 10, 4, 3, 5, 3,
                        4, 5, 3, 3, 2, 5, 7, 9, 1};
            System.Console.WriteLine("Data:");
            foreach (int x in results)
                System.Console.Write("{0}", x);
            int loBound = CalculateLowerBound(results);
            int upBound = CalculateUpperBound(results);
            int[] repetitions = new int[upBound - loBound + 1];
            CalculateFrequences(results, repetitions, loBound);
            System.Console.WriteLine();
            System.Console.WriteLine("Frequency (numerical):");
            WriteFrequncesNumeric(repetitions, loBound);
            System.Console.WriteLine();
            System.Console.WriteLine("Frequency (histogram):");
            WriteFrequncesGraph(repetitions, loBound);
        }
    }
}
