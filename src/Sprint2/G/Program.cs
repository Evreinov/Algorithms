using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        var stack = new StackMax();
        var totalCommands = ReadInt();
        for (int i = 0; i < totalCommands; i++)
        {
            try
            {
                var inputLine = ReadLine().Split();
                var command = inputLine[0];
                int number = default;
                if (inputLine.Length == 2)
                {
                    number = int.Parse(inputLine[1]);
                }
                Commands(command, number, stack);
            }
            catch (InvalidOperationException)
            {
                writer.WriteLine("None");
            }
            catch (ArgumentOutOfRangeException)
            {
                writer.WriteLine("error");
            }
        }

        reader.Close();
        writer.Close();
    }

    private static void Commands(string command, int number, StackMax stack)
    {
        switch (command)
        {
            case "push":
                stack.Push(number);
                break;
            case "pop":
                stack.Pop();
                break;
            case "top":
                writer.WriteLine(stack.Top());
                break;
            case "get_max":
                writer.WriteLine(stack.GetMax());
                break;
        }
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }

    private static string ReadLine()
    {
        return reader.ReadLine();
    }
}

public class StackMax
{
    private List<int> items;

    private Stack<int> max;

    public StackMax()
    {
        items = new List<int>();
        max = new Stack<int>();
    }

    public void Push(int item)
    {
        var current_max_number = int.MinValue;
        if (max.Any())
        {
            current_max_number = max.Peek();
        }
        if (current_max_number <= item)
        {
            max.Push(item);
        }
        items.Add(item);
    }

    public int Pop()
    {
        int lastItem = items[^1];
        if (max.Any() && lastItem == max.Peek())
        {
            max.Pop();
        }
        items.RemoveAt(items.Count - 1);
        return lastItem;
    }

    public int Top()
    {
        return items[^1];
    }

    public int GetMax()
    {
        return max.Peek();
    }
}