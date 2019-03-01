using System.Linq;

public static class Kata
{
    public static int TotalPoints(string[] games)
    {

        int total = 0;
        for (int i = 0; i < games.Length; i++)
        {
            string[] strArray = games[i].Split(':');


            int x = int.Parse(strArray[0]);
            int y = int.Parse(strArray[1]);

            if (x > y) total = total + 3;
            if (x == y) total = total + 1;
        }
        return total;
    }
}
