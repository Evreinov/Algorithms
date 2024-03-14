/*
 * Делаем все согласно описанному алгоритму в задаче.
 * Единственное, я не понимаю каким образом можно сделать округление вниз
 * без использования Math.Floor().
 */

using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static TextReader? _reader;
    private static TextWriter? _writer;
    private static Stack<int>? _stack;

    public static int Calculate(string[] array)
    {
        _stack = new Stack<int>(array.Length);
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