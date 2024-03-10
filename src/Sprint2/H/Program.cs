using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    private static TextReader reader;
    private static TextWriter writer;

    private static bool IsCorrectBracketSeq(string line)
    {
        var stack = new Stack<char>();
        foreach (var c in line.AsEnumerable())
        {
            if (c == '[' || c == '(' || c == '{')
            {
                stack.Push(c);
            }

            if (!stack.Any())
            {
                return false;
            }

            if (c == ']')
            {
                var openBracket = stack.Pop();
                if ('[' != openBracket)
                {
                    return false;
                }
            }
            if (c == ')')
            {
                var openBracket = stack.Pop();
                if ('(' != openBracket)
                {
                    return false;
                }
            }
            if (c == '}')
            {
                var openBracket = stack.Pop();
                if ('{' != openBracket)
                {
                    return false;
                }
            }
        } 
        return !stack.Any();
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var line = reader.ReadLine();
        writer.WriteLine(IsCorrectBracketSeq(line));

        reader.Close();
        writer.Close();
    }
}