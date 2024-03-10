using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class G
{
    private static TextReader reader;
    private static TextWriter writer;

    private static string GetBinaryNumber(int number)
    {
        var binnary_array = new List<int>();
        var temp = 0;

        do {
            temp = number % 2;
            number = number / 2;
            binnary_array.Add(temp);
        } while ((number != 0));

        binnary_array.Reverse();

        var sb = new StringBuilder(binnary_array.Count);
        binnary_array.ForEach(_ => sb.Append($"{_}"));
        return sb.ToString();
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var number = ReadInt();
        writer.WriteLine(GetBinaryNumber(number));

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}