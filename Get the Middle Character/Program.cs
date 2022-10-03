
Console.Write(Kata.GetMiddle("zxcqwerzxq"));

public class Kata
{
    public static string GetMiddle(string s)
    {
        //best solution
        if (s.Length % 2 == 0) {
            return s.Substring(s.Length/2-1, 2);
        } else {
            return s.Substring(s.Length/2, 1);
        }
        
        //my solution
        
        // if (s.Length < 3)
        // {
        //     return s;
        // }
        // else
        // {
        //     if (s.Length % 2 == 0)
        //     {
        //         return s[s.Length / 2 - 1] + s[s.Length / 2].ToString();
        //     }
        //
        //     return s[s.Length / 2].ToString();
        // }


    }
}