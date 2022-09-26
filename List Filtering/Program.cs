using System.Collections;
using System.Collections.Generic;

Console.Write(ListFilterer.GetIntegersFromList(new List<object>(){1,"a","b",0,15}));

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        //best solution
        return listOfItems.OfType<int>();



        //my solution

        // List<int> returnList = new List<int>();
        //
        // foreach (var item in listOfItems)
        // {
        //     if (item is int)
        //     {
        //         returnList.Add((int)item);
        //     }
        // }
        //
        // return returnList;
    }
}