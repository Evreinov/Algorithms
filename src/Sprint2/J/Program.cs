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
        var queue = new Queue();

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
            case "put":
                queue.Put(number);
                break;
            case "get":
                writer.WriteLine(queue.Get());
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
    private Node<int> head;
    private Node<int> tail;
    private int size;

    public Queue()
    {
        size = 0;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public void Put(int x)
    {
        var node = new Node<int>(x, head, tail);
        if (head is null)
        {
            head = node;
            tail = node;
        }

        tail.Next = node;
        head.Prev = node;
        tail = node;
        size++;
    }

    public int Get()
    {
        if (IsEmpty())
        {
            throw new ArgumentOutOfRangeException();
        }
        var x = head.Value;
        if (size > 1)
        {
            var prev = head.Prev;
            var next = head.Next;
            prev.Next = next;
            next.Prev = prev;
            head = next;
        }
        if (size == 1)
        {
            head = null;
            tail = null;
        }
        size --;
        return x;
    }

    public int Size()
    {
        return size;
    }
}

public class Node<TValue>
{
    public TValue Value { get; set; }

    public Node<TValue> Next { get; set; }

    public Node<TValue> Prev { get; set; }

    public Node(TValue value, Node<TValue> next, Node<TValue> prev)
    {
        Value = value;
        Next = next;
        Prev = prev;
    }
}