using System;
using System.IO;
using System.Linq;

public class Program
{
    private static TextReader reader;
    private static TextWriter writer;

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var inputArray = ReadArray();
        var k = ReadInt();
        var resultArray = new double[n + 1 - k];

        var currentSum = .0;

        for (int i = 0; i < resultArray.Length; i++)
        {
            if (i == 0)
            {
                for (int j = 0; j < k; j++)
                {
                    currentSum += inputArray[j];
                }
            }
            else
            {
                var delta = i - 1;
                currentSum = currentSum - inputArray[delta] + inputArray[delta + k];
            }
            resultArray[i] = currentSum / k;
        }

        foreach (var t in resultArray)
        {
            writer.Write("{0} ", t);
        }

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }

    private static int[] ReadArray()
    {
        return reader.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}