﻿#if !REMOTE_JUDGE
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
    public static Node<TValue> Solve(Node<TValue> head, int idx)
    {
        // Your code
        // ヽ(´▽`)/
        if (idx == 0)
        {
            return head.Next;
        }

        var previous_node = head;
        while (idx - 1 > 0)
        {
            previous_node = previous_node.Next;
            idx--;
        }
        previous_node.Next = previous_node.Next?.Next;
        return head;
    }

#if !REMOTE_JUDGE
    private static void Main()
    {
        var node3 = new Node<string>("node3", null);
        var node2 = new Node<string>("node2", node3);
        var node1 = new Node<string>("node1", node2);
        var node0 = new Node<string>("node0", node1);
        var newHead = Solution<string>.Solve(node0, 1);
        // result is : node0 -> node2 -> node3
    }
#endif
}

public class Program
{
    static void Main()
    {
        var node3 = new Node<string>("node3", null);
        var node2 = new Node<string>("node2", node3);
        var node1 = new Node<string>("node1", node2);
        var node0 = new Node<string>("node0", node1);
        var newHead = Solution<string>.Solve(node0, 3);
    }
}