/*
 * Делаем по аналогии с задачей J. Списочная очередь.
 * Круговой двухсвязный список у которого два указателя на front и back.
 *
 * 1. Сложность работы с Дек - O(1), потому что нет переборов внутри коллекции,
 * есть только два указателя, по которым мы добавлям и извлекаем значения.
 *
 * 2. Сложность самой программы - O(n), где n - число введенных команд.
 */

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

        var totalCommands = ReadInt();
        var capacity = ReadInt();

        var deque = new Deque<int>(capacity);

        for (int i = 0; i < totalCommands; i++)
        {
            var inputLine = ReadLine().Split();
            var command = inputLine[0];
            int value = default;
            if (inputLine.Length == 2)
            {
                value = int.Parse(inputLine[1]);
            }

            var result = Execute(command, value, deque);

            if (result is not null)
            {
                writer.WriteLine(result);
            }
        }

        reader.Close();
        writer.Close();
    }

    private static string Execute(string command, int value, Deque<int> deque)
    {
        try
        {
            switch (command)
            {
                case "push_front":
                    deque.PushFront(value);
                    return default;
                case "push_back":
                    deque.PushBack(value);
                    return default;
                case "pop_front":
                    return deque.PopFront().ToString();
                case "pop_back":
                    return deque.PopBack().ToString();
                default:
                    throw new NotSupportedException();
            }
        }
        catch (InvalidOperationException)
        {
            return "error";
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

#region Структуры данных

/// <summary>
/// Дек.
/// </summary>
/// <typeparam name="TValue">Тип хранимого элемента.</typeparam>
public class Deque<TValue>
{
    private Node<TValue>? _front;
    private Node<TValue>? _back;
    private readonly int _capacity;

    private int _count;

    /// <summary>
    /// Количество элементов.
    /// </summary>
    public int Count => _count;

    /// <summary>
    /// Создать новый экземпляр дека.
    /// </summary>
    /// <param name="capacity">Ёмкость дека.</param>
    public Deque(int capacity)
    {
        _capacity = capacity;
    }

    /// <summary>
    /// Добавить элемент в конец дека.
    /// </summary>
    /// <param name="value">Элемент.</param>
    /// <exception cref="InvalidOperationException">Если в деке уже находится максимальное число элементов.</exception>
    public void PushBack(TValue value)
    {
        CanPush(true);
        var node = new Node<TValue>(value, _front, _back);
        if (_back is null)
        {
            _front = node;
            _back = node;
        }

        _back.Next = node;
        _front.Prev = node;
        _back = node;
        _count++;
    }

    /// <summary>
    /// Добавить элемент в начало дека.
    /// </summary>
    /// <param name="value">Элемент.</param>
    /// <exception cref="InvalidOperationException">Если в деке уже находится максимальное число элементов.</exception>
    public void PushFront(TValue value)
    {
        CanPush(true);
        var node = new Node<TValue>(value, _front, _back);
        if (_front is null)
        {
            _front = node;
            _back = node;
        }

        _back.Next = node;
        _front.Prev = node;
        _front = node;
        _count++;
    }

    /// <summary>
    /// Вывести первый элемент дека и удалить его. 
    /// </summary>
    /// <returns>Элемент.</returns>
    /// <exception cref="InvalidOperationException">Если дек был пуст.</exception>
    public TValue PopBack()
    {
        IsEmpty(true);
        var x = _back.Value;
        if (Count > 1)
        {
            var prev = _back.Prev;
            var next = _back.Next;
            prev.Next = next;
            next.Prev = prev;
            _back = prev;
        }
        if (Count == 1)
        {
            Clear();
        }
        _count--;
        return x;
    }

    /// <summary>
    /// Вывести последний элемент дека и удалить его.
    /// </summary>
    /// <returns>Элемент.</returns>
    /// <exception cref="InvalidOperationException">Если дек был пуст.</exception>
    public TValue PopFront()
    {
        IsEmpty(true);
        var x = _front.Value;
        if (Count > 1)
        {
            var prev = _front.Prev;
            var next = _front.Next;
            prev.Next = next;
            next.Prev = prev;
            _front = next;
        }
        if (Count == 1)
        {
            Clear();
        }
        _count--;
        return x;
    }

    /// <summary>
    /// Проверка на переполнение емкости дека. 
    /// </summary>
    /// <param name="throwException">Если true, то выкинуть исключение.</param>
    /// <returns>true - можно добавить элемент, false - емкость дека достигла максимального значения.</returns>
    /// <exception cref="InvalidOperationException">Если в деке уже находится максимальное число элементов.</exception>
    private bool CanPush(bool throwException)
    {
        var isFull = Count == _capacity;
        if (isFull && throwException)
        {
            throw new InvalidOperationException($"Дек {nameof(Deque<TValue>)} привышена ёмкость.");
        }
        return !isFull;
    }

    /// <summary>
    /// Проверка является ли дек пустым.
    /// </summary>
    /// <param name="throwException">Если true, то выкинуть исключение.</param>
    /// <returns>true - дек пуст, false - дек содержит значения.</returns>
    /// <exception cref="InvalidOperationException">Если дек был пуст.</exception>
    private bool IsEmpty(bool throwException)
    {
        var isEmpty = Count == 0;
        if (isEmpty && throwException)
        {
            throw new InvalidOperationException($"Дек {nameof(Deque<TValue>)} является пустой.");
        }
        return isEmpty;
    }

    /// <summary>
    /// Очистить дек.
    /// </summary>
    private void Clear()
    {
        _front = null;
        _back = null;
    }
}

/// <summary>
/// Элемент Deque.
/// </summary>
/// <typeparam name="TValue">Тип значения хранимого в деке.</typeparam>
public class Node<TValue>
{
    /// <summary>
    /// Значение.
    /// </summary>
    public TValue Value { get; set; }

    /// <summary>
    /// Следующий элемент дека.
    /// </summary>
    public Node<TValue>? Next { get; set; }

    /// <summary>
    /// Предыдущий элемент дека.
    /// </summary>
    public Node<TValue>? Prev { get; set; }

    /// <summary>
    /// Создать элемент Deque.
    /// </summary>
    /// <param name="value">Значение.</param>
    /// <param name="next">Следующий элемент.</param>
    /// <param name="prev">Предыдущий элемент.</param>
    public Node(TValue value, Node<TValue>? next, Node<TValue>? prev)
    {
        Value = value;
        Next = next;
        Prev = prev;
    }
} 

#endregion