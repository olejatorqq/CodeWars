
Console.WriteLine(DivisibleNb.isDivisible(12,2,3));

public class DivisibleNb 
{
    public static bool isDivisible(long n, long x, long y)
    {
        //my solution is the best
        return n % x == 0 && n % y == 0;
    }
}