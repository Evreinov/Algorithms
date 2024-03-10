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

    public void Push(int x)
    {
        tail = new Node<int>(x, null, null);
        if (head is null)
        {
            head = tail;
        }

        tail.Next = head;
        head.Prev = tail;

        tail.Prev = head.Next;
        head.Next = tail.Prev;
        
        size++;
    }

    public int Pop()
    {
        return 0;
        //if (IsEmpty())
        //{
        //    throw new InvalidOperationException();
        //}
        //int x = queue[head];
        //queue[head] = 0;
        //head = (head + 1) % max_n;
        //size -= 1;
        //return x;
    }

    public int Size()
    {
        return size;
    }

    public int Peek()
    {
        return 0;
        //if (IsEmpty())
        //{
        //    throw new InvalidOperationException();
        //}
        //return queue[head];
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