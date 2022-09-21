using System;

Console.WriteLine(Kata.SquareDigits(231));

public class Kata
{
    public static int SquareDigits(int n)
    {
        //best solution
        string output = "";
        foreach (char c in n.ToString())
        {
            int square = int.Parse(c.ToString());
            output += (square * square);
        }
        return int.Parse(output);
        
        //my solution
        //
        // string? result = null;
        // double[] array = new double[n.ToString().Length];
        //
        // for (int i = 0; i < array.Length; i++)
        // {
        //     array[i] += Math.Pow(n % 10, 2);
        //     n /= 10;
        // }
        //
        // Array.Reverse(array);
        //
        // foreach (var helper in array)
        // {
        //     result += helper;
        // }
        //
        // return Convert.ToInt32(result);
        
    }
}