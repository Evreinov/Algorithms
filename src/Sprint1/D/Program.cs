using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class D
{
    private static TextReader reader;
    private static TextWriter writer;

    private static int GetWeatherRandomness(List<int> temperatures)
    {
        if (temperatures.Count == 1)
        {
            return 1;
        }

        int weather_randomness = 0;

        for (int i = 0; i < temperatures.Count; i++)
        {
            if (i == 0)
            {
                if (temperatures[i] > temperatures[i + 1])
                {
                    weather_randomness++;
                }
                continue;
            }

            if (i == temperatures.Count - 1)
            {
                if (temperatures[i] > temperatures[i - 1])
                {
                    weather_randomness++;
                }
                continue;
            }

            if (temperatures[i] > temperatures[i - 1] && temperatures[i] > temperatures[i + 1])
            {
                weather_randomness++;
            }
        }

        return weather_randomness;
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var numberOfDays = ReadInt();
        var temperatures = ReadList();
        var chaosNumber = GetWeatherRandomness(temperatures);

        writer.WriteLine(chaosNumber);

        reader.Close();
        writer.Close();
    }

    private static List<int> ReadList()
    {
        return reader.ReadLine()
            .Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}