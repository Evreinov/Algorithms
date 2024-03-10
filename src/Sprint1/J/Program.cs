using System;
using System.Collections.Generic;
using System.IO;

public class J
{
    private static TextReader reader;
    private static TextWriter writer;

    private static List<int> Factorize(int n)
    {
        var simpleNumbers = GetSimpleNumbers(n);
        var result = new List<int>();
        GetMultipliers(n, ref result, simpleNumbers);
        return result;
    }

    private static List<int> GetSimpleNumbers(int n)
    {
        var simpleNumbers = new List<int>();

        for (int i = 2; i <= n; i++)
        {
            simpleNumbers.Add(i);
        }

        for (int i = 0; i < simpleNumbers.Count; i++)
        {
            for (int j = 2; j < simpleNumbers.Count; j++)
            {
                simpleNumbers.Remove(simpleNumbers[i] * j);
            }
        }

        return simpleNumbers;
    }

    private static void GetMultipliers(int n, ref List<int> result, List<int> simpleNumbers)
    {
        foreach (var number in simpleNumbers)
        {
            if (n % number == 0)
            {
                result.Add(number);
                GetMultipliers(n / number, ref result, simpleNumbers);
                return;
            }
        }
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        var factorization = Factorize(n);
        writer.WriteLine(string.Join(" ", factorization));

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}