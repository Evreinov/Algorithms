using System;
using System.Collections.Generic;
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

        var (n, k) = Read();
        var d = Math.Pow(10, k);
        writer.WriteLine(FibonacciMod(n, d));

        reader.Close();
        writer.Close();
    }

    private static double FibonacciMod(int n, double d)
    {
        var a = 1d;
        var b = 1d;
        double result = 0;
        if (n <= 1)
        {
            return 1;
        }
        for (int i = 0; i < n - 1; i++)
        {
            var s = (a + b) % d;
            a = b;
            b = s;
            result = b;
        }
        return result;
    }

    private static (int n, int k) Read()
    {
        var line = ReadList();
        return (line[0], line[1]);
    }

    private static List<int> ReadList()
    {
        return reader.ReadLine()
            .Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
    }
}