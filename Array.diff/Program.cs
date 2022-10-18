
int[] firstArray = new[] { 1, 2, 2, 2, 3 };
int[] secondArray = new[] { 2, 3 };


Console.WriteLine(Kata.ArrayDiff(firstArray,secondArray));

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        //best solution
        return a.Where(i => !b.Contains(i)).ToArray();

        //my solution (so close :))
        // var qq = from i in a
        //     where !b.Contains(i)
        //     select i;
        //
        // return qq.ToArray();
    }
}