using System;
using System.IO;

public class F
{
    private static TextReader reader;
    private static TextWriter writer;

    private static bool IsPalindrome(string text)
    {
        bool isPalindrome = true;
        int left_pointer = 0;
        int right_pointer = text.Length - 1;

        while (left_pointer < right_pointer)
        {
            if (!char.IsLetterOrDigit(text[left_pointer]))
            {
                left_pointer++;
                continue;
            }

            if (!char.IsLetterOrDigit((text[right_pointer])))
            {
                right_pointer--;
                continue;
            }

            if (char.ToUpper(text[left_pointer]) != char.ToUpper(text[right_pointer]))
            {
                isPalindrome = false;
                break;
            }

            right_pointer--;
            left_pointer++;
        }

        return isPalindrome;
    }

    public static void Main(string[] args)
    {
        reader = new StreamReader(Console.OpenStandardInput());
        writer = new StreamWriter(Console.OpenStandardOutput());

        var text = reader.ReadLine();

        if (IsPalindrome(text))
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
}