using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Считывание массивов
/// 
/// Достаточно часто в задачах вам нужно будет обрабатывать массивы чисел.
/// Как правило, они задаются в следующем виде: на первой строке указывается
/// размер массива — число nn, на второй — перечисляются элементы массива через
/// пробел. Точный формат зависит от конкретной задачи, но этот случай — один из
/// наиболее распространённых.
/// 
/// Ввод может быть достаточно большим. Чтобы ускорить считывание,
/// рекомендуется использовать буферизацию. То же самое касается вывода
/// большого объёма данных.
/// 
/// Рассмотрим программу, которая считывает массив из nn чисел, а затем выводит его.
/// </summary>
public class Solution3
{
    private static TextReader reader;
    private static TextWriter writer;

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var numbers = ReadList();

        for (var i = 0; i < n; i++)
        {
            writer.Write("{0} ", numbers[i]);
        }

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }

    private static List<int> ReadList()
    {
        return reader.ReadLine()
            .Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
    }
}