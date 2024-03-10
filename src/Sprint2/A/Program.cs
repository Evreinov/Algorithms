using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    private static TextReader reader;
    private static TextWriter writer;

    public static List<List<int>> Transposition(int n, int m, List<List<int>> array)
    {
        var result = new List<List<int>>();

        for (int i = 0; i < array[0].Count; i++) //m
        {
            var list = new List<int>();
            for (int j = 0; j < array.Count; j++) //n
            {
                list.Add(array[j][i]);
            }

            result.Add(list);
        }
        return result;
    }
    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var m = ReadInt();
        if (n == default || m == default)
        {
            return;
        }
        var array = ReadMatrix(n);
        var result = Transposition(n, m, array);
        WriteMatrix(result);

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }

    private static List<int> ReadList()
    {
        return reader.ReadLine()
            .Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
    }

    private static List<List<int>> ReadMatrix(int rows)
    {
        var result = new List<List<int>>();

        for (var idx = 0; idx < rows; idx++)
        {
            result.Add(ReadList());
        }

        return result;
    }

    private static void WriteMatrix(List<List<int>> matrix)
    {
        matrix.ForEach(_ => writer.WriteLine(string.Join(" ", _)));
    }
}