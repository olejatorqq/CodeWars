using System;
using System.Collections.Generic;

Console.WriteLine(Kata.FriendOrFoe(new []{"Oleg","Max","Champion","Magamed","Ivan"}));


public static class Kata {
    public static IEnumerable<string> FriendOrFoe (string[] names)
    {
        //best solution
        return names.Where(name => name.Length == 4);

        // my solution

        // var letters4 = from name in names
        //     where name.Length == 4
        //     select name;
        //
        // return letters4;
    }
}