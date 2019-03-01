public class Kata
{
    public static int Main()
    {
        var res = UnluckyDays(2017);
        return res;
    }

    public static int UnluckyDays(int year)
    {
        var count = 0;
        for (int month = 1; month <= 12; month++)
        {
            var date = new DateTime(year, month, 13);
            if (date.DayOfWeek == DayOfWeek.Friday)
                count++;
        }
        return count;
    }
}
