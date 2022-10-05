using System.Linq;

Console.WriteLine(ArraysInversion.InvertValues(new int[] {-1,2,-3,-4,-5}));

public static class ArraysInversion
{
    public static int[] InvertValues(int[] input)
    {
        //best solution
        return input.Select(n => -n).ToArray();

        //my solution

        // var qq = from i in input
        //     select i*-1;
        //
        // return qq.ToArray();
    }
}