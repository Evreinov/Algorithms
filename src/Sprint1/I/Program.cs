using System;
using System.IO;

public class I
{
    private static TextReader reader;
    private static TextWriter writer;

    private static bool IsPowerOfFour(int n)
    {
        if (n == 1) // Ноль в степени 4
        {
            return true;
        }
        if (n % 4 == 0)
        {
            var difference = n / 4;
            if (difference == 1)
            {
                return true;
            }
            
            if (difference > 0)
            {
                return IsPowerOfFour(difference);
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var n = ReadInt();
        if (IsPowerOfFour(n))
        {
            writer.WriteLine("True");
        }
        else
        {
            writer.WriteLine("False");
        }

        reader.Close();
        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }
}