using System;
using System.Collections.Generic;
using System.IO;

public class H
{
    private static TextReader reader;
    private static TextWriter writer;

    private static string SumOfBinaries(string a, string b)
    {
        string shortString;
        string longString;
        int lengthDifference;

        if (a.Length <= b.Length)
        {
            shortString = a;
            longString = b;
            lengthDifference = b.Length - a.Length;
        }
        else
        {
            shortString = b;
            longString = a;
            lengthDifference = a.Length - b.Length;
        }

        var dominantBitCount = 0;
        var result = new List<char>();

        int i = longString.Length - 1;
        do
        {
            if (i - lengthDifference >= 0)
            {
                var a_bit = shortString[i - lengthDifference];
                if (a_bit == '1')
                {
                    dominantBitCount++;
                }
            }

            if (i >= 0)
            {
                var b_bit = longString[i];
                if (b_bit == '1')
                {
                    dominantBitCount++;
                }
            }
            
            switch (dominantBitCount)
            {
                case 0:
                    result.Add('0');
                    break;
                case 1:
                    result.Add('1');
                    dominantBitCount = 0;
                    break;
                case 2:
                    result.Add('0');
                    dominantBitCount = 1;
                    break;
                case 3:
                    result.Add('1');
                    dominantBitCount = 1;
                    break;
            }
            i--;

        } while (i >= 0 || dominantBitCount != 0);

        result.Reverse();
        return new string(result.ToArray());
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var a = reader.ReadLine();
        var b = reader.ReadLine();
        writer.WriteLine(SumOfBinaries(a, b));

        reader.Close();
        writer.Close();
    }
}