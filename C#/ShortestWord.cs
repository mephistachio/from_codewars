using System.Linq;

public class Kata
{
    public static int FindShort(string s)
    {
        var mword = s.Split(' ').Select(lenghts => lenghts.Length).Min();
        return mword;

    }
}
