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
        var first_array = ReadArray();
        var second_array = ReadArray();
        var result_array = new int[n * 2];

        for (int i = 0; i < result_array.Length; i++)
        {
            if (i % 2 == 0)
            {
                result_array[i] = first_array[i / 2];
            }
            else
            {
                result_array[i] = second_array[i / 2];
            }
        }

        for (int i = 0; i < result_array.Length; i++)
        {
            writer.Write("{0} ", result_array[i]);
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