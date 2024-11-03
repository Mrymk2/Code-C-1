using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine($"Mirror numbers between {n} and {m}:");
        for (int i = Math.Min(n, m); i <= Math.Max(n, m); i++)
        {
            if (IsMirrorNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsMirrorNumber(int number)
    {
        string strNumber = number.ToString();
        char[] reversedCharArray = strNumber.ToCharArray();
        Array.Reverse(reversedCharArray);
        string reversedNumber = new string(reversedCharArray);
        return strNumber == reversedNumber;
    }
}