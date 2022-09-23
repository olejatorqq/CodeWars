using System.Collections.Generic;


Console.WriteLine(Kata.UniqueInOrder(new[] {"ABBCcAD"}));

public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
  {
    //best solution
    T previous = default(T);
    foreach(T current in iterable)
    {
      if (!current.Equals(previous))
      {
        previous = current;
        //yield????????????????
        yield return current;
      }
    }


    //this is the most difficult task for me (My solution) (it doesn't work)

    // var answer = iterable.Distinct();
    // return answer;
  }
}