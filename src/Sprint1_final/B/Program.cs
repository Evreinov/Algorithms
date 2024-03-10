using System;
using System.IO;

public class Program
{
    private static TextReader reader;
    private static TextWriter writer;

    private const int size = 4;
    private const int totalRounds = 9;

    public static int SleightOfHand(int k, int[,] array)
    {
        var totalScore = 0;

        // Получаем вхождение каждой цифры, пройдя по массиву входных данных только один раз.
        var numbers = new int[totalRounds + 1];
        foreach (var field in array)
        {
            numbers[field]++;
        }

        // Теперь считаем, количество нажатых клавиш за раз (начиная с первого раунда).
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != 0 && numbers[i] <= k * 2)
            {
                totalScore++;
            }
        }

        return totalScore;
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var k = ReadInt();

        // Заполняем двумерный массив, хотя можно записать всё в лист, но не будем противоречить условию ;).
        var array = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            var line = ReadArray();
            for (int j = 0; j < size; j++)
            {
                array[i, j] = line[j];
            }
        }

        writer.WriteLine(SleightOfHand(k, array));

        reader.Close();
        writer.Close();
    }

    private static byte ReadInt()
    {
        return byte.Parse(reader.ReadLine());
    }

    private static int[] ReadArray()
    {
        var charArray = reader.ReadLine().ToCharArray();
        return Array.ConvertAll(charArray, c => c.Equals('.') ? 0 : (int)char.GetNumericValue(c));
    }
}