using System;
using System.IO;

/// <summary>
/// Пример считывания данных.
/// </summary>
public class Solution1
{
    private static TextReader reader;
    private static TextWriter writer;

    //public static void Main(string[] args)
    //{
    //    reader = new StreamReader(Console.OpenStandardInput());
    //    writer = new StreamWriter(Console.OpenStandardOutput());

    //    var a = ReadInt();
    //    var b = ReadInt();
    //    writer.WriteLine(a + b);

    //    reader.Close();
    //    writer.Close();
    //}

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}