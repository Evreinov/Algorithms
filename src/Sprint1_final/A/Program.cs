using System;
using System.IO;
using System.Linq;

public class Program
{
    private static TextReader reader;
    private static TextWriter writer;

    public static int[] NearestZero(int n, int[] array)
    {
        // Заполним результирующий массив максимальными значениями (в данном случае n).
        var result = Enumerable.Repeat(n, n).ToArray();

        // Переберем входящие данные по порядку.
        for (int i = 0; i < array.Length; i++)
        {
            // Если текущее значение равно нулю, начинаем в обе стороны заполнять результирующий массив.
            if (array[i] == 0)
            {
                // вначале заполняем в обратном направлении
                var j = i;
                var distance = 0;
                while (j >= 0 && result[j] > distance)
                {
                    result[j] = distance;
                    distance++;
                    j--;
                }

                // теперь заполняем по возврастанию.
                j = i + 1;
                distance = 1;
                while (j < array.Length && array[j] > 0)
                {
                    result[j] = distance;
                    distance++;
                    j++;
                }
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var array = ReadArray();
        var result = NearestZero(n, array);
        writer.WriteLine(string.Join(" ", result));

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }

    private static int[] ReadArray()
    {
        return reader.ReadLine()
            .Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}