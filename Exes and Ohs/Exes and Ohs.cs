using System.Linq;
using System;

Console.WriteLine(Kata.XO("xXxXasdooOO"));

public static class Kata 
{
    public static bool XO (string input)
    {
        //best solution
        return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
        
        //my solution
        //
        // int countO = 0;
        // int countX = 0;
        // foreach (var helper in input.ToLower())
        // {
        //     if (helper.ToString() == "o")
        //     {
        //         countO++;
        //     }else if (helper.ToString() == "x")
        //     {
        //         countX++;
        //     }
        // }
        //
        // if (countO == countX)
        // {
        //     return true;
        // }
        // return false;
    }
}