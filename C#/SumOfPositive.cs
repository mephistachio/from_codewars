using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {

        int PositiveSum = arr.Sum(x => (x < 0 ? 0 : x));

        return PositiveSum;
    }
}
