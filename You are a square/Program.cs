using System;

Console.Write(Kata.IsSquare(90264));

public class Kata
{
    public static bool IsSquare(int n)
    {
        //best solution
        return Math.Sqrt(n) % 1 == 0;

        //my solution

        // int answer = (int)Math.Sqrt(n);
        // return Math.Pow(answer,2) == n ? true : false;
    }
}