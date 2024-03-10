#if !REMOTE_JUDGE
using System.IO;
using System;

public class Node<TValue>
{
    public TValue Value { get; private set; }
    public Node<TValue> Next { get; set; }

    public Node(TValue value, Node<TValue> next)
    {
        Value = value;
        Next = next;
    }
}
#endif

public class Solution<TValue>
{
    public static void Solve(Node<TValue> head)
    {
        // Your code
        // ヽ(´▽`)/
        var writer = new StreamWriter(Console.OpenStandardOutput());
        while (head != null)
        {
            writer.WriteLine(head.Value);
            head = head.Next;
        }
        writer.Close();
    }

#if !REMOTE_JUDGE
    private static void Main()
    {
        var node3 = new Node<string>("node3", null);
        var node2 = new Node<string>("node2", node3);
        var node1 = new Node<string>("node1", node2);
        var node0 = new Node<string>("node0", node1);
        Solution<string>.Solve(node0);
        /*
        Output is:
        node0
        node1
        node2
        node3
        */
    }
#endif
}

public class Program
{
    private static void Main()
    {
        var node3 = new Node<string>("node3", null);
        var node2 = new Node<string>("node2", node3);
        var node1 = new Node<string>("node1", node2);
        var node0 = new Node<string>("node0", node1);
        Solution<string>.Solve(node0);
        /*
        Output is:
        node0
        node1
        node2
        node3
        */
    }
}