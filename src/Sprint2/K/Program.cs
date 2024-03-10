using System;
using System.IO;

public class Program
{
    private static TextReader reader;
    private static TextWriter writer;

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var number = ReadInt();
        writer.WriteLine(FibonacciRecursive(number));


        reader.Close();
        writer.Close();
    }
    private static int FibonacciRecursive(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}