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

        var totalCommands = ReadInt();
        var sizeQueue = ReadInt();
        var queue = new Queue(sizeQueue);

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
                Commands(command, number, queue);
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

    private static void Commands(string command, int number, Queue queue)
    {
        switch (command)
        {
            case "push":
                queue.Push(number);
                break;
            case "pop":
                writer.WriteLine(queue.Pop());
                break;
            case "peek":
                writer.WriteLine(queue.Peek());
                break;
            case "size":
                writer.WriteLine(queue.Size());
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

internal class Queue
{
    private int[] queue;
    private int head;
    private int tail;
    private int max_n;
    private int size;

    public Queue(int n)
    {
        queue = new int[n];
        head = 0;
        tail = 0;
        max_n = n;
        size = 0;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public void Push(int x)
    {
        if (size != max_n)
        {
            queue[tail] = x;
            tail = (tail + 1) % max_n;
            size += 1;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException();
        }
        int x = queue[head];
        queue[head] = 0;
        head = (head + 1) % max_n;
        size -= 1;
        return x;
    }

    public int Size()
    {
        return size;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException();
        }
        return queue[head];
    }
}