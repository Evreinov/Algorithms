/*
 * Делаем все согласно описанному алгоритму в задаче.
 * Реализовали собственный стек.
 * Сложность алгоритма O(n), где n количество элементов в массиве.
 * Извлечением двуч чисел из стека во время вычисления, думаю можно принебречь.
 */

using System;
using System.IO;

public class Program
{
    private static TextReader? _reader;
    private static TextWriter? _writer;
    private static Stack<int>? _stack;

    public static int Calculate(string[] array)
    {
        _stack = new Stack<int>();
        foreach (var str in array)
        {
            switch (str)
            {
                case "+":
                    _stack.Push(Addition());
                    break;
                case "-":
                    _stack.Push(Subtraction());
                    break;
                case "*":
                    _stack.Push(Multiplication());
                    break;
                case "/":
                    _stack.Push(Division());
                    break;
                default:
                    _stack.Push(int.Parse(str));
                    break;
            } 
        }
        return _stack.Pop();
    }

    #region Математические операции

    /// <summary>
    /// Сложение двух последних чисел из стека.
    /// </summary>
    /// <returns>Результат сложения.</returns>
    private static int Addition()
    {
        return _stack.Pop() + _stack.Pop();
    }

    /// <summary>
    /// Вычитание двух последних чисел из стека.
    /// </summary>
    /// <returns>Результат вычитания.</returns>
    private static int Subtraction()
    {
        var second = _stack.Pop();
        var first = _stack.Pop();
        return first - second;
    }

    /// <summary>
    /// Умножение двух последних чисел из стека.
    /// </summary>
    /// <returns>Результат умножения.</returns>
    private static int Multiplication()
    {
        return _stack.Pop() * _stack.Pop();
    }

    /// <summary>
    /// Целочисленное деление двух последних чисел из стека.
    /// </summary>
    /// <returns>Результат деления.</returns>
    private static int Division()
    {
        var second = _stack.Pop();
        var first = _stack.Pop();
        var result =  (double)first / second;
        return (int)Math.Floor(result);
    } 

    #endregion

    public static void Main(string[] args)
    {
        _reader = new StreamReader(Console.OpenStandardInput());
        _writer = new StreamWriter(Console.OpenStandardOutput());

        var line = _reader.ReadLine();
        _writer.WriteLine(Calculate(line.Split()));

        _reader.Close();
        _writer.Close();
    }
}

/// <summary>
/// Небольшой самописный стек.
/// </summary>
/// <typeparam name="TValue">Тип хранимого элемента.</typeparam>
public class Stack<TValue>
{
    private Node<TValue>? head = null;

    /// <summary>
    /// Дробавить элемент.
    /// </summary>
    /// <param name="value">Элемент.</param>
    public void Push(TValue value)
    {
        var node = new Node<TValue>(value, null);
        if (head != null)
        {
            node.Next = head;
        }
        head = node;
    }

    /// <summary>
    /// Извлечь элемент.
    /// </summary>
    /// <returns>Элемент.</returns>
    public TValue Pop()
    {
        if (head is null)
        {
            throw new InvalidOperationException($"Стек {nameof(Stack<TValue>)} является пустым.");
        }
        var value = head.Value;
        head = head.Next;
        return value;
    }
}

/// <summary>
/// Элемент Stack.
/// </summary>
/// <typeparam name="TValue">Тип значения хранимого в стеке.</typeparam>
public class Node<TValue>
{
    /// <summary>
    /// Значение.
    /// </summary>
    public TValue Value { get; set; }

    /// <summary>
    /// Следующий элемент стека.
    /// </summary>
    public Node<TValue>? Next { get; set; }

    /// <summary>
    /// Создать элемент Stack.
    /// </summary>
    /// <param name="value">Значение.</param>
    /// <param name="next">Следующий элемент.</param>
    public Node(TValue value, Node<TValue>? next)
    {
        Value = value;
        Next = next;
    }
}