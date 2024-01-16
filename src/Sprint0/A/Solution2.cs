using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Пример считывания пар чисел, которые записаны в одной строке. 
/// </summary>
public class Solution2
{
    private static TextReader reader;
    private static TextWriter writer;

    //public static void Main(string[] args)
    //{
    //    reader = new StreamReader(Console.OpenStandardInput());
    //    writer = new StreamWriter(Console.OpenStandardOutput());

    //    var numbers = ReadList();
    //    writer.WriteLine(numbers[0] + numbers[1]);

    //    reader.Close();
    //    writer.Close();
    //}

    private static List<int> ReadList()
    {
        return reader.ReadLine()
            .Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
    }
}