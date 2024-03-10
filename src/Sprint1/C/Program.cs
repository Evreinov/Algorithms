using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class C
{
    private static TextReader reader;
    private static TextWriter writer;

    private static List<int> GetNeighbours(List<List<int>> matrix, int row, int col)
    {
        var result = new List<int>();

        var left_element = col - 1;
        if (left_element >= 0)
        {
            result.Add(matrix[row][left_element]);
        }

        var right_element = col + 1;
        if (right_element < matrix.First().Count)
        {
            result.Add(matrix[row][right_element]);
        }

        var top_element = row - 1;
        if (top_element >= 0)
        {
            result.Add(matrix[top_element][col]);
        }

        var bottom_element = row + 1;
        if (bottom_element < matrix.Count)
        {
            result.Add(matrix[bottom_element][col]);
        }

        result.Sort();

        return result;
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var rows = ReadInt();
        var cols = ReadInt();
        var matrix = ReadMatrix(rows);
        var rowId = ReadInt();
        var colId = ReadInt();
        var neighbours = GetNeighbours(matrix, rowId, colId);

        writer.WriteLine(string.Join(" ", neighbours));

        reader.Close();
        writer.Close();
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

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}