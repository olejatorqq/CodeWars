Console.WriteLine(Kata.SquareSum(new []{1,2,3}));

public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        //best solution
        return numbers.Sum(x => x * x);


        //my solution

        // double power = 0;
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     power += Math.Pow(numbers[i], 2);
        // }
        //
        // return (int)power;
    }
}