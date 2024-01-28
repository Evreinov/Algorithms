using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class E
{
    private static TextReader reader;
    private static TextWriter writer;

    // Если ответ существует, верните список из двух элементов
    // Если нет - то верните пустой список
    //public static List<int> TwoSum(List<int> array, int targetSum)
    //{
    //    // Здесь реализация вашего решения
    //    int i = 0;
    //    int j = array.Count - 1;
    //    while (i < j)
    //    {
    //        var current_sum = array[i] + array[j];
    //        if (current_sum > targetSum)
    //        {
    //            j--;
    //        }

    //        if (current_sum < targetSum)
    //        {
    //            i++;
    //        }

    //        else if (current_sum == targetSum)
    //        {
    //            return new List<int> { array[i], array[j] };
    //        }
    //    }

    //    return new List<int>();
    //}

    public static List<int> TwoSum(List<int> array, int targetSum)
    {
        // Здесь реализация вашего решения
        var previous = new HashSet<int>();

        for (int i = 0; i < array.Count; i++)
        {
            var result = targetSum - array[i];
            if (previous.Contains(result))
            {
                return new List<int> { result, array[i] };
            }
            previous.Add(array[i]);
        }
        return new List<int>();
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var array = ReadList();
        var targetSum = ReadInt();
        var result = TwoSum(array, targetSum);
        writer.WriteLine(!result.Any() ? "None" : string.Join(" ", result));

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