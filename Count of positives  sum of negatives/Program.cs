using System;
using System.Collections.Generic;
using System.Linq;

Console.Write(Kata.CountPositivesSumNegatives(new int[] {0,0}));

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        //my solution was the best
        Console.WriteLine(input.Max()+" "+ input.Where(i => i < 0).Sum());
        return new int[] {input.Max(), input.Where(i => i < 0).Sum() };
    }
}
